using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Progetto_PMO
{
    public partial class FormRegisterCivil : Form
    {
        

        public FormRegisterCivil()
        {
            InitializeComponent();
            //Funzione che permette di inserire le TextBox all'interno dell array
            InitializeTbArray();
        }

        //Arrray che serve per raggruppare le TextBox
        TextBox[] arrayTb = new TextBox[8];
        //Connette al DB
        SqlConnection con = new Condb().getCon();
        
        BuilderCivil builder = new BuilderCivil();
        Civil user = new Civil();

        //Apre il form di login del civile
        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new FormAccessCivil().Show();
        }

        //torna indietro alla pagina precedente
        private void imgTurnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new FormAccessCivil().Show();
        }

        //funzione che permette di registrare il profilo civile
        private void btRegister_Click(object sender, EventArgs e)
        {
            //questa funzione permmette di cancellare i caratteri spazio
            cancellaCaratteri();

            if (tbName.Text != "" && tbSurname.Text != "" && tbCodFisc.Text != "" &&
                tbEmail.Text != "" && tbPsw.Text != "" && tbCell.Text != "" &&
                tbStreet.Text != "" && tbCom.Text != "")
            {
                //inizializzo l'utente predendo i parametri dal form
                user = builder.buildCodFisc(tbCodFisc.Text)                    //Inserisce codice fiscale
                              .buildNome(tbName.Text)                          //Inserisce nome
                              .buildCognome(tbSurname.Text)                    //Inserisce cognome 
                              .buildEmail(tbEmail.Text)                        //Inserisce email
                              .buildPassword(tbPsw.Text)                       //Inserisce password
                              .buildIndirizzo(tbStreet.Text, tbCom.Text)       //Inserisce l'indirizzo, composto dal comune e dalla via
                              .buildCellulare(tbCell.Text)                     //Inserisce il numero cellulare
                              .Build();                                        //Costruiamo l'utente

                //insertUser permette di inserire l'utente nel DB, se quasta procedura andrà a buon fine si potrà accedere alla sezione dedicata al civile
                if (user.insertUser(con))
                {
                    Hide();
                    new FormCivil(user.CodFisc).Show();
                }
            }
            else
                MessageBox.Show("Non hai inserito tutti i campi");


        }

        private void InitializeTbArray()
        {
            arrayTb[0] = tbName;
            arrayTb[1] = tbSurname;
            arrayTb[2] = tbCodFisc;
            arrayTb[3] = tbEmail;
            arrayTb[4] = tbPsw;
            arrayTb[5] = tbCell;
            arrayTb[6] = tbStreet;
            arrayTb[7] = tbCom;
        }

        //Cancella i caratteri spazio all'interno delle textbox del form
        private void cancellaCaratteri()
        {
            for (int i = 0; i < arrayTb.Length; i++)
            {
                arrayTb[i].Text = arrayTb[i].Text.Trim();
            }
        }
    }
}
