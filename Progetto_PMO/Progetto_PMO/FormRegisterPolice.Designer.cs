
namespace Progetto_PMO
{
    partial class FormRegisterPolice
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
            this.btRegister = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIstitute = new System.Windows.Forms.TextBox();
            this.listboxDegree = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPsw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodFisc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.imgTurnBack = new System.Windows.Forms.PictureBox();
            this.imgPolice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTurnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPolice)).BeginInit();
            this.SuspendLayout();
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(400, 785);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(200, 66);
            this.btRegister.TabIndex = 34;
            this.btRegister.Text = "Registrati";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 15F);
            this.label7.Location = new System.Drawing.Point(285, 717);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 37);
            this.label7.TabIndex = 33;
            this.label7.Text = "Istituto";
            // 
            // tbIstitute
            // 
            this.tbIstitute.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIstitute.Location = new System.Drawing.Point(400, 717);
            this.tbIstitute.MaxLength = 20;
            this.tbIstitute.Name = "tbIstitute";
            this.tbIstitute.Size = new System.Drawing.Size(200, 36);
            this.tbIstitute.TabIndex = 32;
            // 
            // listboxDegree
            // 
            this.listboxDegree.CheckOnClick = true;
            this.listboxDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxDegree.FormattingEnabled = true;
            this.listboxDegree.Location = new System.Drawing.Point(400, 615);
            this.listboxDegree.Name = "listboxDegree";
            this.listboxDegree.Size = new System.Drawing.Size(200, 112);
            this.listboxDegree.TabIndex = 31;
            this.listboxDegree.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listboxDegree_ItemCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15F);
            this.label6.Location = new System.Drawing.Point(298, 615);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 37);
            this.label6.TabIndex = 30;
            this.label6.Text = "Grado";
            // 
            // tbPsw
            // 
            this.tbPsw.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPsw.Location = new System.Drawing.Point(400, 565);
            this.tbPsw.MaxLength = 30;
            this.tbPsw.Name = "tbPsw";
            this.tbPsw.PasswordChar = '*';
            this.tbPsw.Size = new System.Drawing.Size(200, 36);
            this.tbPsw.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 15F);
            this.label5.Location = new System.Drawing.Point(244, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 37);
            this.label5.TabIndex = 28;
            this.label5.Text = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(400, 515);
            this.tbEmail.MaxLength = 35;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 36);
            this.tbEmail.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 15F);
            this.label4.Location = new System.Drawing.Point(296, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "E-Mail";
            // 
            // tbCodFisc
            // 
            this.tbCodFisc.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodFisc.Location = new System.Drawing.Point(400, 465);
            this.tbCodFisc.MaxLength = 16;
            this.tbCodFisc.Name = "tbCodFisc";
            this.tbCodFisc.Size = new System.Drawing.Size(200, 36);
            this.tbCodFisc.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15F);
            this.label3.Location = new System.Drawing.Point(189, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "Codice fiscale";
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSurname.Location = new System.Drawing.Point(400, 415);
            this.tbSurname.MaxLength = 20;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(200, 36);
            this.tbSurname.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15F);
            this.label2.Location = new System.Drawing.Point(248, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cognome";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(400, 365);
            this.tbName.MaxLength = 20;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 36);
            this.tbName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15F);
            this.label1.Location = new System.Drawing.Point(297, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome";
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.Location = new System.Drawing.Point(400, 49);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(201, 48);
            this.labelRegister.TabIndex = 18;
            this.labelRegister.Text = "Registrati";
            // 
            // linkLogin
            // 
            this.linkLogin.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin.LinkColor = System.Drawing.Color.Black;
            this.linkLogin.Location = new System.Drawing.Point(396, 882);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(136, 19);
            this.linkLogin.TabIndex = 36;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Sei già registrato?";
            this.linkLogin.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // imgTurnBack
            // 
            this.imgTurnBack.Image = global::Progetto_PMO.Properties.Resources.left_arrow;
            this.imgTurnBack.Location = new System.Drawing.Point(40, 29);
            this.imgTurnBack.Name = "imgTurnBack";
            this.imgTurnBack.Size = new System.Drawing.Size(50, 49);
            this.imgTurnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTurnBack.TabIndex = 35;
            this.imgTurnBack.TabStop = false;
            this.imgTurnBack.Click += new System.EventHandler(this.imgTurnBack_Click);
            // 
            // imgPolice
            // 
            this.imgPolice.Image = global::Progetto_PMO.Properties.Resources.police_officer;
            this.imgPolice.Location = new System.Drawing.Point(400, 125);
            this.imgPolice.Name = "imgPolice";
            this.imgPolice.Size = new System.Drawing.Size(200, 200);
            this.imgPolice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPolice.TabIndex = 19;
            this.imgPolice.TabStop = false;
            // 
            // FormRegisterPolice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 945);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.imgTurnBack);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbIstitute);
            this.Controls.Add(this.listboxDegree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPsw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCodFisc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgPolice);
            this.Controls.Add(this.labelRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRegisterPolice";
            this.Text = "Registrazione Agente";
            ((System.ComponentModel.ISupportInitialize)(this.imgTurnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPolice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIstitute;
        private System.Windows.Forms.CheckedListBox listboxDegree;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPsw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodFisc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgPolice;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.PictureBox imgTurnBack;
        private System.Windows.Forms.LinkLabel linkLogin;
    }
}