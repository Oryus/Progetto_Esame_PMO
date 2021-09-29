using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Progetto_PMO
{
    public partial class FormCivil : Form
    {

        private string CodFisc;
        Civil user = new Civil();
        BuilderCivil builderC = new BuilderCivil();

        Fine multa = new Fine();

        //Connette al DB
        SqlConnection con = new Condb().getCon();
        
        public FormCivil(string CodFisc)
        {
            InitializeComponent();
            //Ci facciamo passare il codice fiscale del civile dal form precedente
            this.CodFisc = CodFisc;
            //Funzione che ci permete di cercare l'utente nel database
            searchUser();
            //Funzione che ci permette di aggiornare i dati in tabella
            UpdateDataGridView();
        }

        //Questa funzione ci permette di cercare i dati del cittadino
        private void searchUser()
        {
            con.Open();
            //Query che seleziona la riga dove c'è il codice fiscale precedentemente recuperato
            SqlCommand cmdControl = new SqlCommand("SELECT * FROM Cittadino WHERE Codice_fiscale = '" + CodFisc + "' ;", con);
            SqlDataReader reader = cmdControl.ExecuteReader();
            while (reader.Read() )
            {
                //Inizializzazione dell'utente civile
                user = builderC.buildCodFisc(reader.GetString(0))                           //Inserisce il codice fiscale
                                .buildNome(reader.GetString(1))                             //Inserisce il nome
                                .buildCognome(reader.GetString(2))                          //Inserisce il cognome
                                .buildEmail(reader.GetString(3))                            //Inserisce la mail
                                .buildPassword(reader.GetString(4))                         //Inserisce la password
                                .buildIndirizzo(reader.GetString(5), reader.GetString(6))   //Inserisce l'indirizzo, costituito da via e comune
                                .buildCellulare(reader.GetString(7))                        //Inserisce il numero cellulare
                                .Build();                                                   //Inizializza il civile

            }

            reader.Close();
            con.Close();

            //Aggiorna le etichette con nome e cognome dell'utente
            lbNome.Text = user.Nome;
            lbCognome.Text = user.Cognome;

        }

        private void UpdateDataGridView()
        {
            con.Open();
            //Pulisce tutte le righe nella datagridview
            dataGridView1.Rows.Clear();
            string stato;
            //Seleziona tutte le multe appartenenti al codice fiscale del civile
            SqlCommand cmdControl = new SqlCommand("SELECT * FROM Multa WHERE Nome_Cittad = '" + user.CodFisc + "' ;", con);
            SqlDataReader reader = cmdControl.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetBoolean(9).ToString() == "True")
                    stato = "Pagato";
                else
                    stato = "Non pagato";
                
                string[] row = { reader.GetInt32(0).ToString(),          //Imposta Id multa
                                 reader.GetDateTime(5).ToString("d"),    //Imposta Data
                                 reader.GetDateTime(7).ToString("d"),    //Imposta scadenza
                                 reader.GetString(8) +".00 €",           //Imposta importo
                                 reader.GetString(6),                    //Imposta Descrizione
                                 stato };                                //Imposta Stato pagamento
                dataGridView1.Rows.Add(row);

            }
            reader.Close();



            con.Close();
        }

        //Si torna alla pagina precedente
        private void imgTurnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new FormAccessCivil().Show();
        }

        //Ritorna alla prima pagina
        private void btLogout_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }

        //Funzione che permette di pagare la multa
        private void btPaga_Click(object sender, EventArgs e)
        {
            //prende l'indice della riga selezionata nella datagridview
            int r = -1;
            if (dataGridView1.RowCount > 0)
                r = dataGridView1.CurrentCell.RowIndex;

            int Id_m = Convert.ToInt32(dataGridView1[0, r].Value);

            //se questo indice è minore di 0 nessuna riga è stata selezionata
            if (r > -1 && multa.searchMulta(Id_m, con).Id != 0)
            {
                //prende lo stato della multa in quella riga
                string State_m = dataGridView1[5, r].Value.ToString();

                //Se lo stato della multa è non pagato si procede ad aggiornare lo stato di pagamento della multa
                if (State_m == "Non pagato")
                {

                    con.Open();

                    //Query che aggiorna la multa nel DB
                    SqlCommand cmdControl = new SqlCommand("UPDATE Multa SET Stato_pagam = 'True' WHERE Id = " + Id_m + ";", con);
                    cmdControl.ExecuteReader();

                    con.Close();

                    MessageBox.Show("Hai pagato la multa");
                    UpdateDataGridView();
                }
                else
                    MessageBox.Show("Questa multa è gia stata pagata");
            }
            else
                MessageBox.Show("Non hai selezionato nulla");
        }

        //Permette di aggiornare la datagridview
        private void imgUpdate_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        //Questa funzione ci permette di vedere piu dettagli della multa
        private void btEspandi_Click(object sender, EventArgs e)
        {

            //prende l'indice della riga selezionata nella datagridview
            int r = -1;
            if (dataGridView1.RowCount > 0)
                r = dataGridView1.CurrentCell.RowIndex;

            int Id_m = Convert.ToInt32(dataGridView1[0, r].Value);

            //se questo indice è minore di 0 nessuna riga è stata selezionata
            if (r > -1 && multa.searchMulta(Id_m, con).Id != 0)
            {
                new Descrizione_multa(Id_m).Show();
            }
            else
                MessageBox.Show("Non hai selezionato nulla");


        }
    }
}
