
namespace Progetto_PMO
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAccess = new System.Windows.Forms.Label();
            this.labelSubTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sectionMan = new System.Windows.Forms.PictureBox();
            this.sectionPolice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sectionMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionPolice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAccess
            // 
            this.labelAccess.AutoSize = true;
            this.labelAccess.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccess.Location = new System.Drawing.Point(287, 146);
            this.labelAccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccess.Name = "labelAccess";
            this.labelAccess.Size = new System.Drawing.Size(103, 33);
            this.labelAccess.TabIndex = 0;
            this.labelAccess.Text = "Accedi";
            // 
            // labelSubTitle
            // 
            this.labelSubTitle.AutoSize = true;
            this.labelSubTitle.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTitle.Location = new System.Drawing.Point(237, 195);
            this.labelSubTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubTitle.Name = "labelSubTitle";
            this.labelSubTitle.Size = new System.Drawing.Size(202, 17);
            this.labelSubTitle.TabIndex = 3;
            this.labelSubTitle.Text = "Clicca sull\'icona di tuo interesse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "SISTEMA PAGAMENTO MULTE";
            // 
            // sectionMan
            // 
            this.sectionMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sectionMan.Image = global::Progetto_PMO.Properties.Resources.man;
            this.sectionMan.Location = new System.Drawing.Point(367, 227);
            this.sectionMan.Margin = new System.Windows.Forms.Padding(2);
            this.sectionMan.Name = "sectionMan";
            this.sectionMan.Size = new System.Drawing.Size(167, 162);
            this.sectionMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sectionMan.TabIndex = 2;
            this.sectionMan.TabStop = false;
            this.sectionMan.Click += new System.EventHandler(this.sectionMan_Click);
            // 
            // sectionPolice
            // 
            this.sectionPolice.Image = global::Progetto_PMO.Properties.Resources.police_officer;
            this.sectionPolice.Location = new System.Drawing.Point(133, 227);
            this.sectionPolice.Margin = new System.Windows.Forms.Padding(2);
            this.sectionPolice.Name = "sectionPolice";
            this.sectionPolice.Size = new System.Drawing.Size(167, 162);
            this.sectionPolice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sectionPolice.TabIndex = 1;
            this.sectionPolice.TabStop = false;
            this.sectionPolice.Click += new System.EventHandler(this.sectionPolice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSubTitle);
            this.Controls.Add(this.sectionMan);
            this.Controls.Add(this.sectionPolice);
            this.Controls.Add(this.labelAccess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Accesso";
            ((System.ComponentModel.ISupportInitialize)(this.sectionMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionPolice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAccess;
        private System.Windows.Forms.PictureBox sectionPolice;
        private System.Windows.Forms.PictureBox sectionMan;
        private System.Windows.Forms.Label labelSubTitle;
        private System.Windows.Forms.Label label1;
    }
}

