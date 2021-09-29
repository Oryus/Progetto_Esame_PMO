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
    public partial class Descrizione_multa : Form
    {
        //Istanza di multa
        private Fine multa = new Fine();
        //Istanza del cittadino
        Civil civile = new Civil();
        BuilderCivil builderC = new BuilderCivil();
        //Istanza dell ufficiale di polizia
        Police ufficiale = new Police();
        BuilderPolice builderP = new BuilderPolice();
        //Connessione al DB
        SqlConnection con = new Condb().getCon();

        public Descrizione_multa(int Id)
        {
            InitializeComponent();

            //Prende i dati della multa con l'id specificato
            multa.searchMulta(Id, con);
            //Prende i dati del cittadino che ha ricevuto la multa
            searchCivil();
            //Prende i dati dell ufficiale di polizia che ha scritto la multa
            searchOfficer();
            //Inserisce i dati presi precedentemente dalla multa e le inserisce nel form 
            InitializeFine();
        }

        //Questa funzione ci permettera di raccogliere i dati della persona che ha ricevuto la multa
        private void searchCivil()
        {
            con.Open();
            //Query che raccoglie i dati in db del cittadino
            SqlCommand cmdControl = new SqlCommand("SELECT * FROM Cittadino WHERE Codice_fiscale = '" + multa.Nome_Citt + "' ;", con);
            SqlDataReader reader = cmdControl.ExecuteReader();

            while (reader.Read())
            {
                //Inizializzazione del cittadino
                civile = builderC.buildCodFisc(reader.GetString(0))                             //Inserisce il codice fiscale
                                 .buildNome(reader.GetString(1))                                //Inserisce il nome
                                 .buildCognome(reader.GetString(2))                             //Inserisce il cognome
                                 .buildEmail(reader.GetString(3))                               //Inserisce la mail 
                                 .buildPassword(reader.GetString(4))                            //Inserisce la password
                                 .buildIndirizzo(reader.GetString(5), reader.GetString(6))      //Inserisce l'indirizzo, che comprende via e comune
                                 .buildCellulare(reader.GetString(7))                           //Inserisce il numero cellulare
                                 .Build();                                                      //Restituisce il cittadino
            }

            reader.Close();
            con.Close();

        }
        //Questa funzione ci permettera di raccogliere i dati dell ufficiale di polizia che ha scritto la multa
        private void searchOfficer()
        {
            con.Open();
            //Query che raccoglie i dati dell'ufficiale di polizia
            SqlCommand cmdControl = new SqlCommand("SELECT * FROM Ufficiale WHERE Codice_fiscale = '" + multa.Nome_Uff + "' ;", con);
            SqlDataReader reader = cmdControl.ExecuteReader();

            while (reader.Read())
            {
                //Inzializziamo l' ufficiale
                ufficiale = builderP.buildCodFisc(reader.GetString(0))      //Inserisce il codice fiscale
                                    .buildNome(reader.GetString(1))         //Inserisce il nome
                                    .buildCognome(reader.GetString(2))      //Inserisce il cognome
                                    .buildEmail(reader.GetString(3))        //Inserisce la email
                                    .buildPassword(reader.GetString(4))     //Inserisce la password
                                    .buildGrado(reader.GetString(5))        //Inserisce il grado
                                    .buildIstituto(reader.GetString(6))     //Inserisce l'istituto
                                    .Build();                               //Restituisce l ufficiale
            }

            reader.Close();
            con.Close();

        }
        //Questa funzione ci compila il form della descrizione inserendoci i dati della multa
        private void InitializeFine()
        {
            lbTitle.Text = "Multa id: " + multa.Id.ToString() + "°" ;                       //Inserisce l'id della multa nel titolo
            lbNome.Text = "Nome: " + civile.Nome;                                           //Inserisce il nome del cittadino
            lbCognome.Text = "Cognome: " + civile.Cognome;                                  //Inserisce il cognome del cittadino
            lbUfficiale.Text = "Ufficiale: " + ufficiale.Nome + ", " + ufficiale.Cognome;   //Inserisce il nome e cognome dell'ufficiale
            lbData.Text = "Data: " + multa.Data.ToString("d");                              //Inserisce la data di scrittura della multa
            lbScadenza.Text = "Scadenza: " + multa.Scadenza.ToString("d");                  //Inserisce la data di scadenza della multa
            lbImporto.Text = "Importo: " + multa.Importo.ToString() + ".00 €";              //Inserisce l'importo della multa
            lbIndirizzo.Text = "Comune: " + multa.Comune + "   Via: " + multa.Via;          //Inserisce il posto dell'accaduto
            lbDescr.Text = "Descrizione: " + multa.Descrizione;                             //Inserisce la descrizione dell'accuduto
            
            //a seconda se la multa è stata pagata o meno, l'etichetta verrà contrassegnata in verde o roso
            if (multa.Stato.ToString() == "False")
            {
                lbStato.ForeColor = Color.Red;
                lbStato.Text = "Stato pagamento: " + "Non pagato";
            }
            else
            {
                lbStato.ForeColor = Color.Green;
                lbStato.Text = "Stato pagamento: " + "Pagato";
            }
        }

        //Questa funzione ci permette di chiudere il form
        private void imgTurnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
