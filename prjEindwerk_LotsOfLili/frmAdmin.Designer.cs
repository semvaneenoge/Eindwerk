namespace prjEindwerk_LotsOfLili
{
    partial class frmAdmin
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
            this.btnProductToevoegen = new System.Windows.Forms.Button();
            this.btnProductVerwijderen = new System.Windows.Forms.Button();
            this.lblProductNaam = new System.Windows.Forms.Label();
            this.lblProductPrijs = new System.Windows.Forms.Label();
            this.lblProductFoto = new System.Windows.Forms.Label();
            this.rdbAgendas = new System.Windows.Forms.RadioButton();
            this.rdbHorloges = new System.Windows.Forms.RadioButton();
            this.rdbPortemonnees = new System.Windows.Forms.RadioButton();
            this.rdbPins = new System.Windows.Forms.RadioButton();
            this.txtProductNaam = new System.Windows.Forms.TextBox();
            this.txtProductPrijs = new System.Windows.Forms.TextBox();
            this.btnProductFoto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbKlanten = new System.Windows.Forms.ListBox();
            this.lblKlanten = new System.Windows.Forms.Label();
            this.lsvBestellingen = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBestellingen = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lsvDetails = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductToevoegen
            // 
            this.btnProductToevoegen.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductToevoegen.Location = new System.Drawing.Point(16, 319);
            this.btnProductToevoegen.Name = "btnProductToevoegen";
            this.btnProductToevoegen.Size = new System.Drawing.Size(218, 25);
            this.btnProductToevoegen.TabIndex = 0;
            this.btnProductToevoegen.Text = "Product toevoegen";
            this.btnProductToevoegen.UseVisualStyleBackColor = true;
            this.btnProductToevoegen.Click += new System.EventHandler(this.btnProductToevoegen_Click);
            // 
            // btnProductVerwijderen
            // 
            this.btnProductVerwijderen.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductVerwijderen.Location = new System.Drawing.Point(234, 319);
            this.btnProductVerwijderen.Name = "btnProductVerwijderen";
            this.btnProductVerwijderen.Size = new System.Drawing.Size(218, 25);
            this.btnProductVerwijderen.TabIndex = 1;
            this.btnProductVerwijderen.Text = "Product verwijderen";
            this.btnProductVerwijderen.UseVisualStyleBackColor = true;
            this.btnProductVerwijderen.Click += new System.EventHandler(this.btnProductVerwijderen_Click);
            // 
            // lblProductNaam
            // 
            this.lblProductNaam.AutoSize = true;
            this.lblProductNaam.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNaam.Location = new System.Drawing.Point(13, 148);
            this.lblProductNaam.Name = "lblProductNaam";
            this.lblProductNaam.Size = new System.Drawing.Size(133, 18);
            this.lblProductNaam.TabIndex = 2;
            this.lblProductNaam.Text = "Naam van het product:";
            // 
            // lblProductPrijs
            // 
            this.lblProductPrijs.AutoSize = true;
            this.lblProductPrijs.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrijs.Location = new System.Drawing.Point(13, 207);
            this.lblProductPrijs.Name = "lblProductPrijs";
            this.lblProductPrijs.Size = new System.Drawing.Size(124, 18);
            this.lblProductPrijs.TabIndex = 2;
            this.lblProductPrijs.Text = "Prijs van het product:";
            // 
            // lblProductFoto
            // 
            this.lblProductFoto.AutoSize = true;
            this.lblProductFoto.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductFoto.Location = new System.Drawing.Point(13, 266);
            this.lblProductFoto.Name = "lblProductFoto";
            this.lblProductFoto.Size = new System.Drawing.Size(163, 18);
            this.lblProductFoto.TabIndex = 2;
            this.lblProductFoto.Text = "Foto kiezen van het product:";
            // 
            // rdbAgendas
            // 
            this.rdbAgendas.AutoSize = true;
            this.rdbAgendas.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAgendas.Location = new System.Drawing.Point(3, 3);
            this.rdbAgendas.Name = "rdbAgendas";
            this.rdbAgendas.Size = new System.Drawing.Size(67, 22);
            this.rdbAgendas.TabIndex = 3;
            this.rdbAgendas.Text = "Agenda";
            this.rdbAgendas.UseVisualStyleBackColor = true;
            // 
            // rdbHorloges
            // 
            this.rdbHorloges.AutoSize = true;
            this.rdbHorloges.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHorloges.Location = new System.Drawing.Point(3, 26);
            this.rdbHorloges.Name = "rdbHorloges";
            this.rdbHorloges.Size = new System.Drawing.Size(70, 22);
            this.rdbHorloges.TabIndex = 4;
            this.rdbHorloges.Text = "Horloge";
            this.rdbHorloges.UseVisualStyleBackColor = true;
            // 
            // rdbPortemonnees
            // 
            this.rdbPortemonnees.AutoSize = true;
            this.rdbPortemonnees.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPortemonnees.Location = new System.Drawing.Point(3, 49);
            this.rdbPortemonnees.Name = "rdbPortemonnees";
            this.rdbPortemonnees.Size = new System.Drawing.Size(100, 22);
            this.rdbPortemonnees.TabIndex = 5;
            this.rdbPortemonnees.Text = "Portemonnee";
            this.rdbPortemonnees.UseVisualStyleBackColor = true;
            // 
            // rdbPins
            // 
            this.rdbPins.AutoSize = true;
            this.rdbPins.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPins.Location = new System.Drawing.Point(3, 72);
            this.rdbPins.Name = "rdbPins";
            this.rdbPins.Size = new System.Drawing.Size(44, 22);
            this.rdbPins.TabIndex = 6;
            this.rdbPins.Text = "Pin";
            this.rdbPins.UseVisualStyleBackColor = true;
            // 
            // txtProductNaam
            // 
            this.txtProductNaam.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductNaam.Location = new System.Drawing.Point(16, 169);
            this.txtProductNaam.Name = "txtProductNaam";
            this.txtProductNaam.Size = new System.Drawing.Size(134, 22);
            this.txtProductNaam.TabIndex = 7;
            // 
            // txtProductPrijs
            // 
            this.txtProductPrijs.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrijs.Location = new System.Drawing.Point(16, 228);
            this.txtProductPrijs.Name = "txtProductPrijs";
            this.txtProductPrijs.Size = new System.Drawing.Size(134, 22);
            this.txtProductPrijs.TabIndex = 8;
            // 
            // btnProductFoto
            // 
            this.btnProductFoto.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductFoto.Location = new System.Drawing.Point(16, 287);
            this.btnProductFoto.Name = "btnProductFoto";
            this.btnProductFoto.Size = new System.Drawing.Size(109, 25);
            this.btnProductFoto.TabIndex = 9;
            this.btnProductFoto.Text = "Foto kiezen";
            this.btnProductFoto.UseVisualStyleBackColor = true;
            this.btnProductFoto.Click += new System.EventHandler(this.btnProductFoto_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbAgendas);
            this.panel1.Controls.Add(this.rdbHorloges);
            this.panel1.Controls.Add(this.rdbPortemonnees);
            this.panel1.Controls.Add(this.rdbPins);
            this.panel1.Location = new System.Drawing.Point(16, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 100);
            this.panel1.TabIndex = 10;
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(182, 43);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(270, 270);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 11;
            this.picFoto.TabStop = false;
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerug.Location = new System.Drawing.Point(19, 432);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(436, 25);
            this.btnTerug.TabIndex = 12;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product toevoegen / verwijderen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bestellingen bekijken";
            // 
            // lsbKlanten
            // 
            this.lsbKlanten.FormattingEnabled = true;
            this.lsbKlanten.Location = new System.Drawing.Point(494, 64);
            this.lsbKlanten.Name = "lsbKlanten";
            this.lsbKlanten.Size = new System.Drawing.Size(120, 277);
            this.lsbKlanten.TabIndex = 15;
            this.lsbKlanten.SelectedIndexChanged += new System.EventHandler(this.lsbKlanten_SelectedIndexChanged);
            // 
            // lblKlanten
            // 
            this.lblKlanten.AutoSize = true;
            this.lblKlanten.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlanten.Location = new System.Drawing.Point(491, 43);
            this.lblKlanten.Name = "lblKlanten";
            this.lblKlanten.Size = new System.Drawing.Size(50, 18);
            this.lblKlanten.TabIndex = 16;
            this.lblKlanten.Text = "Klanten";
            // 
            // lsvBestellingen
            // 
            this.lsvBestellingen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Datum});
            this.lsvBestellingen.FullRowSelect = true;
            this.lsvBestellingen.HideSelection = false;
            this.lsvBestellingen.Location = new System.Drawing.Point(639, 64);
            this.lsvBestellingen.Name = "lsvBestellingen";
            this.lsvBestellingen.Size = new System.Drawing.Size(159, 277);
            this.lsvBestellingen.TabIndex = 17;
            this.lsvBestellingen.UseCompatibleStateImageBehavior = false;
            this.lsvBestellingen.View = System.Windows.Forms.View.Details;
            this.lsvBestellingen.SelectedIndexChanged += new System.EventHandler(this.lsvBestellingen_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 37;
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            this.Datum.Width = 90;
            // 
            // lblBestellingen
            // 
            this.lblBestellingen.AutoSize = true;
            this.lblBestellingen.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestellingen.Location = new System.Drawing.Point(636, 43);
            this.lblBestellingen.Name = "lblBestellingen";
            this.lblBestellingen.Size = new System.Drawing.Size(71, 18);
            this.lblBestellingen.TabIndex = 18;
            this.lblBestellingen.Text = "Bestellingen";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(820, 43);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(93, 18);
            this.lblDetails.TabIndex = 20;
            this.lblDetails.Text = "bestelling details";
            // 
            // lsvDetails
            // 
            this.lsvDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.Prijs,
            this.Aantal});
            this.lsvDetails.FullRowSelect = true;
            this.lsvDetails.HideSelection = false;
            this.lsvDetails.Location = new System.Drawing.Point(823, 64);
            this.lsvDetails.Name = "lsvDetails";
            this.lsvDetails.Size = new System.Drawing.Size(271, 277);
            this.lsvDetails.TabIndex = 19;
            this.lsvDetails.UseCompatibleStateImageBehavior = false;
            this.lsvDetails.View = System.Windows.Forms.View.Details;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 170;
            // 
            // Prijs
            // 
            this.Prijs.Text = "Prijs";
            this.Prijs.Width = 43;
            // 
            // Aantal
            // 
            this.Aantal.Text = "Aantal";
            this.Aantal.Width = 53;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1106, 554);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lsvDetails);
            this.Controls.Add(this.lblBestellingen);
            this.Controls.Add(this.lsvBestellingen);
            this.Controls.Add(this.lblKlanten);
            this.Controls.Add(this.lsbKlanten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProductFoto);
            this.Controls.Add(this.txtProductPrijs);
            this.Controls.Add(this.txtProductNaam);
            this.Controls.Add(this.lblProductFoto);
            this.Controls.Add(this.lblProductPrijs);
            this.Controls.Add(this.lblProductNaam);
            this.Controls.Add(this.btnProductVerwijderen);
            this.Controls.Add(this.btnProductToevoegen);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdmin_FormClosed);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProductToevoegen;
        private System.Windows.Forms.Button btnProductVerwijderen;
        private System.Windows.Forms.Label lblProductNaam;
        private System.Windows.Forms.Label lblProductPrijs;
        private System.Windows.Forms.Label lblProductFoto;
        private System.Windows.Forms.RadioButton rdbAgendas;
        private System.Windows.Forms.RadioButton rdbHorloges;
        private System.Windows.Forms.RadioButton rdbPortemonnees;
        private System.Windows.Forms.RadioButton rdbPins;
        private System.Windows.Forms.TextBox txtProductNaam;
        private System.Windows.Forms.TextBox txtProductPrijs;
        private System.Windows.Forms.Button btnProductFoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbKlanten;
        private System.Windows.Forms.Label lblKlanten;
        private System.Windows.Forms.ListView lsvBestellingen;
        private System.Windows.Forms.Label lblBestellingen;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.ListView lsvDetails;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.ColumnHeader Aantal;
    }
}