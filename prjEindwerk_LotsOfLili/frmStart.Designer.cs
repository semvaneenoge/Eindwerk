﻿namespace prjEindwerk_LotsOfLili
{
    partial class frmStart
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistratie = new System.Windows.Forms.Button();
            this.picLogo1 = new System.Windows.Forms.PictureBox();
            this.txtEmailInlog = new System.Windows.Forms.TextBox();
            this.txtWWInlog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.grbRegistreer = new System.Windows.Forms.GroupBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.picLogo2 = new System.Windows.Forms.PictureBox();
            this.txtHerhaalWW = new System.Windows.Forms.TextBox();
            this.txtWWRegistreer = new System.Windows.Forms.TextBox();
            this.txtEmailRegistreer = new System.Windows.Forms.TextBox();
            this.txtTelefoon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
            this.grbLogin.SuspendLayout();
            this.grbRegistreer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(136, 260);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 35);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Inloggen";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistratie
            // 
            this.btnRegistratie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistratie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistratie.Location = new System.Drawing.Point(136, 342);
            this.btnRegistratie.Name = "btnRegistratie";
            this.btnRegistratie.Size = new System.Drawing.Size(200, 35);
            this.btnRegistratie.TabIndex = 0;
            this.btnRegistratie.TabStop = false;
            this.btnRegistratie.Text = "Registreren";
            this.btnRegistratie.UseVisualStyleBackColor = true;
            this.btnRegistratie.Click += new System.EventHandler(this.btnRegistratie_Click);
            // 
            // picLogo1
            // 
            this.picLogo1.BackColor = System.Drawing.SystemColors.Control;
            this.picLogo1.Image = global::prjEindwerk_LotsOfLili.Properties.Resources.logo___Lots_of_Lili;
            this.picLogo1.Location = new System.Drawing.Point(57, 51);
            this.picLogo1.Name = "picLogo1";
            this.picLogo1.Size = new System.Drawing.Size(360, 95);
            this.picLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo1.TabIndex = 1;
            this.picLogo1.TabStop = false;
            // 
            // txtEmailInlog
            // 
            this.txtEmailInlog.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailInlog.ForeColor = System.Drawing.Color.Gray;
            this.txtEmailInlog.Location = new System.Drawing.Point(101, 196);
            this.txtEmailInlog.Name = "txtEmailInlog";
            this.txtEmailInlog.Size = new System.Drawing.Size(272, 29);
            this.txtEmailInlog.TabIndex = 1;
            this.txtEmailInlog.TabStop = false;
            this.txtEmailInlog.Text = "Email";
            // 
            // txtWWInlog
            // 
            this.txtWWInlog.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWWInlog.ForeColor = System.Drawing.Color.Gray;
            this.txtWWInlog.Location = new System.Drawing.Point(101, 228);
            this.txtWWInlog.Name = "txtWWInlog";
            this.txtWWInlog.Size = new System.Drawing.Size(272, 29);
            this.txtWWInlog.TabIndex = 2;
            this.txtWWInlog.TabStop = false;
            this.txtWWInlog.Text = "Wachtwoord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nog geen account gemaakt?";
            // 
            // grbLogin
            // 
            this.grbLogin.BackColor = System.Drawing.Color.White;
            this.grbLogin.Controls.Add(this.grbRegistreer);
            this.grbLogin.Controls.Add(this.label1);
            this.grbLogin.Controls.Add(this.picLogo1);
            this.grbLogin.Controls.Add(this.txtWWInlog);
            this.grbLogin.Controls.Add(this.btnLogin);
            this.grbLogin.Controls.Add(this.txtEmailInlog);
            this.grbLogin.Controls.Add(this.btnRegistratie);
            this.grbLogin.Controls.Add(this.label2);
            this.grbLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbLogin.Location = new System.Drawing.Point(0, -6);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(475, 465);
            this.grbLogin.TabIndex = 5;
            this.grbLogin.TabStop = false;
            // 
            // grbRegistreer
            // 
            this.grbRegistreer.BackColor = System.Drawing.Color.White;
            this.grbRegistreer.Controls.Add(this.txtPostcode);
            this.grbRegistreer.Controls.Add(this.btnTerug);
            this.grbRegistreer.Controls.Add(this.picLogo2);
            this.grbRegistreer.Controls.Add(this.txtHerhaalWW);
            this.grbRegistreer.Controls.Add(this.txtWWRegistreer);
            this.grbRegistreer.Controls.Add(this.txtEmailRegistreer);
            this.grbRegistreer.Controls.Add(this.txtTelefoon);
            this.grbRegistreer.Controls.Add(this.txtAdres);
            this.grbRegistreer.Controls.Add(this.txtNaam);
            this.grbRegistreer.Controls.Add(this.txtVoornaam);
            this.grbRegistreer.Controls.Add(this.btnRegistreer);
            this.grbRegistreer.Location = new System.Drawing.Point(0, 0);
            this.grbRegistreer.Name = "grbRegistreer";
            this.grbRegistreer.Size = new System.Drawing.Size(475, 463);
            this.grbRegistreer.TabIndex = 5;
            this.grbRegistreer.TabStop = false;
            this.grbRegistreer.Visible = false;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.ForeColor = System.Drawing.Color.Gray;
            this.txtPostcode.Location = new System.Drawing.Point(101, 209);
            this.txtPostcode.MaxLength = 4;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(270, 29);
            this.txtPostcode.TabIndex = 6;
            this.txtPostcode.TabStop = false;
            this.txtPostcode.Text = "Postcode";
            // 
            // btnTerug
            // 
            this.btnTerug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerug.Location = new System.Drawing.Point(169, 415);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(134, 30);
            this.btnTerug.TabIndex = 21;
            this.btnTerug.TabStop = false;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // picLogo2
            // 
            this.picLogo2.Image = global::prjEindwerk_LotsOfLili.Properties.Resources.logo___Lots_of_Lili;
            this.picLogo2.Location = new System.Drawing.Point(56, 9);
            this.picLogo2.Name = "picLogo2";
            this.picLogo2.Size = new System.Drawing.Size(360, 95);
            this.picLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo2.TabIndex = 20;
            this.picLogo2.TabStop = false;
            // 
            // txtHerhaalWW
            // 
            this.txtHerhaalWW.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHerhaalWW.ForeColor = System.Drawing.Color.Gray;
            this.txtHerhaalWW.Location = new System.Drawing.Point(101, 337);
            this.txtHerhaalWW.MaxLength = 100;
            this.txtHerhaalWW.Name = "txtHerhaalWW";
            this.txtHerhaalWW.Size = new System.Drawing.Size(270, 29);
            this.txtHerhaalWW.TabIndex = 10;
            this.txtHerhaalWW.TabStop = false;
            this.txtHerhaalWW.Text = "Wachtwoord herhalen";
            // 
            // txtWWRegistreer
            // 
            this.txtWWRegistreer.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWWRegistreer.ForeColor = System.Drawing.Color.Gray;
            this.txtWWRegistreer.Location = new System.Drawing.Point(101, 305);
            this.txtWWRegistreer.MaxLength = 100;
            this.txtWWRegistreer.Name = "txtWWRegistreer";
            this.txtWWRegistreer.Size = new System.Drawing.Size(270, 29);
            this.txtWWRegistreer.TabIndex = 9;
            this.txtWWRegistreer.TabStop = false;
            this.txtWWRegistreer.Text = "Wachtwoord";
            // 
            // txtEmailRegistreer
            // 
            this.txtEmailRegistreer.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailRegistreer.ForeColor = System.Drawing.Color.Gray;
            this.txtEmailRegistreer.Location = new System.Drawing.Point(101, 273);
            this.txtEmailRegistreer.MaxLength = 100;
            this.txtEmailRegistreer.Name = "txtEmailRegistreer";
            this.txtEmailRegistreer.Size = new System.Drawing.Size(270, 29);
            this.txtEmailRegistreer.TabIndex = 8;
            this.txtEmailRegistreer.TabStop = false;
            this.txtEmailRegistreer.Text = "Email";
            // 
            // txtTelefoon
            // 
            this.txtTelefoon.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoon.ForeColor = System.Drawing.Color.Gray;
            this.txtTelefoon.Location = new System.Drawing.Point(101, 241);
            this.txtTelefoon.MaxLength = 30;
            this.txtTelefoon.Name = "txtTelefoon";
            this.txtTelefoon.Size = new System.Drawing.Size(270, 29);
            this.txtTelefoon.TabIndex = 7;
            this.txtTelefoon.TabStop = false;
            this.txtTelefoon.Text = "Telefoon";
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.ForeColor = System.Drawing.Color.Gray;
            this.txtAdres.Location = new System.Drawing.Point(101, 177);
            this.txtAdres.MaxLength = 150;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(270, 29);
            this.txtAdres.TabIndex = 5;
            this.txtAdres.TabStop = false;
            this.txtAdres.Text = "Straat + nr";
            // 
            // txtNaam
            // 
            this.txtNaam.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaam.ForeColor = System.Drawing.Color.Gray;
            this.txtNaam.Location = new System.Drawing.Point(101, 145);
            this.txtNaam.MaxLength = 50;
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(270, 29);
            this.txtNaam.TabIndex = 4;
            this.txtNaam.TabStop = false;
            this.txtNaam.Text = "Naam";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoornaam.ForeColor = System.Drawing.Color.Gray;
            this.txtVoornaam.Location = new System.Drawing.Point(101, 113);
            this.txtVoornaam.MaxLength = 50;
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(270, 29);
            this.txtVoornaam.TabIndex = 3;
            this.txtVoornaam.TabStop = false;
            this.txtVoornaam.Text = "Voornaam";
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistreer.Location = new System.Drawing.Point(169, 374);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(134, 35);
            this.btnRegistreer.TabIndex = 19;
            this.btnRegistreer.TabStop = false;
            this.btnRegistreer.Text = "Registreer";
            this.btnRegistreer.UseVisualStyleBackColor = true;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(153)))), ((int)(((byte)(141)))));
            this.label2.Location = new System.Drawing.Point(51, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cadeaus met stijl: agenda’s, horloges, portemonnees en pins";
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 421);
            this.Controls.Add(this.grbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            this.grbRegistreer.ResumeLayout(false);
            this.grbRegistreer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistratie;
        private System.Windows.Forms.PictureBox picLogo1;
        private System.Windows.Forms.TextBox txtEmailInlog;
        private System.Windows.Forms.TextBox txtWWInlog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbLogin;
        private System.Windows.Forms.GroupBox grbRegistreer;
        private System.Windows.Forms.PictureBox picLogo2;
        private System.Windows.Forms.TextBox txtHerhaalWW;
        private System.Windows.Forms.TextBox txtWWRegistreer;
        private System.Windows.Forms.TextBox txtEmailRegistreer;
        private System.Windows.Forms.TextBox txtTelefoon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label label2;
    }
}

