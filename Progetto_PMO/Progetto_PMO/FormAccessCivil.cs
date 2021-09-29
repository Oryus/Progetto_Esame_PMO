using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Progetto_PMO
{
    public partial class FormAccessCivil : Form
    {
        public FormAccessCivil()
        {
            InitializeComponent();
            InitializeTbArray();
        }
        //Stringa per connettersi al db
        SqlConnection con = new Condb().getCon();
        //Array che serve a raggruppare le TextBox 
        TextBox[] arrayTb = new TextBox[3];

        //Permette di tornare alla pagina precedente
        private void imgTurnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }

        //Porta alla pagina di registrazione del cittadino
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new FormRegisterCivil().Show();
        }

        //Registra l'account del cittadino
        private void btEnter_Click(object sender, EventArgs e)
        {
            
            cancellaCaratteri();

            if (tbCodFisc.Text != "" && tbEmail.Text != "" && tbPsw.Text != "")
            {
                //Funzione login che restituisce una variabile boolena
                if (Login())
                {
                    //se vera si accede al form del civile
                    new FormCivil(tbCodFisc.Text).Show();
                    Hide();
                }
            }
            else
                MessageBox.Show("Non hai inserito tutti i campi");

        }
        //Inserisce le TextBox nell'array
        private void InitializeTbArray()
        {
            arrayTb[0] = tbCodFisc;
            arrayTb[1] = tbEmail;
            arrayTb[2] = tbPsw;
        }
        //Funzione che permette di cancellare tutti gli spazi all'interno delle textbox
        private void cancellaCaratteri()
        {
            for (int i = 0; i < arrayTb.Length; i++)
            {
                arrayTb[i].Text = arrayTb[i].Text.Trim();
            }
        }

        private bool Login()
        {
            bool idEquals = false;
            con.Open();

            //Comando SQL che estrae i dati dalla tabella Cittadino
            SqlCommand cmdControl = new SqlCommand("SELECT Codice_fiscale, Email, Password FROM Cittadino;", con);
            SqlDataReader reader = cmdControl.ExecuteReader();

            //Ciclo che permette di scorrere i vari dati estratti
            while (reader.Read() && idEquals == false)
            {
                //Controllo per vedere le credenziali se sono esatte
                if (tbCodFisc.Text == reader.GetString(0) && tbEmail.Text == reader.GetString(1) && tbPsw.Text == reader.GetString(2))
                {
                    idEquals = true;
                    MessageBox.Show("Complimenti hai effettuato l'accesso");
                }
            }
            if (idEquals == false)
                MessageBox.Show("Le credenziali non sono corrette");

            reader.Close();

            con.Close();

            return idEquals;
        }
    }
}
