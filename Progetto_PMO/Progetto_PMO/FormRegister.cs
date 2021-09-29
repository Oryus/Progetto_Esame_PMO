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
    public partial class FormRegister : MaterialForm
    {

        protected bool ImgCitt = false;
        protected bool ImgPol = false;
        public FormRegister()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        public void ChangeImg()
        {
            if (ImgCitt == false)
                ImgRegCitt.Image = Image.FromFile(@"C:\Users\pulic\source\repos\Progetto_PMO\Progetto_PMO\Img\icoManD.png");
            if (ImgCitt == true)
                ImgRegCitt.Image = Image.FromFile(@"C:\Users\pulic\source\repos\Progetto_PMO\Progetto_PMO\Img\icoMan.png");

            if (ImgPol == false)
                ImgRegPol.Image = Image.FromFile(@"C:\Users\pulic\source\repos\Progetto_PMO\Progetto_PMO\Img\icoPulaD.png");
            if (ImgPol == true)
                ImgRegPol.Image = Image.FromFile(@"C:\Users\pulic\source\repos\Progetto_PMO\Progetto_PMO\Img\icoPula.png");
        }

        private void ImgRegCitt_Click(object sender, EventArgs e)
        {
            ImgCitt = true;
            if (ImgPol != false)
                ImgPol = false;
            ChangeImg();
        }

        private void ImgRegPol_Click(object sender, EventArgs e)
        {
            ImgPol = true;
            if (ImgCitt != false)
                ImgCitt = false;
            ChangeImg();
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new Form1 { };
            form.Show();
        }
    }
}
