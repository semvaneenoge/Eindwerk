namespace prjEindwerk_LotsOfLili
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtWW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(137, 273);
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
            this.btnRegistratie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistratie.Location = new System.Drawing.Point(137, 355);
            this.btnRegistratie.Name = "btnRegistratie";
            this.btnRegistratie.Size = new System.Drawing.Size(200, 35);
            this.btnRegistratie.TabIndex = 0;
            this.btnRegistratie.TabStop = false;
            this.btnRegistratie.Text = "Registreren";
            this.btnRegistratie.UseVisualStyleBackColor = true;
            this.btnRegistratie.Click += new System.EventHandler(this.btnRegistratie_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Red;
            this.picLogo.Location = new System.Drawing.Point(48, 32);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(381, 148);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Location = new System.Drawing.Point(102, 209);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 26);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtWW
            // 
            this.txtWW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWW.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtWW.Location = new System.Drawing.Point(102, 241);
            this.txtWW.Name = "txtWW";
            this.txtWW.Size = new System.Drawing.Size(272, 26);
            this.txtWW.TabIndex = 3;
            this.txtWW.Text = "Wachtwoord";
            this.txtWW.TextChanged += new System.EventHandler(this.txtWW_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nog geen account gemaakt?";
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWW);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnRegistratie);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistratie;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtWW;
        private System.Windows.Forms.Label label1;
    }
}

