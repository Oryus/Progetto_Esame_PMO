﻿
namespace Progetto_PMO
{
    partial class FormCivil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCivil));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scadenza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEspandi = new System.Windows.Forms.Button();
            this.btPaga = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCognome = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imgUpdate = new System.Windows.Forms.PictureBox();
            this.imgMan = new System.Windows.Forms.PictureBox();
            this.imgTurnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.btLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTurnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_multa,
            this.Data,
            this.Scadenza,
            this.Importo,
            this.Descrizione,
            this.Stato});
            this.dataGridView1.Location = new System.Drawing.Point(80, 75);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(643, 370);
            this.dataGridView1.TabIndex = 31;
            // 
            // Id_multa
            // 
            this.Id_multa.HeaderText = "ID multa";
            this.Id_multa.MinimumWidth = 8;
            this.Id_multa.Name = "Id_multa";
            this.Id_multa.ReadOnly = true;
            this.Id_multa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id_multa.Width = 150;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 8;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 150;
            // 
            // Scadenza
            // 
            this.Scadenza.HeaderText = "Scadenza";
            this.Scadenza.MinimumWidth = 8;
            this.Scadenza.Name = "Scadenza";
            this.Scadenza.ReadOnly = true;
            this.Scadenza.Width = 150;
            // 
            // Importo
            // 
            this.Importo.HeaderText = "Importo";
            this.Importo.MinimumWidth = 8;
            this.Importo.Name = "Importo";
            this.Importo.ReadOnly = true;
            this.Importo.Width = 150;
            // 
            // Descrizione
            // 
            this.Descrizione.HeaderText = "Descrizione";
            this.Descrizione.MinimumWidth = 8;
            this.Descrizione.Name = "Descrizione";
            this.Descrizione.ReadOnly = true;
            this.Descrizione.Width = 150;
            // 
            // Stato
            // 
            this.Stato.HeaderText = "Stato pagamento";
            this.Stato.MinimumWidth = 8;
            this.Stato.Name = "Stato";
            this.Stato.ReadOnly = true;
            this.Stato.Width = 150;
            // 
            // btEspandi
            // 
            this.btEspandi.Location = new System.Drawing.Point(108, 460);
            this.btEspandi.Name = "btEspandi";
            this.btEspandi.Size = new System.Drawing.Size(105, 41);
            this.btEspandi.TabIndex = 56;
            this.btEspandi.Text = "Espandi";
            this.btEspandi.UseVisualStyleBackColor = true;
            this.btEspandi.Click += new System.EventHandler(this.btEspandi_Click);
            // 
            // btPaga
            // 
            this.btPaga.Location = new System.Drawing.Point(588, 460);
            this.btPaga.Name = "btPaga";
            this.btPaga.Size = new System.Drawing.Size(105, 41);
            this.btPaga.TabIndex = 59;
            this.btPaga.Text = "Paga";
            this.btPaga.UseVisualStyleBackColor = true;
            this.btPaga.Click += new System.EventHandler(this.btPaga_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Roboto", 15F);
            this.lbNome.Location = new System.Drawing.Point(778, 200);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(64, 24);
            this.lbNome.TabIndex = 61;
            this.lbNome.Text = "Nome";
            // 
            // lbCognome
            // 
            this.lbCognome.AutoSize = true;
            this.lbCognome.Font = new System.Drawing.Font("Roboto", 15F);
            this.lbCognome.Location = new System.Drawing.Point(876, 200);
            this.lbCognome.Name = "lbCognome";
            this.lbCognome.Size = new System.Drawing.Size(96, 24);
            this.lbCognome.TabIndex = 62;
            this.lbCognome.Text = "Cognome";
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.OrangeRed;
            this.btLogout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btLogout.Controls.Add(this.pictureBox2);
            this.btLogout.Controls.Add(this.label4);
            this.btLogout.Location = new System.Drawing.Point(772, 350);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(200, 65);
            this.btLogout.TabIndex = 64;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Progetto_PMO.Properties.Resources.log_out;
            this.pictureBox2.Location = new System.Drawing.Point(148, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 15F);
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Log out";
            // 
            // imgUpdate
            // 
            this.imgUpdate.Image = ((System.Drawing.Image)(resources.GetObject("imgUpdate.Image")));
            this.imgUpdate.Location = new System.Drawing.Point(689, 19);
            this.imgUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.imgUpdate.Name = "imgUpdate";
            this.imgUpdate.Size = new System.Drawing.Size(33, 32);
            this.imgUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUpdate.TabIndex = 65;
            this.imgUpdate.TabStop = false;
            this.imgUpdate.Click += new System.EventHandler(this.imgUpdate_Click);
            // 
            // imgMan
            // 
            this.imgMan.Image = ((System.Drawing.Image)(resources.GetObject("imgMan.Image")));
            this.imgMan.Location = new System.Drawing.Point(807, 50);
            this.imgMan.Margin = new System.Windows.Forms.Padding(2);
            this.imgMan.Name = "imgMan";
            this.imgMan.Size = new System.Drawing.Size(130, 130);
            this.imgMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMan.TabIndex = 60;
            this.imgMan.TabStop = false;
            // 
            // imgTurnBack
            // 
            this.imgTurnBack.Image = ((System.Drawing.Image)(resources.GetObject("imgTurnBack.Image")));
            this.imgTurnBack.Location = new System.Drawing.Point(26, 19);
            this.imgTurnBack.Margin = new System.Windows.Forms.Padding(2);
            this.imgTurnBack.Name = "imgTurnBack";
            this.imgTurnBack.Size = new System.Drawing.Size(33, 32);
            this.imgTurnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTurnBack.TabIndex = 55;
            this.imgTurnBack.TabStop = false;
            this.imgTurnBack.Click += new System.EventHandler(this.imgTurnBack_Click);
            // 
            // FormCivil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.imgUpdate);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.lbCognome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.imgMan);
            this.Controls.Add(this.btPaga);
            this.Controls.Add(this.btEspandi);
            this.Controls.Add(this.imgTurnBack);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCivil";
            this.Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.btLogout.ResumeLayout(false);
            this.btLogout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTurnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_multa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scadenza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stato;
        private System.Windows.Forms.PictureBox imgTurnBack;
        private System.Windows.Forms.Button btEspandi;
        private System.Windows.Forms.Button btPaga;
        private System.Windows.Forms.PictureBox imgMan;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCognome;
        private System.Windows.Forms.Panel btLogout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imgUpdate;
    }
}