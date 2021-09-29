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
    public partial class FormAccessPolice : Form
    {
        public FormAccessPolice()
        {
            InitializeComponent();
            //Inserisce le TextBox nell'array
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

        //Porta alla pagina di registrazione dell ufficiale di polizia
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new FormRegisterPolice().Show();
        }

        //Registra l'account dell ufficiale di polizia
        private void btEnter_Click(object sender, EventArgs e)
        {
            //Funzione che permette di cancellare tutti gli spazi all'interno delle textbox
            cancellaCaratteri();
            if (tbCodFisc.Text != "" && tbEmail.Text != "" && tbPsw.Text != "")
            {
                //Funzione login che restituisce una variabile boolena
                if (login(con)) 
                {
                    //se vera si accede al form dell ufficiale di polizia
                    new FormPolice(tbCodFisc.Text).Show();
                    Hide();
                }
            }
            else
                MessageBox.Show("inserisci tutte le credenziali");
            
        }

        private bool login( SqlConnection con)
        {
            bool idEquals = false;
            con.Open();
            //Comando SQL che estrae i dati dalla tabella Ufficiale
            SqlCommand cmdControl = new SqlCommand("SELECT Codice_fiscale, Email, Password FROM Ufficiale;", con);
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

        private void InitializeTbArray()
        {
            arrayTb[0] = tbCodFisc;
            arrayTb[1] = tbEmail;
            arrayTb[2] = tbPsw;
        }
        private void cancellaCaratteri()
        {
            for (int i = 0; i < arrayTb.Length; i++)
            {
                arrayTb[i].Text = arrayTb[i].Text.Trim();
            }
        }
    }
}
