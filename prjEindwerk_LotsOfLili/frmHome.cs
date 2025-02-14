using MySql.Data;
using MySql.Data.MySqlClient;
using prjEindwerk_LotsOfLili.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEindwerk_LotsOfLili
{
    public partial class frmHome : Form
    {
        public bool isAdmin {  get; set; }
        public string Naam {  get; set; }

        public frmHome()
        {
            InitializeComponent();

            lblProduct1.Paint += lblBorder;
            lblProduct2.Paint += lblBorder;
            lblProduct3.Paint += lblBorder;
            lblProduct4.Paint += lblBorder;
            lblProduct5.Paint += lblBorder;
            lblProduct6.Paint += lblBorder;

            MySqlConnection conn = Database.MakeConnection();

            string query = "select Foto, Naam from eindwerk.tblProducten where ProductID = @ProductID";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ProductID", 1);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                byte[] fotoBytes = reader["Foto"] as byte[];
                string productNaam = reader["Naam"].ToString();

                if (fotoBytes != null)
                {
                    MemoryStream ms = new MemoryStream(fotoBytes);

                    picProduct1.Image = Image.FromStream(ms);
                    lblProduct1.Text = productNaam;
                }
                else
                {
                    MessageBox.Show("Foto is niet gevonden in de database.");
                }
            }

            // ---Notes---
            //
            // Linksboven: Gebruiker + instellingen (WW wijzigen) + winkelmandje
            //
            // Image in databank en er uit halen --> ProductDA (chatgpt)
            //
            // 1 panel proberen gebruiken voor meerder pagina's
            //
            // Test
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                btnAdmin.Visible = true;
            }

            lblGebruiker.Text = Naam;
        }

        private void lblBorder(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            ControlPaint.DrawBorder(e.Graphics, lblProduct1.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {

        }

        private void btnVorige_Click(object sender, EventArgs e)
        {

        }

        private void btnMandje_Click(object sender, EventArgs e)
        {
            frmMandje Mandje = new frmMandje();
            Mandje.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin Admin = new frmAdmin();
            Admin.Show();
        }
    }
}
