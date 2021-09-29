using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Progetto_PMO
{
    //Questa è la classe figlio di user
    //Di conseguenza eredita attributi e metodi
    class Civil : User
    {
        //Questi sono gli attributi in più che differenziano la classe
        private string via;
        private string comune;
        private string cellulare;

        //Metodi associati agli attributi
        public string Via { get => via; set => via = value; }
        public string Comune { get => comune; set => comune = value; }
        public string Cellulare { get => cellulare; set => cellulare = value; }

        //Questa funzione ci permette di inserire nel DB un utente Cittadino
        public bool insertUser(SqlConnection con)
        {
            con.Open();
            //Variabili bool di controllo
            bool isNumber = true;   //Controla se il cellulare è un numero
            bool idEquals = false;  //Controlla se esiste già un utente con lo stesso codice fiscale
            bool insert = false;    //Contolla se viene inserito correttamente l'utente

            //Questo blocco controlla se ci sono codici fiscali identici all'interno del databse
            SqlCommand cmdControl = new SqlCommand("SELECT Codice_fiscale FROM Cittadino;", con);
            SqlDataReader reader = cmdControl.ExecuteReader();
            while (reader.Read() && idEquals == false)
            {

                if (CodFisc == reader.GetString(0))
                    idEquals = true;

            }
            reader.Close();


            //Controllo, banale, se nella tabella verrà inserito un numero di telefono
            try
            {
                Convert.ToInt64(Cellulare);
            }
            catch
            {
                isNumber = false;
            }

            //Una volta passati i controlli potrà essere inserito nella tabella
            if (idEquals == false)
            {
                if (isNumber == true)
                {
                    //Query di inserimento
                    SqlCommand cmd = new SqlCommand("INSERT INTO Cittadino VALUES('" + CodFisc + "','"      //Inserisce il codice fiscale
                                                                                     + Nome + "','"         //Inserisce il nome
                                                                                     + Cognome + "','"      //Inserisce il cognome
                                                                                     + Email + "','"        //Inserisce la email
                                                                                     + Password + "','"     //Inserice la password
                                                                                     + Via + "','"          //Inserisce la via
                                                                                     + Comune + "','"       //Inserisce il comune
                                                                                     + Cellulare + "');"    //Inserisce il cellulare
                                                                                     , con);

                    cmd.ExecuteReader();
                    insert = true;
                    MessageBox.Show("L'account è stato creato");
                }
                else
                    MessageBox.Show("non hai inserito un numero di telefono");
            }
            else
                MessageBox.Show("Questo codice fiscale è già stato inserito");
            
            con.Close();
            return insert;
        }



            
        
     }
}
