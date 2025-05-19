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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductToevoegen
            // 
            this.btnProductToevoegen.Location = new System.Drawing.Point(9, 242);
            this.btnProductToevoegen.Name = "btnProductToevoegen";
            this.btnProductToevoegen.Size = new System.Drawing.Size(125, 23);
            this.btnProductToevoegen.TabIndex = 0;
            this.btnProductToevoegen.Text = "Product toevoegen";
            this.btnProductToevoegen.UseVisualStyleBackColor = true;
            this.btnProductToevoegen.Click += new System.EventHandler(this.btnProductToevoegen_Click);
            // 
            // btnProductVerwijderen
            // 
            this.btnProductVerwijderen.Location = new System.Drawing.Point(142, 242);
            this.btnProductVerwijderen.Name = "btnProductVerwijderen";
            this.btnProductVerwijderen.Size = new System.Drawing.Size(125, 23);
            this.btnProductVerwijderen.TabIndex = 1;
            this.btnProductVerwijderen.Text = "Product verwijderen";
            this.btnProductVerwijderen.UseVisualStyleBackColor = true;
            this.btnProductVerwijderen.Click += new System.EventHandler(this.btnProductVerwijderen_Click);
            // 
            // lblProductNaam
            // 
            this.lblProductNaam.AutoSize = true;
            this.lblProductNaam.Location = new System.Drawing.Point(9, 133);
            this.lblProductNaam.Name = "lblProductNaam";
            this.lblProductNaam.Size = new System.Drawing.Size(116, 13);
            this.lblProductNaam.TabIndex = 2;
            this.lblProductNaam.Text = "Naam van het product:";
            // 
            // lblProductPrijs
            // 
            this.lblProductPrijs.AutoSize = true;
            this.lblProductPrijs.Location = new System.Drawing.Point(9, 168);
            this.lblProductPrijs.Name = "lblProductPrijs";
            this.lblProductPrijs.Size = new System.Drawing.Size(107, 13);
            this.lblProductPrijs.TabIndex = 2;
            this.lblProductPrijs.Text = "Prijs van het product:";
            // 
            // lblProductFoto
            // 
            this.lblProductFoto.AutoSize = true;
            this.lblProductFoto.Location = new System.Drawing.Point(9, 206);
            this.lblProductFoto.Name = "lblProductFoto";
            this.lblProductFoto.Size = new System.Drawing.Size(143, 13);
            this.lblProductFoto.TabIndex = 2;
            this.lblProductFoto.Text = "Foto kiezen van het product:";
            // 
            // rdbAgendas
            // 
            this.rdbAgendas.AutoSize = true;
            this.rdbAgendas.Location = new System.Drawing.Point(3, 3);
            this.rdbAgendas.Name = "rdbAgendas";
            this.rdbAgendas.Size = new System.Drawing.Size(62, 17);
            this.rdbAgendas.TabIndex = 3;
            this.rdbAgendas.Text = "Agenda";
            this.rdbAgendas.UseVisualStyleBackColor = true;
            // 
            // rdbHorloges
            // 
            this.rdbHorloges.AutoSize = true;
            this.rdbHorloges.Location = new System.Drawing.Point(3, 26);
            this.rdbHorloges.Name = "rdbHorloges";
            this.rdbHorloges.Size = new System.Drawing.Size(62, 17);
            this.rdbHorloges.TabIndex = 4;
            this.rdbHorloges.Text = "Horloge";
            this.rdbHorloges.UseVisualStyleBackColor = true;
            // 
            // rdbPortemonnees
            // 
            this.rdbPortemonnees.AutoSize = true;
            this.rdbPortemonnees.Location = new System.Drawing.Point(3, 49);
            this.rdbPortemonnees.Name = "rdbPortemonnees";
            this.rdbPortemonnees.Size = new System.Drawing.Size(88, 17);
            this.rdbPortemonnees.TabIndex = 5;
            this.rdbPortemonnees.Text = "Portemonnee";
            this.rdbPortemonnees.UseVisualStyleBackColor = true;
            // 
            // rdbPins
            // 
            this.rdbPins.AutoSize = true;
            this.rdbPins.Location = new System.Drawing.Point(3, 72);
            this.rdbPins.Name = "rdbPins";
            this.rdbPins.Size = new System.Drawing.Size(40, 17);
            this.rdbPins.TabIndex = 6;
            this.rdbPins.Text = "Pin";
            this.rdbPins.UseVisualStyleBackColor = true;
            // 
            // txtProductNaam
            // 
            this.txtProductNaam.Location = new System.Drawing.Point(133, 133);
            this.txtProductNaam.Name = "txtProductNaam";
            this.txtProductNaam.Size = new System.Drawing.Size(134, 20);
            this.txtProductNaam.TabIndex = 7;
            // 
            // txtProductPrijs
            // 
            this.txtProductPrijs.Location = new System.Drawing.Point(133, 168);
            this.txtProductPrijs.Name = "txtProductPrijs";
            this.txtProductPrijs.Size = new System.Drawing.Size(134, 20);
            this.txtProductPrijs.TabIndex = 8;
            // 
            // btnProductFoto
            // 
            this.btnProductFoto.Location = new System.Drawing.Point(158, 201);
            this.btnProductFoto.Name = "btnProductFoto";
            this.btnProductFoto.Size = new System.Drawing.Size(109, 23);
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 100);
            this.panel1.TabIndex = 10;
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(288, 12);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(350, 282);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 11;
            this.picFoto.TabStop = false;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 271);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(255, 23);
            this.btnTerug.TabIndex = 12;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 454);
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
    }
}