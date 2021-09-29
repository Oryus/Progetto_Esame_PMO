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
    public partial class FormModMulta : Form
    {
        //Connessione al DB
        SqlConnection con = new Condb().getCon();
        Fine multa = new Fine();

        TextBox[] arrayTb = new TextBox[4];
        public FormModMulta(int id)
        {
            InitializeComponent();
            multa.searchMulta(id, con);
            InsertFine();
            InitializeTbArray();
            InitializeCB();
        }
        //Permette di inserire tutti i codici fiscali all'interno della combo box
        public void InitializeCB()
        {
            con.Open();
            //Query che seleziona tutte i codici fiscali presenti nel db
            SqlCommand cmd = new SqlCommand("SELECT Codice_fiscale FROM Cittadino", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Aggiunge il codice fiscale all'interno della cb
                cbCittad.Items.Add(reader.GetString(0));
            }
            reader.Close();
            con.Close();

        }
        //Imposta i campi con i dati della multa prima selezionata
        private void InsertFine()
        {
            cbCittad.Text = multa.Nome_Citt;
            tbComune.Text = multa.Comune;
            tbVia.Text = multa.Via;
            dateTimePicker1.Value = multa.Data;
            tbImporto.Text = multa.Importo;
            tbDescrizione.Text = multa.Descrizione;
        }

        //Ci permette di modificare la multa con i nuovi dati
        private void btModifica_Click(object sender, EventArgs e)
        {
            //Cancella tutti gli spazi prima e dopo della frase
            cancellaCaratteri();


            if (cbCittad.Text != "" && tbDescrizione.Text != "" && tbImporto.Text != ""
                && tbComune.Text != "" && tbVia.Text != ""
                && dateTimePicker1.Value != null)
            {
                //Inserisce i nuovi dati nell'istanza multa
                multa.Nome_Citt = cbCittad.Text;
                multa.Comune = tbComune.Text;
                multa.Via = tbVia.Text;
                multa.Data = dateTimePicker1.Value;
                multa.Scadenza = multa.Data.AddMonths(3);
                multa.Importo = tbImporto.Text;
                multa.Descrizione = tbDescrizione.Text;

                //Questa funzione modifica i dati all'interno del Db
                if (multa.modMulta(multa.Id, con))
                {
                    //se l'operazione viene completata ci restituire una messaggio di successo
                    MessageBox.Show("La multa è stata modificata con successo");
                    Hide();
                }
            }
            else
                MessageBox.Show("Non hai inserito tutti i campi");

        }

        private void InitializeTbArray()
        {
            arrayTb[0] = tbComune;
            arrayTb[1] = tbVia;
            arrayTb[2] = tbImporto;
            arrayTb[3] = tbDescrizione;
        }

        //Questa funzione cancella i caratteri spazio all'inizio e alla fine della frase/parola
        private void cancellaCaratteri()
        {
            for (int i = 0; i < arrayTb.Length; i++)
            {
                arrayTb[i].Text = arrayTb[i].Text.Trim();
            }
            cbCittad.Text = cbCittad.Text.Trim();
        }

        //Questa funzione ci permette di eliminare una multa selezionata
        private void btElimina_Click(object sender, EventArgs e)
        {
            con.Open();
            //Query che elimina la multa a livello di db
            SqlCommand cmd = new SqlCommand("DELETE FROM Multa WHERE Id = '" + multa.Id + "' ;", con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("La Multa è stata eliminata");
                Hide();
            }

            
            con.Close();
        }

        //Ci permette di tornare alla pagina precedente
        private void imgTurnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
