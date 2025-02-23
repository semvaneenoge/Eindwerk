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

        int Pagina;

        public frmHome()
        {
            InitializeComponent();

            // ---Notes---
            //
            // Linksboven: Gebruiker + instellingen (WW wijzigen) + winkelmandje
            //
            // Image in databank en er uit halen --> ProductDA (chatgpt)
            //
            // !!!1 panel proberen gebruiken voor meerder pagina's !!! --> verder proberen niet gelukt met code van nu !!!

            Pagina = 1;

            lblProduct1.Paint += lblBorder;
            lblProduct2.Paint += lblBorder;
            lblProduct3.Paint += lblBorder;
            lblProduct4.Paint += lblBorder;
            lblProduct5.Paint += lblBorder;
            lblProduct6.Paint += lblBorder;

            checkPage();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                btnAdmin.Visible = true;
            }

            lblGebruiker.Text = Naam;
        }

        private void checkPage()
        {
            ProductDA p = new ProductDA();
            p.HorlogesInvoegen();

            switch (Pagina)
            {
                case 1:
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
                                lblTest.Text = $"{product.Naam}\n{product.Prijs}";
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
                    break;
                case 2:
                    for (int i = 0; i < 6; i++)
                    {
                        PictureBox picTest = (PictureBox)pnlProducten.Controls["picProduct" + (i + 1)];
                        Label lblTest = (Label)pnlProducten.Controls["lblProduct" + (i + 1)];

                        if (i < p.Horloges.Count)
                        {
                            var product = p.Horloges[i + 6];

                            if (picTest != null)
                            {
                                picTest.Image = product.Foto;
                            }
                            if (lblTest != null)
                            {
                                lblTest.Text = $"{product.Naam}\n{product.Prijs}";
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
                    break;

            }
        }

        private void lblBorder(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            ControlPaint.DrawBorder(e.Graphics, lblProduct1.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void btnVorige_Click(object sender, EventArgs e)
        {
            if (Pagina > 1)
            {
                Pagina--;
                lblPagina.Text = $"pagina {Pagina} / 2";
            }
            if (Pagina <= 1)
            {
                btnVolgende.Enabled = true;
            }
            if (Pagina == 1)
            {
                btnVorige.Enabled = false;
            }

            checkPage();
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            if (Pagina <= 1)
            {
                Pagina++;
                lblPagina.Text = $"pagina {Pagina} / 2";
            }
            if (Pagina > 1)
            {
                btnVorige.Enabled = true;
            }
            if (Pagina == 1 || Pagina == 2) // veranderen naar max. aantal pagina's
            {
                btnVolgende.Enabled = false;
            }

            checkPage();
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
