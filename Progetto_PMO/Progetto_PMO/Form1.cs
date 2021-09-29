using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Progetto_PMO
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();           
        }


        //Ti porta alla schermata di login dell'ufficiale di polizia
        private void sectionPolice_Click(object sender, EventArgs e)
        {
            Hide();
            new FormAccessPolice().Show();
        }

        //Ti porta alla schermata di login del cittadino
        private void sectionMan_Click(object sender, EventArgs e)
        {
            Hide();
            new FormAccessCivil().Show();
        }
    }
}
