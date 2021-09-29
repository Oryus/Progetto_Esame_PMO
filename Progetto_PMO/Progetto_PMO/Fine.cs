using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Progetto_PMO
{
    public class Fine
    {
        //Attributi della classe Fine(multa)
        private int id;
        private string nome_Citt, nome_Uff;
        private string comune, via;
        private DateTime data, scadenza;
      
        private string descrizione;
        private string importo;
        private bool stato = false;

        //Metodi associati agli attributi
        public int Id { get => id; set => id = value; }
        public string Nome_Citt { get => nome_Citt; set => nome_Citt = value; }
        public string Nome_Uff { get => nome_Uff; set => nome_Uff = value; }
        public string Comune { get => comune; set => comune = value; }
        public string Via { get => via; set => via = value; }
        public DateTime Data { get => data; set => data = value; }
        public DateTime Scadenza { get => scadenza; set => scadenza = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public string Importo { get => importo; set => importo = value; }
        public bool Stato { get => stato; set => stato = value; } 

        //Questa funzione ci permette di inserire la multa all'interno del DB
        public bool insertMulta(SqlConnection con)
        {
            con.Open();
            
            //Variabili di controllo
            bool insert = false;
            bool isNumber = true;
            bool isEquals = false;

            //Query che seleziona tutti i codici fiscali presenti nella tabella cittadino
            //Serve a controllare se il codice fiscale inserito dall'utente coincide con quelli presenti nel DB
            SqlCommand cmdControl = new SqlCommand("SELECT Codice_fiscale FROM Cittadino", con);
            SqlDataReader read = cmdControl.ExecuteReader();
            while (read.Read() && isEquals == false)
            {
                if(read.GetString(0) == Nome_Citt)
                {
                    isEquals = true;
                }
            }
            read.Close();

            //Controllo per vedere se l'importo è un tipo intero
            try
            {
                Convert.ToInt64(Importo);
            }
            catch
            {
                isNumber = false;
            }

            //Una volta passati i controlli si potrà inserire la multa nel DB
            if (isEquals == true)
            {
                if (isNumber == true)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Multa VALUES('" + nome_Citt + "','"
                                                                                 + nome_Uff + "','"
                                                                                 + comune + "','"
                                                                                 + via + "',"
                                                                                 + "@Data" + ",'"
                                                                                 + descrizione + "',"
                                                                                 + "@Scadenza" + ",'"
                                                                                 + importo + "','"
                                                                                 + stato + "');"
                                                                                 , con);
                    cmd.Parameters.AddWithValue("@Data", data);
                    cmd.Parameters.AddWithValue("@Scadenza", scadenza);
                    cmd.ExecuteReader();
                    insert = true;
                }
                else
                    MessageBox.Show("L'importo è sbagliato");
            }
            else
                MessageBox.Show("Il codice fiscale del cittadino è errato");


            con.Close();
            //Ritorna un tipo booleano per vedere se è andato a buon fine il procedimento
            return insert;
        }

        //Questa funzione ci permette di modificare una multa già esistente
        public bool modMulta(int Id, SqlConnection con)
        {
            con.Open();

            //Variabili di controllo
            bool insert = false;
            bool isNumber = true;
            bool isEquals = false;

            //Query che seleziona tutti i codici fiscali presenti nella tabella cittadino
            //Serve a controllare se il codice fiscale inserito dall'utente coincide con quelli presenti nel DB
            SqlCommand cmdControl = new SqlCommand("SELECT Codice_fiscale FROM Cittadino", con);
            SqlDataReader read = cmdControl.ExecuteReader();
            while (read.Read() && isEquals == false)
            {
                if (read.GetString(0) == Nome_Citt)
                {
                    isEquals = true;
                }
            }
            read.Close();

            //Controllo per verificare se l'importo è di tipo int
            try
            {
                Convert.ToInt64(Importo);
            }
            catch
            {
                isNumber = false;
            }

            if (isEquals == true)
            {
                if (isNumber == true)
                {
                    //Query che aggiorna i dati in tabella
                    SqlCommand cmd = new SqlCommand("UPDATE Multa SET Nome_Cittad = '" + nome_Citt +
                                                                  "', Comune = '"      + comune +
                                                                  "', Viale = '"       + via +
                                                                  "', Data = "         + "@Data" +
                                                                  ",  Descrizione = '" + descrizione +
                                                                  "', Scadenza = "     + "@Scadenza" +
                                                                  ",  Importo = '"     + importo + "' " +

                                                                  "WHERE Id =" + Id + " ;" 
                                                                  , con);

                    cmd.Parameters.AddWithValue("@Data", data);
                    cmd.Parameters.AddWithValue("@Scadenza", scadenza);
                    cmd.ExecuteReader();
                    insert = true;
                }
                else
                    MessageBox.Show("L'importo è sbagliato");
            }
            else
                MessageBox.Show("Il codice fiscale del cittadino è errato");

            con.Close();
            return insert;
        }

        //Funzione che permette di cercare una multa all'interno del db tramite ID
        public Fine searchMulta(int Id, SqlConnection con)
        {
            con.Open();
            //Query che seleziona la multa
            SqlCommand cmd = new SqlCommand("SELECT * FROM Multa WHERE Id = " + Id + ";", con);
            SqlDataReader reader = cmd.ExecuteReader();

            //Reset dell'ID
            id = 0;

            //Costruzione multa da restituire
            while (reader.Read())
            {
                id = reader.GetInt32(0);
                nome_Citt = reader.GetString(1);
                nome_Uff = reader.GetString(2);
                comune = reader.GetString(3);
                via = reader.GetString(4);
                data = reader.GetDateTime(5);
                descrizione = reader.GetString(6);
                scadenza = reader.GetDateTime(7);
                importo = reader.GetString(8);
                stato = reader.GetBoolean(9);
            }

            con.Close();
            return this;
        }
    }
}
