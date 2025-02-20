using MySql.Data;
using MySql.Data.MySqlClient;
using prjEindwerk_LotsOfLili.DA;
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

            // ---Notes---
            //
            // Linksboven: Gebruiker + instellingen (WW wijzigen) + winkelmandje
            //
            // Image in databank en er uit halen --> ProductDA (chatgpt)
            //
            // !!!1 panel proberen gebruiken voor meerder pagina's !!!

            lblProduct1.Paint += lblBorder;
            lblProduct2.Paint += lblBorder;
            lblProduct3.Paint += lblBorder;
            lblProduct4.Paint += lblBorder;
            lblProduct5.Paint += lblBorder;
            lblProduct6.Paint += lblBorder;

            ProductDA p = new ProductDA();
            p.HorlogesInvoegen();

            for (int i = 0; i < 6; i++)
            {
                PictureBox picTest = (PictureBox)pnlProducten.Controls["picProduct" + (i + 1)];
                Label lblTest = (Label)pnlProducten.Controls["lblProduct" + (i + 1)];

                if (i < p.Horloges.Count)
                {
                    var product = p.Horloges[i];

                    if (picTest != null)
                    {
                        picTest.Image = product.Foto;
                    }
                    if (lblTest != null)
                    {
                        lblTest.Text = product.Naam;
                    }
                }
                else
                {
                    if (picTest != null)
                    {
                        picTest.Image = null;
                    }
                    if (lblTest != null)
                    {
                        lblTest.Text = "Geen product gevonden";
                    }
                }
            }
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
