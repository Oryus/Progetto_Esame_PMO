 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Progetto_PMO
{
    public partial class FormPolice : Form
    {
        //Connessione al DB
        SqlConnection con = new Condb().getCon();
        //Istanza ufficiale di polizia
        Police user = new Police();
        BuilderPolice builderP = new BuilderPolice();

        Fine multa = new Fine();


        private string CodFisc;

        public FormPolice(string CodFisc)
        {
            InitializeComponent();
            //Parametro passato tramite l'accesso o la registrazione dell ufficiale
            this.CodFisc = CodFisc;
            searchUser();
            UpdateDataGridView();
        }

        //Questa funzione ci permette di trovare i dati dell ufficiale all'interno del db
        private void searchUser()
        {
            con.Open();
            //Query che ci permette di andare a cercare il record con il codice fiscale precedentemente passato
            SqlCommand cmdControl = new SqlCommand("SELECT * FROM Ufficiale WHERE Codice_fiscale = '" + CodFisc + "' ;", con);
            SqlDataReader reader = cmdControl.ExecuteReader();
            while (reader.Read())
            {
                //Istanziamo l'ufficiale di polizia
                user = builderP.buildCodFisc(reader.GetString(0))       //Inseriamo il codice fiscale
                               .buildNome(reader.GetString(1))          //Inseriamo il nome
                               .buildCognome(reader.GetString(2))       //Inseriamo il cognome
                               .buildEmail(reader.GetString(3))         //Inseriamo la email
                               .buildPassword(reader.GetString(4))      //Inseriamo la password 
                               .buildGrado(reader.GetString(5))         //Inseriamo il grado dell ufficiale
                               .buildIstituto(reader.GetString(6))      //INseriamo l'istituto da cui proviene l ufficiale
                               .Build();

            }

            reader.Close();
            con.Close();

            //Assegniamo i valori dell ufficiale alle etichette
            lbNome.Text = user.Nome;
            lbCognome.Text = user.Cognome;
            lbGrado.Text = user.Grado;
            lbIstituto.Text = user.Istituto;

        }
        
        //Questa funzione ci permette di aggiornare la tabella delle multe
        private void UpdateDataGridView()
        {
            con.Open();
            //Cancella tutte le righe del datagridview
            dataGridView1.Rows.Clear();
            string stato;
            //Estraiamo tutte le multe scriutte dall ufficiale 
            SqlCommand cmdControl = new SqlCommand("SELECT * FROM Multa WHERE Nome_Uff = '" + user.CodFisc + "' ;", con);
            SqlDataReader reader = cmdControl.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetBoolean(9).ToString() == "True")
                    stato = "Pagato";
                else
                    stato = "Non pagato";

                string[] row = { reader.GetInt32(0).ToString(),          //Imposta Id multa
                                 reader.GetString(1),                    //Imposta il codice fiscale del cittadino multato
                                 reader.GetDateTime(5).ToString("d"),    //Imposta Data
                                 reader.GetDateTime(7).ToString("d"),    //Imposta scadenza
                                 reader.GetString(8) +".00 €",           //Imposta importo
                                 stato };                                //Imposta Stato pagamento
                dataGridView1.Rows.Add(row);

            }
            reader.Close();



            con.Close();
        }

        //Ci torna alla pagina precedente
        private void imgTurnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new FormAccessPolice().Show();
        }
        //Ci torna alla pagina principale
        private void btLogout_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }
        //Ci permette di aggiornare la datagridview
        private void imgUpdate_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        //Questa funzione ci permette di trovare più informazioni riguardanti la multa 
        private void btEspandi_Click(object sender, EventArgs e)
        {
            //prende l'indice della riga selezionata nella datagridview
            int r = -1;
            if (dataGridView1.RowCount > 0)
                r = dataGridView1.CurrentCell.RowIndex;

            //Questo è l'id della multa selezionata
            int Id_m = Convert.ToInt32(dataGridView1[0, r].Value);
            

            //se questo indice è minore di 0 nessuna riga è stata selezionata
            if (r > -1 && multa.searchMulta(Id_m, con).Id != 0)
            {
                //La funzione cerca_Multa ci permette di restituire un tipo Fine(multa) che passiamo come parametro al form Descrizione_multa
                new Descrizione_multa(Id_m).Show();
            }
            else
                MessageBox.Show("Non hai selezionato nulla"); 
        }

        //Questa funzione ci aprirà un nuovo form dove potremo creare una nuova multa
        private void btN_multa_Click(object sender, EventArgs e)
        {
            new FormNewMulta(user.CodFisc).Show();
        }

        //Questa funzione i aprirà un nuovo form dove potremo modificare una multa già esistente
        private void btModifica_Click(object sender, EventArgs e)
        {
            int r = -1;
            if (dataGridView1.RowCount > 0)
                r = dataGridView1.CurrentCell.RowIndex;

            //Questo è l'id della multa selezionata
            int Id_m = Convert.ToInt32(dataGridView1[0, r].Value);
            
            if (r > -1 && multa.searchMulta(Id_m, con).Id != 0)
            {
                new FormModMulta(Id_m).Show();
            }
            else
                MessageBox.Show("Non hai selezionato nulla");
        }

        
    }
}
