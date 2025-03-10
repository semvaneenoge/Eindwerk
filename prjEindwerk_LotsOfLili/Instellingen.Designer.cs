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
            this.SuspendLayout();
            // 
            // btnWWVeranderen
            // 
            this.btnWWVeranderen.Location = new System.Drawing.Point(12, 12);
            this.btnWWVeranderen.Name = "btnWWVeranderen";
            this.btnWWVeranderen.Size = new System.Drawing.Size(173, 23);
            this.btnWWVeranderen.TabIndex = 1;
            this.btnWWVeranderen.Text = "Wachtwoord veranderen";
            this.btnWWVeranderen.UseVisualStyleBackColor = true;
            this.btnWWVeranderen.Click += new System.EventHandler(this.btnWWVeranderen_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 75);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 23);
            this.btnTerug.TabIndex = 2;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // Instellingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(303, 110);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnWWVeranderen);
            this.Name = "Instellingen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instellingen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWWVeranderen;
        private System.Windows.Forms.Button btnTerug;
    }
}