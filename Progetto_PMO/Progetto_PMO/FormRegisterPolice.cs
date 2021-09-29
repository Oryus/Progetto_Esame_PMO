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
    public partial class FormRegisterPolice : Form
    {
        public FormRegisterPolice()
        {
            InitializeComponent();
            //Funzione che iniziallizza la listbox
            InitializeDegree();
            //Funzione che permette di inserire le TextBox all'interno dell array
            InitializeTbArray();
        }

        //Arrray che serve per raggruppare le TextBox
        TextBox[] arrayTb = new TextBox[6];
        //Connette al DB
        SqlConnection con = new Condb().getCon();
        BuilderPolice builder = new BuilderPolice();
        Police user = new Police();


        //Torna alla pagina precedente
        private void imgTurnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new FormAccessPolice().Show();
        }

        //Questa funzione serve a poter selezionare solo ed esclusivamente un elemento all'interno della listbox
        private void listboxDegree_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < listboxDegree.Items.Count; ++ix)
                if (ix != e.Index) listboxDegree.SetItemChecked(ix, false);
        }

        //Apre il form del login del poliziotto
        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new FormAccessPolice().Show();
        }
        //Funzione che permette di registrare l'account dell'ufficiale di polizia
        private void btRegister_Click(object sender, EventArgs e)
        {
            //questa funzione ci permette di cancellari i caratteri spazio
            cancellaCaratteri();

            if (tbName.Text != "" && tbSurname.Text != "" && tbCodFisc.Text != "" &&
                tbEmail.Text != "" && tbPsw.Text != "" && listboxDegree.SelectedItem != null &&
                tbIstitute.Text != "")
            {
                //Inizializiamo l'utente poliziotto
                user = builder.buildCodFisc(tbCodFisc.Text)                         //Inseriamo il codice fiscale
                              .buildNome(tbName.Text)                               //Inseriamo il nome
                              .buildCognome(tbSurname.Text)                         //Inseriamo il cognome
                              .buildEmail(tbEmail.Text)                             //Ineriamo la mail
                              .buildPassword(tbPsw.Text)                            //Inseriamo la password
                              .buildGrado(listboxDegree.SelectedItem.ToString())    //Inseriamo il grado dell'uffiaciale
                              .buildIstituto(tbIstitute.Text)                       //Inseriamo l'istituto da cui proviene
                              .Build();                                             //Costruiamo l'utente

                //Tramite insertUser possiamo inserire l'utente Ufficiale nel suo DB, se questa procedura avrà successo si potrà accedere alla sezione dedicata agli ufficiali di polizia
                if (user.insertUser(con))
                {
                    Hide();
                    new FormPolice(user.CodFisc).Show();
                }
            }
            else
                MessageBox.Show("Non hai inserito tutti i campi");

        }

        
        //Inseriamo i vari tipi di grado all'interno della listbox
        private void InitializeDegree()
        {
            listboxDegree.Items.Add("Dirigente");
            listboxDegree.Items.Add("Commissario");
            listboxDegree.Items.Add("Ispettore");
            listboxDegree.Items.Add("Sovrintendente");
            listboxDegree.Items.Add("Agente");
        }

        private void InitializeTbArray()
        {
            arrayTb[0] = tbName;
            arrayTb[1] = tbSurname;
            arrayTb[2] = tbCodFisc;
            arrayTb[3] = tbEmail;
            arrayTb[4] = tbPsw;
            arrayTb[5] = tbIstitute;
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
