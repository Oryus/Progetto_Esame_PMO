
namespace Progetto_PMO
{
    partial class FormRegisterCivil
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
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.imgTurnBack = new System.Windows.Forms.PictureBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
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
            this.imgMan = new System.Windows.Forms.PictureBox();
            this.labelRegister = new System.Windows.Forms.Label();
            this.tbCell = new System.Windows.Forms.TextBox();
            this.tbCom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgTurnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMan)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLogin
            // 
            this.linkLogin.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin.LinkColor = System.Drawing.Color.Black;
            this.linkLogin.Location = new System.Drawing.Point(263, 573);
            this.linkLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(98, 13);
            this.linkLogin.TabIndex = 55;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Sei già registrato?";
            this.linkLogin.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // imgTurnBack
            // 
            this.imgTurnBack.Image = global::Progetto_PMO.Properties.Resources.left_arrow;
            this.imgTurnBack.Location = new System.Drawing.Point(26, 19);
            this.imgTurnBack.Margin = new System.Windows.Forms.Padding(2);
            this.imgTurnBack.Name = "imgTurnBack";
            this.imgTurnBack.Size = new System.Drawing.Size(33, 32);
            this.imgTurnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTurnBack.TabIndex = 54;
            this.imgTurnBack.TabStop = false;
            this.imgTurnBack.Click += new System.EventHandler(this.imgTurnBack_Click);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(267, 510);
            this.btRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(133, 43);
            this.btRegister.TabIndex = 53;
            this.btRegister.Text = "Registrati";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 15F);
            this.label7.Location = new System.Drawing.Point(224, 465);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Via";
            // 
            // tbStreet
            // 
            this.tbStreet.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStreet.Location = new System.Drawing.Point(267, 464);
            this.tbStreet.Margin = new System.Windows.Forms.Padding(2);
            this.tbStreet.MaxLength = 20;
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(135, 27);
            this.tbStreet.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15F);
            this.label6.Location = new System.Drawing.Point(174, 401);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 49;
            this.label6.Text = "Cellulare";
            // 
            // tbPsw
            // 
            this.tbPsw.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPsw.Location = new System.Drawing.Point(267, 367);
            this.tbPsw.Margin = new System.Windows.Forms.Padding(2);
            this.tbPsw.MaxLength = 30;
            this.tbPsw.Name = "tbPsw";
            this.tbPsw.PasswordChar = '*';
            this.tbPsw.Size = new System.Drawing.Size(135, 27);
            this.tbPsw.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 15F);
            this.label5.Location = new System.Drawing.Point(165, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(267, 335);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.MaxLength = 35;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(135, 27);
            this.tbEmail.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 15F);
            this.label4.Location = new System.Drawing.Point(198, 336);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "E-Mail";
            // 
            // tbCodFisc
            // 
            this.tbCodFisc.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodFisc.Location = new System.Drawing.Point(267, 302);
            this.tbCodFisc.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodFisc.MaxLength = 16;
            this.tbCodFisc.Name = "tbCodFisc";
            this.tbCodFisc.Size = new System.Drawing.Size(135, 27);
            this.tbCodFisc.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15F);
            this.label3.Location = new System.Drawing.Point(127, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Codice fsicale";
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSurname.Location = new System.Drawing.Point(267, 270);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(2);
            this.tbSurname.MaxLength = 20;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(135, 27);
            this.tbSurname.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15F);
            this.label2.Location = new System.Drawing.Point(167, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Cognome";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(267, 237);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.MaxLength = 20;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(135, 27);
            this.tbName.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15F);
            this.label1.Location = new System.Drawing.Point(199, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nome";
            // 
            // imgMan
            // 
            this.imgMan.Image = global::Progetto_PMO.Properties.Resources.man;
            this.imgMan.Location = new System.Drawing.Point(267, 81);
            this.imgMan.Margin = new System.Windows.Forms.Padding(2);
            this.imgMan.Name = "imgMan";
            this.imgMan.Size = new System.Drawing.Size(133, 130);
            this.imgMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMan.TabIndex = 38;
            this.imgMan.TabStop = false;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.Location = new System.Drawing.Point(267, 32);
            this.labelRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(142, 33);
            this.labelRegister.TabIndex = 37;
            this.labelRegister.Text = "Registrati";
            // 
            // tbCell
            // 
            this.tbCell.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCell.Location = new System.Drawing.Point(267, 400);
            this.tbCell.Margin = new System.Windows.Forms.Padding(2);
            this.tbCell.MaxLength = 10;
            this.tbCell.Name = "tbCell";
            this.tbCell.Size = new System.Drawing.Size(135, 27);
            this.tbCell.TabIndex = 56;
            // 
            // tbCom
            // 
            this.tbCom.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCom.Location = new System.Drawing.Point(267, 432);
            this.tbCom.Margin = new System.Windows.Forms.Padding(2);
            this.tbCom.MaxLength = 20;
            this.tbCom.Name = "tbCom";
            this.tbCom.Size = new System.Drawing.Size(135, 27);
            this.tbCom.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 15F);
            this.label8.Location = new System.Drawing.Point(178, 433);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 58;
            this.label8.Text = "Comune";
            // 
            // FormRegisterCivil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 614);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCom);
            this.Controls.Add(this.tbCell);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.imgTurnBack);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbStreet);
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
            this.Controls.Add(this.imgMan);
            this.Controls.Add(this.labelRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRegisterCivil";
            this.Text = "Registrazione Civile";
            ((System.ComponentModel.ISupportInitialize)(this.imgTurnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.PictureBox imgTurnBack;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbStreet;
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
        private System.Windows.Forms.PictureBox imgMan;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.TextBox tbCell;
        private System.Windows.Forms.TextBox tbCom;
        private System.Windows.Forms.Label label8;
    }
}