﻿namespace prjEindwerk_LotsOfLili
{
    partial class frmRegistratie
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
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefoon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtWW = new System.Windows.Forms.TextBox();
            this.txtHerhaalWW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistreer.Location = new System.Drawing.Point(170, 368);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(134, 38);
            this.btnRegistreer.TabIndex = 10;
            this.btnRegistreer.Text = "Registreer";
            this.btnRegistreer.UseVisualStyleBackColor = true;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoornaam.ForeColor = System.Drawing.Color.Gray;
            this.txtVoornaam.Location = new System.Drawing.Point(101, 116);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(272, 26);
            this.txtVoornaam.TabIndex = 1;
            this.txtVoornaam.Text = "Voornaam";
            this.txtVoornaam.Enter += new System.EventHandler(this.txtVoornaam_Enter);
            this.txtVoornaam.Leave += new System.EventHandler(this.txtVoornaam_Leave);
            // 
            // txtNaam
            // 
            this.txtNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaam.ForeColor = System.Drawing.Color.Gray;
            this.txtNaam.Location = new System.Drawing.Point(101, 148);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(272, 26);
            this.txtNaam.TabIndex = 2;
            this.txtNaam.Text = "Naam";
            this.txtNaam.Enter += new System.EventHandler(this.txtNaam_Enter);
            this.txtNaam.Leave += new System.EventHandler(this.txtNaam_Leave);
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.ForeColor = System.Drawing.Color.Gray;
            this.txtAdres.Location = new System.Drawing.Point(101, 180);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(272, 26);
            this.txtAdres.TabIndex = 3;
            this.txtAdres.Text = "Adres";
            this.txtAdres.Enter += new System.EventHandler(this.txtAdres_Enter);
            this.txtAdres.Leave += new System.EventHandler(this.txtAdres_Leave);
            // 
            // txtTelefoon
            // 
            this.txtTelefoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoon.ForeColor = System.Drawing.Color.Gray;
            this.txtTelefoon.Location = new System.Drawing.Point(101, 212);
            this.txtTelefoon.Name = "txtTelefoon";
            this.txtTelefoon.Size = new System.Drawing.Size(272, 26);
            this.txtTelefoon.TabIndex = 4;
            this.txtTelefoon.Text = "Telefoon";
            this.txtTelefoon.Enter += new System.EventHandler(this.txtTelefoon_Enter);
            this.txtTelefoon.Leave += new System.EventHandler(this.txtTelefoon_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(101, 244);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 26);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "Email";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtWW
            // 
            this.txtWW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWW.ForeColor = System.Drawing.Color.Gray;
            this.txtWW.Location = new System.Drawing.Point(101, 276);
            this.txtWW.Name = "txtWW";
            this.txtWW.Size = new System.Drawing.Size(272, 26);
            this.txtWW.TabIndex = 6;
            this.txtWW.Text = "Wachtwoord";
            this.txtWW.Enter += new System.EventHandler(this.txtWW_Enter);
            this.txtWW.Leave += new System.EventHandler(this.txtWW_Leave);
            // 
            // txtHerhaalWW
            // 
            this.txtHerhaalWW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHerhaalWW.ForeColor = System.Drawing.Color.Gray;
            this.txtHerhaalWW.Location = new System.Drawing.Point(101, 308);
            this.txtHerhaalWW.Name = "txtHerhaalWW";
            this.txtHerhaalWW.Size = new System.Drawing.Size(272, 26);
            this.txtHerhaalWW.TabIndex = 7;
            this.txtHerhaalWW.Text = "Wachtwoord herhalen";
            this.txtHerhaalWW.Enter += new System.EventHandler(this.txtHerhaalWW_Enter);
            this.txtHerhaalWW.Leave += new System.EventHandler(this.txtHerhaalWW_Leave);
            // 
            // frmRegistratie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 421);
            this.Controls.Add(this.txtHerhaalWW);
            this.Controls.Add(this.txtWW);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefoon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.btnRegistreer);
            this.Name = "frmRegistratie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistratie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefoon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtWW;
        private System.Windows.Forms.TextBox txtHerhaalWW;
    }
}