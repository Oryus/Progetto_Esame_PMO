using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Progetto_PMO
{
    public partial class FormNewMulta : Form
    {
        //Connesiona al DB
        SqlConnection con = new Condb().getCon();
        string Nome_Uff;
        TextBox[] arrayTb = new TextBox[4];
        //Inizializzazione multa
        Fine multa = new Fine();
        BuilderFine builder = new BuilderFine();

        public FormNewMulta(string Nome_Uff)
        {
            InitializeComponent();
            //Prende il codice fiscale dell'ufficiale
            this.Nome_Uff = Nome_Uff;
            InitializeCB();
            InitializeTbArray();

        }

        //Inserisce i codici fiscali dei cittadini nelle combo box
        public void InitializeCB()
        {
            con.Open();
            
            //Query che estrae tutti i codici fiscali nella tabella cittadino
            SqlCommand cmd = new SqlCommand("SELECT Codice_fiscale FROM Cittadino", con);
            
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbCittad.Items.Add(reader.GetString(0));
            }
            reader.Close();
            
            con.Close();

        }

        //Funzione che permette di creare una nuova multa
        private void btConferma_Click(object sender, EventArgs e)
        {
            //Questa funzione ci permette di togliere gli spazi a inizio o fine parola/frase
            cancellaCaratteri();

            if (cbCittad.Text != "" && tbDescrizione.Text != "" && tbImporto.Text != ""
                && tbComune.Text != "" && tbVia.Text != ""
                && dateTimePicker1.Value != null)
            {
                //Si inseriscono i dati della multa
                multa = builder.buildNomeCitt(cbCittad.Text)
                               .buildNomeUff(Nome_Uff)
                               .buildIndirizzo(tbComune.Text, tbVia.Text)
                               .buildData(dateTimePicker1.Value)
                               .buildDescr(tbDescrizione.Text)
                               .buildImporto(tbImporto.Text)
                               .Build();

                //Questa funzione permette di inserira la multa
                if (multa.insertMulta(con))
                {
                    //Se la procedura va a buon fine lascerà un messaggio
                    MessageBox.Show("Multa inserita");
                    Hide();
                }

            }
            else
                MessageBox.Show("Non hai inserito tutti i campi");
        }

        //Questa funzione ci permette di chiudere la finestra di modifica
        private void imgTurnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }


        private void InitializeTbArray()
        {
            arrayTb[0] = tbComune;
            arrayTb[1] = tbVia;
            arrayTb[2] = tbImporto;
            arrayTb[3] = tbDescrizione;
        }
        private void cancellaCaratteri()
        {
            for (int i = 0; i < arrayTb.Length; i++)
            {
                arrayTb[i].Text = arrayTb[i].Text.Trim();
            }
            cbCittad.Text = cbCittad.Text.Trim();
        }
    }
}
