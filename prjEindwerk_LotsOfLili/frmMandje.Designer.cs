namespace prjEindwerk_LotsOfLili
{
    partial class frmMandje
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
            this.lsvMandje = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotaal = new System.Windows.Forms.Label();
            this.btnBetalen = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvMandje
            // 
            this.lsvMandje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.Prijs,
            this.Aantal});
            this.lsvMandje.FullRowSelect = true;
            this.lsvMandje.HideSelection = false;
            this.lsvMandje.Location = new System.Drawing.Point(39, 49);
            this.lsvMandje.Name = "lsvMandje";
            this.lsvMandje.Size = new System.Drawing.Size(308, 323);
            this.lsvMandje.TabIndex = 0;
            this.lsvMandje.UseCompatibleStateImageBehavior = false;
            this.lsvMandje.View = System.Windows.Forms.View.Details;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 190;
            // 
            // Prijs
            // 
            this.Prijs.Text = "Prijs";
            // 
            // Aantal
            // 
            this.Aantal.Text = "Aantal";
            this.Aantal.Width = 50;
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Location = new System.Drawing.Point(478, 80);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(35, 13);
            this.lblTotaal.TabIndex = 1;
            this.lblTotaal.Text = "label1";
            // 
            // btnBetalen
            // 
            this.btnBetalen.Location = new System.Drawing.Point(645, 349);
            this.btnBetalen.Name = "btnBetalen";
            this.btnBetalen.Size = new System.Drawing.Size(75, 23);
            this.btnBetalen.TabIndex = 2;
            this.btnBetalen.Text = "Betalen";
            this.btnBetalen.UseVisualStyleBackColor = true;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(481, 349);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 23);
            this.btnTerug.TabIndex = 3;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(481, 296);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(107, 23);
            this.btnVerwijder.TabIndex = 4;
            this.btnVerwijder.Text = "Verwijder item";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // frmMandje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnBetalen);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.lsvMandje);
            this.Name = "frmMandje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMandje";
            this.Load += new System.EventHandler(this.frmMandje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvMandje;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.Button btnBetalen;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.ColumnHeader Aantal;
    }
}