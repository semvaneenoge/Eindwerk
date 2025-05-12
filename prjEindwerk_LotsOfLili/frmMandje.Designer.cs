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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnVerwijderAlleGeselecteerd = new System.Windows.Forms.Button();
            this.btnVerwijderAlles = new System.Windows.Forms.Button();
            this.lblTotPrijs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvMandje
            // 
            this.lsvMandje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.Prijs,
            this.Aantal});
            this.lsvMandje.FullRowSelect = true;
            this.lsvMandje.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvMandje.HideSelection = false;
            this.lsvMandje.Location = new System.Drawing.Point(12, 12);
            this.lsvMandje.MultiSelect = false;
            this.lsvMandje.Name = "lsvMandje";
            this.lsvMandje.Size = new System.Drawing.Size(320, 244);
            this.lsvMandje.TabIndex = 0;
            this.lsvMandje.UseCompatibleStateImageBehavior = false;
            this.lsvMandje.View = System.Windows.Forms.View.Details;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 180;
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
            this.lblTotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaal.Location = new System.Drawing.Point(342, 106);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(144, 20);
            this.lblTotaal.TabIndex = 1;
            this.lblTotaal.Text = "De totale prijs is:";
            // 
            // btnBetalen
            // 
            this.btnBetalen.Location = new System.Drawing.Point(342, 180);
            this.btnBetalen.Name = "btnBetalen";
            this.btnBetalen.Size = new System.Drawing.Size(250, 35);
            this.btnBetalen.TabIndex = 2;
            this.btnBetalen.Text = "Betalen";
            this.btnBetalen.UseVisualStyleBackColor = true;
            this.btnBetalen.Click += new System.EventHandler(this.btnBetalen_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(342, 221);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(250, 35);
            this.btnTerug.TabIndex = 3;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerwijder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijder.Location = new System.Drawing.Point(12, 262);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(150, 25);
            this.btnVerwijder.TabIndex = 4;
            this.btnVerwijder.Text = "Verwijder product";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::prjEindwerk_LotsOfLili.Properties.Resources.logo___Lots_of_Lili;
            this.picLogo.Location = new System.Drawing.Point(343, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(250, 79);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // btnVerwijderAlleGeselecteerd
            // 
            this.btnVerwijderAlleGeselecteerd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerwijderAlleGeselecteerd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderAlleGeselecteerd.Location = new System.Drawing.Point(168, 262);
            this.btnVerwijderAlleGeselecteerd.Name = "btnVerwijderAlleGeselecteerd";
            this.btnVerwijderAlleGeselecteerd.Size = new System.Drawing.Size(268, 25);
            this.btnVerwijderAlleGeselecteerd.TabIndex = 6;
            this.btnVerwijderAlleGeselecteerd.Text = "Verwijder alle geselecteerde producten";
            this.btnVerwijderAlleGeselecteerd.UseVisualStyleBackColor = true;
            this.btnVerwijderAlleGeselecteerd.Click += new System.EventHandler(this.btnVerwijderAlleGeselecteerd_Click);
            // 
            // btnVerwijderAlles
            // 
            this.btnVerwijderAlles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerwijderAlles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderAlles.Location = new System.Drawing.Point(442, 262);
            this.btnVerwijderAlles.Name = "btnVerwijderAlles";
            this.btnVerwijderAlles.Size = new System.Drawing.Size(150, 25);
            this.btnVerwijderAlles.TabIndex = 7;
            this.btnVerwijderAlles.Text = "Verwijder all producten";
            this.btnVerwijderAlles.UseVisualStyleBackColor = true;
            this.btnVerwijderAlles.Click += new System.EventHandler(this.btnVerwijderAlles_Click);
            // 
            // lblTotPrijs
            // 
            this.lblTotPrijs.AutoSize = true;
            this.lblTotPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotPrijs.Location = new System.Drawing.Point(342, 140);
            this.lblTotPrijs.Name = "lblTotPrijs";
            this.lblTotPrijs.Size = new System.Drawing.Size(43, 20);
            this.lblTotPrijs.TabIndex = 8;
            this.lblTotPrijs.Text = "Prijs";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(343, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 1);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // frmMandje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotPrijs);
            this.Controls.Add(this.btnVerwijderAlles);
            this.Controls.Add(this.btnVerwijderAlleGeselecteerd);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnBetalen);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.lsvMandje);
            this.Name = "frmMandje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMandje";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMandje_FormClosed);
            this.Load += new System.EventHandler(this.frmMandje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
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
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnVerwijderAlleGeselecteerd;
        private System.Windows.Forms.Button btnVerwijderAlles;
        private System.Windows.Forms.Label lblTotPrijs;
        private System.Windows.Forms.Label label1;
    }
}