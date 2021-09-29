
namespace Progetto_PMO
{
    partial class FormNewMulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewMulta));
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbCittad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbComune = new System.Windows.Forms.TextBox();
            this.tbVia = new System.Windows.Forms.TextBox();
            this.tbDescrizione = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btConferma = new System.Windows.Forms.Button();
            this.imgTurnBack = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbImporto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTurnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(213, 32);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(274, 33);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Inserisci nuova multa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbCittad
            // 
            this.cbCittad.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCittad.FormattingEnabled = true;
            this.cbCittad.Location = new System.Drawing.Point(286, 202);
            this.cbCittad.Name = "cbCittad";
            this.cbCittad.Size = new System.Drawing.Size(135, 27);
            this.cbCittad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15F);
            this.label2.Location = new System.Drawing.Point(190, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Cittadino";
            // 
            // tbComune
            // 
            this.tbComune.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComune.Location = new System.Drawing.Point(286, 235);
            this.tbComune.Margin = new System.Windows.Forms.Padding(2);
            this.tbComune.MaxLength = 20;
            this.tbComune.Name = "tbComune";
            this.tbComune.Size = new System.Drawing.Size(135, 27);
            this.tbComune.TabIndex = 43;
            // 
            // tbVia
            // 
            this.tbVia.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVia.Location = new System.Drawing.Point(286, 267);
            this.tbVia.Margin = new System.Windows.Forms.Padding(2);
            this.tbVia.MaxLength = 20;
            this.tbVia.Name = "tbVia";
            this.tbVia.Size = new System.Drawing.Size(135, 27);
            this.tbVia.TabIndex = 44;
            // 
            // tbDescrizione
            // 
            this.tbDescrizione.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescrizione.Location = new System.Drawing.Point(285, 357);
            this.tbDescrizione.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescrizione.MaxLength = 150;
            this.tbDescrizione.Multiline = true;
            this.tbDescrizione.Name = "tbDescrizione";
            this.tbDescrizione.Size = new System.Drawing.Size(192, 103);
            this.tbDescrizione.TabIndex = 45;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 300);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.Value = new System.DateTime(2021, 8, 22, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15F);
            this.label1.Location = new System.Drawing.Point(197, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Comune";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15F);
            this.label3.Location = new System.Drawing.Point(227, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "Viale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 15F);
            this.label4.Location = new System.Drawing.Point(230, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 15F);
            this.label5.Location = new System.Drawing.Point(167, 356);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 50;
            this.label5.Text = "Descrizione";
            // 
            // btConferma
            // 
            this.btConferma.Location = new System.Drawing.Point(286, 502);
            this.btConferma.Margin = new System.Windows.Forms.Padding(2);
            this.btConferma.Name = "btConferma";
            this.btConferma.Size = new System.Drawing.Size(133, 43);
            this.btConferma.TabIndex = 54;
            this.btConferma.Text = "Conferma";
            this.btConferma.UseVisualStyleBackColor = true;
            this.btConferma.Click += new System.EventHandler(this.btConferma_Click);
            // 
            // imgTurnBack
            // 
            this.imgTurnBack.Image = global::Progetto_PMO.Properties.Resources.left_arrow;
            this.imgTurnBack.Location = new System.Drawing.Point(26, 20);
            this.imgTurnBack.Margin = new System.Windows.Forms.Padding(2);
            this.imgTurnBack.Name = "imgTurnBack";
            this.imgTurnBack.Size = new System.Drawing.Size(33, 32);
            this.imgTurnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTurnBack.TabIndex = 55;
            this.imgTurnBack.TabStop = false;
            this.imgTurnBack.Click += new System.EventHandler(this.imgTurnBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15F);
            this.label6.Location = new System.Drawing.Point(202, 325);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "Importo";
            // 
            // tbImporto
            // 
            this.tbImporto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImporto.Location = new System.Drawing.Point(286, 325);
            this.tbImporto.Margin = new System.Windows.Forms.Padding(2);
            this.tbImporto.MaxLength = 5;
            this.tbImporto.Name = "tbImporto";
            this.tbImporto.Size = new System.Drawing.Size(135, 27);
            this.tbImporto.TabIndex = 56;
            // 
            // FormNewMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 630);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbImporto);
            this.Controls.Add(this.imgTurnBack);
            this.Controls.Add(this.btConferma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbDescrizione);
            this.Controls.Add(this.tbVia);
            this.Controls.Add(this.tbComune);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCittad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormNewMulta";
            this.Text = "FormNewMulta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTurnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbCittad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbComune;
        private System.Windows.Forms.TextBox tbVia;
        private System.Windows.Forms.TextBox tbDescrizione;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btConferma;
        private System.Windows.Forms.PictureBox imgTurnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbImporto;
    }
}