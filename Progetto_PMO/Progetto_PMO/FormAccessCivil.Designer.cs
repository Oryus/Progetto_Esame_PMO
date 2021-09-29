
namespace Progetto_PMO
{
    partial class FormAccessCivil
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
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.btEnter = new System.Windows.Forms.Button();
            this.tbPsw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodFisc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAccess = new System.Windows.Forms.Label();
            this.imgTurnBack = new System.Windows.Forms.PictureBox();
            this.imgMan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTurnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMan)).BeginInit();
            this.SuspendLayout();
            // 
            // linkRegister
            // 
            this.linkRegister.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.linkRegister.AutoSize = true;
            this.linkRegister.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegister.LinkColor = System.Drawing.Color.Black;
            this.linkRegister.Location = new System.Drawing.Point(263, 430);
            this.linkRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(139, 13);
            this.linkRegister.TabIndex = 30;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Non sei ancora registrato?";
            this.linkRegister.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(267, 367);
            this.btEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(133, 43);
            this.btEnter.TabIndex = 29;
            this.btEnter.Text = "Entra";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // tbPsw
            // 
            this.tbPsw.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPsw.Location = new System.Drawing.Point(266, 309);
            this.tbPsw.Margin = new System.Windows.Forms.Padding(2);
            this.tbPsw.MaxLength = 30;
            this.tbPsw.Name = "tbPsw";
            this.tbPsw.PasswordChar = '*';
            this.tbPsw.Size = new System.Drawing.Size(135, 27);
            this.tbPsw.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 15F);
            this.label5.Location = new System.Drawing.Point(164, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(266, 276);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.MaxLength = 35;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(135, 27);
            this.tbEmail.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 15F);
            this.label4.Location = new System.Drawing.Point(197, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "E-Mail";
            // 
            // tbCodFisc
            // 
            this.tbCodFisc.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodFisc.Location = new System.Drawing.Point(267, 244);
            this.tbCodFisc.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodFisc.MaxLength = 16;
            this.tbCodFisc.Name = "tbCodFisc";
            this.tbCodFisc.Size = new System.Drawing.Size(135, 27);
            this.tbCodFisc.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15F);
            this.label3.Location = new System.Drawing.Point(127, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Codice fiscale";
            // 
            // labelAccess
            // 
            this.labelAccess.AutoSize = true;
            this.labelAccess.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccess.Location = new System.Drawing.Point(287, 32);
            this.labelAccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAccess.Name = "labelAccess";
            this.labelAccess.Size = new System.Drawing.Size(103, 33);
            this.labelAccess.TabIndex = 21;
            this.labelAccess.Text = "Accedi";
            // 
            // imgTurnBack
            // 
            this.imgTurnBack.Image = global::Progetto_PMO.Properties.Resources.left_arrow;
            this.imgTurnBack.Location = new System.Drawing.Point(27, 19);
            this.imgTurnBack.Margin = new System.Windows.Forms.Padding(2);
            this.imgTurnBack.Name = "imgTurnBack";
            this.imgTurnBack.Size = new System.Drawing.Size(33, 32);
            this.imgTurnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTurnBack.TabIndex = 31;
            this.imgTurnBack.TabStop = false;
            this.imgTurnBack.Click += new System.EventHandler(this.imgTurnBack_Click);
            // 
            // imgMan
            // 
            this.imgMan.Image = global::Progetto_PMO.Properties.Resources.man;
            this.imgMan.Location = new System.Drawing.Point(267, 81);
            this.imgMan.Margin = new System.Windows.Forms.Padding(2);
            this.imgMan.Name = "imgMan";
            this.imgMan.Size = new System.Drawing.Size(130, 130);
            this.imgMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMan.TabIndex = 22;
            this.imgMan.TabStop = false;
            // 
            // FormAccessCivil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 484);
            this.Controls.Add(this.imgTurnBack);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.tbPsw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCodFisc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imgMan);
            this.Controls.Add(this.labelAccess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAccessCivil";
            this.Text = "Accesso Civile";
            ((System.ComponentModel.ISupportInitialize)(this.imgTurnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgTurnBack;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.TextBox tbPsw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodFisc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgMan;
        private System.Windows.Forms.Label labelAccess;
    }
}