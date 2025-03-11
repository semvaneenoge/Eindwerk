namespace prjEindwerk_LotsOfLili
{
    partial class Instellingen
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
            this.btnWWVeranderen = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.lblWW = new System.Windows.Forms.Label();
            this.lblNieuwWW = new System.Windows.Forms.Label();
            this.lblControleWW = new System.Windows.Forms.Label();
            this.txtWW = new System.Windows.Forms.TextBox();
            this.txtNieuwWW = new System.Windows.Forms.TextBox();
            this.txtControleWW = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWWVeranderen
            // 
            this.btnWWVeranderen.Location = new System.Drawing.Point(149, 112);
            this.btnWWVeranderen.Name = "btnWWVeranderen";
            this.btnWWVeranderen.Size = new System.Drawing.Size(173, 23);
            this.btnWWVeranderen.TabIndex = 1;
            this.btnWWVeranderen.Text = "Wachtwoord veranderen";
            this.btnWWVeranderen.UseVisualStyleBackColor = true;
            this.btnWWVeranderen.Visible = false;
            this.btnWWVeranderen.Click += new System.EventHandler(this.btnWWVeranderen_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(13, 112);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 23);
            this.btnTerug.TabIndex = 2;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // lblWW
            // 
            this.lblWW.AutoSize = true;
            this.lblWW.Location = new System.Drawing.Point(12, 9);
            this.lblWW.Name = "lblWW";
            this.lblWW.Size = new System.Drawing.Size(122, 13);
            this.lblWW.TabIndex = 3;
            this.lblWW.Text = "Geef uw wachtwoord in:";
            // 
            // lblNieuwWW
            // 
            this.lblNieuwWW.AutoSize = true;
            this.lblNieuwWW.Location = new System.Drawing.Point(12, 41);
            this.lblNieuwWW.Name = "lblNieuwWW";
            this.lblNieuwWW.Size = new System.Drawing.Size(153, 13);
            this.lblNieuwWW.TabIndex = 3;
            this.lblNieuwWW.Text = "Geef uw nieuw wachtwoord in:";
            this.lblNieuwWW.Visible = false;
            // 
            // lblControleWW
            // 
            this.lblControleWW.AutoSize = true;
            this.lblControleWW.Location = new System.Drawing.Point(12, 74);
            this.lblControleWW.Name = "lblControleWW";
            this.lblControleWW.Size = new System.Drawing.Size(115, 13);
            this.lblControleWW.TabIndex = 3;
            this.lblControleWW.Text = "Wachtwoord herhalen:";
            this.lblControleWW.Visible = false;
            // 
            // txtWW
            // 
            this.txtWW.Location = new System.Drawing.Point(181, 6);
            this.txtWW.Name = "txtWW";
            this.txtWW.PasswordChar = '*';
            this.txtWW.Size = new System.Drawing.Size(141, 20);
            this.txtWW.TabIndex = 4;
            // 
            // txtNieuwWW
            // 
            this.txtNieuwWW.Location = new System.Drawing.Point(181, 38);
            this.txtNieuwWW.Name = "txtNieuwWW";
            this.txtNieuwWW.PasswordChar = '*';
            this.txtNieuwWW.Size = new System.Drawing.Size(141, 20);
            this.txtNieuwWW.TabIndex = 4;
            this.txtNieuwWW.Visible = false;
            // 
            // txtControleWW
            // 
            this.txtControleWW.Location = new System.Drawing.Point(181, 71);
            this.txtControleWW.Name = "txtControleWW";
            this.txtControleWW.PasswordChar = '*';
            this.txtControleWW.Size = new System.Drawing.Size(141, 20);
            this.txtControleWW.TabIndex = 4;
            this.txtControleWW.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(247, 112);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Instellingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 147);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtControleWW);
            this.Controls.Add(this.txtNieuwWW);
            this.Controls.Add(this.txtWW);
            this.Controls.Add(this.lblControleWW);
            this.Controls.Add(this.lblNieuwWW);
            this.Controls.Add(this.lblWW);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnWWVeranderen);
            this.Name = "Instellingen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instellingen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWWVeranderen;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label lblWW;
        private System.Windows.Forms.Label lblNieuwWW;
        private System.Windows.Forms.Label lblControleWW;
        private System.Windows.Forms.TextBox txtWW;
        private System.Windows.Forms.TextBox txtNieuwWW;
        private System.Windows.Forms.TextBox txtControleWW;
        private System.Windows.Forms.Button btnOk;
    }
}