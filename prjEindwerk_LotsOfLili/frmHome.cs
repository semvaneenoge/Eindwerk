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

        int Pagina, Tab;

        public frmHome()
        {
            InitializeComponent();

            // ---Notes---
            //
            // Linksboven: Gebruiker + instellingen (WW wijzigen) + winkelmandje
            //
            // Admin: producten toevoegen/verwijderen (database), producten aanpassen (naam, prijs, foto)
            //
            // Image in databank --> ProductDA (chatgpt)
            //
            // Code beter uitwerken, pas na functionaliteit in orde is (1 panel gebruiken --> checkPage(), repeated code samensteken --> methode)
            //
            // Aantal pagina's beter uitwerken --> max aantal berekenen + tonen/aanpassen in lbl
            // --> switchen van tab op P2 is vreemd --> controle statements proberen plaatsen in checkPage of andere methode
            //
            // checkpage() --> switch statement beter uitwerken (redundant/repeated code) + proberen samenwerken met max. aantal pagina's
            //
            // Probeer process memory te verminderen
            //
            // !!! Commentaar typen bij ALLES !!!

            Pagina = 1;
            Tab = 1;

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

            lblPagina.Text = $"pagina {Pagina} / 2";

            switch (Tab)
            {
                case 1:
                    p.AgendasInvoegen();

                    switch (Pagina)
                    {
                        case 1:
                            for (int i = 0; i < 6; i++)
                            {
                                PictureBox picTest = (PictureBox)pnlProducten.Controls["picProduct" + (i + 1)];
                                Label lblTest = (Label)pnlProducten.Controls["lblProduct" + (i + 1)];

                                if (i < p.Agendas.Count)
                                {
                                    var product = p.Agendas[i];

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

                                if (i < p.Agendas.Count)
                                {
                                    var product = p.Agendas[i + 6];

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
                    break;
                case 2:
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
                    break;
                case 3:
                    p.PortemonneesInvoegen();

                    switch (Pagina)
                    {
                        case 1:
                            for (int i = 0; i < 6; i++)
                            {
                                PictureBox picTest = (PictureBox)pnlProducten.Controls["picProduct" + (i + 1)];
                                Label lblTest = (Label)pnlProducten.Controls["lblProduct" + (i + 1)];

                                if (i < p.Portemonnees.Count)
                                {
                                    var product = p.Portemonnees[i];

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

                                if (i < p.Portemonnees.Count)
                                {
                                    var product = p.Portemonnees[i + 6];

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

        private void btnAgendas_Click(object sender, EventArgs e)
        {
            Tab = 1;
            Pagina = 1;
            btnAgendas.Enabled = false;
            btnHorloges.Enabled = true;
            btnPortemonnee.Enabled = true;
            btnPins.Enabled = true;
            checkPage();
        }

        private void btnHorloges_Click(object sender, EventArgs e)
        {
            Tab = 2;
            Pagina = 1;
            btnAgendas.Enabled = true;
            btnHorloges.Enabled = false;
            btnPortemonnee.Enabled = true;
            btnPins.Enabled = true;
            checkPage();
        }

        private void btnPortemonnee_Click(object sender, EventArgs e)
        {
            Tab = 3;
            Pagina = 1;
            btnAgendas.Enabled = true;
            btnHorloges.Enabled = true;
            btnPortemonnee.Enabled = false;
            btnPins.Enabled = true;
            checkPage();
        }

        private void btnPins_Click(object sender, EventArgs e)
        {
            Tab = 4;
            Pagina = 1;
            btnAgendas.Enabled = true;
            btnHorloges.Enabled = true;
            btnPortemonnee.Enabled = true;
            btnPins.Enabled = false;
            checkPage();
        }
    }
}
