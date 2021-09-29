using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Progetto_PMO
{
    //Questa è la classe figlio di user
    //Di conseguenza eredita attributi e metodi
    class Police : User
    {
        //Questi sono gli attributi in più che differenziano la classe
        private string grado;
        private string istituto;

        //Metodi associati agli attributi
        public string Grado { get => grado; set => grado = value; }
        public string Istituto { get => istituto; set => istituto = value; }

        //Questa funzione ci permette di inserire nel DB un utente Ufficiale di polizia
        public bool insertUser(SqlConnection con)
        {
            con.Open();
            bool idEquals = false;
            bool insert = false;

            //Questo blocco controlla se ci sono codici fiscali identici all'interno del databse
            try
            {
                SqlCommand cmdControl = new SqlCommand("SELECT Codice_fiscale FROM Ufficiale;", con);
                SqlDataReader reader = cmdControl.ExecuteReader();
                while (reader.Read() && idEquals == false)
                {

                    if (CodFisc == reader.GetString(0))
                        idEquals = true;

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Una volta passati i controlli potrà essere inserito nella tabella
            if (idEquals == false)
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Ufficiale VALUES('" + CodFisc + "','"
                                                                                 + Nome + "','"
                                                                                 + Cognome + "','"
                                                                                 + Email + "','"
                                                                                 + Password + "','"
                                                                                 + Grado + "','"
                                                                                 + Istituto + "');"
                                                                                 , con);

                cmd.ExecuteReader();
                MessageBox.Show("L'account è stato creato");
                insert = true;
            }
            else
                MessageBox.Show("Questo codice fiscale è già stato inserito");

            con.Close();
            return insert;
        }
    }
}
