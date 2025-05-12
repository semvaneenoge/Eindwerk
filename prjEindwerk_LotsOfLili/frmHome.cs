using Google.Protobuf.WellKnownTypes;
using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Session;
using prjEindwerk_LotsOfLili.DA;
using prjEindwerk_LotsOfLili.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEindwerk_LotsOfLili
{
    public partial class frmHome : Form
    {
        public bool isAdmin { get; set; }
        public string customerNameHome { get; set; }
        public string userEmail { get; set; }

        public List<Cart> Cart = new List<Cart>();

        int Page, Tab, previousTab, maxPages;

        public frmHome()
        {
            InitializeComponent();

            // --- notes ---

            ProductDA p = new ProductDA();

            // Standaardweergave
            Tab = 1;

            // Labels een border geven
            for (int i = 0; i < 6; i++)
            {
                pnlProducten.Controls["lblProduct" + (i + 1)].Paint += lblBorder;
            }

            checkPage();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            // Controle op admin
            if (isAdmin)
            {
                // Knop tonen
                btnAdmin.Visible = true;
            }

            // Naam tonen
            lblGebruiker.Text = customerNameHome;

            TotaalProducten();
        }

        private void lblBorder(object sender, PaintEventArgs e)
        {
            //Labels een border geven
            Label lbl = sender as Label;

            ControlPaint.DrawBorder(e.Graphics, lblProduct1.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void checkPage()
        {
            ProductDA p = new ProductDA();

            // Max. aantal producten per pagina
            int maxProducts = 6;
            // Standaardweergave producten
            var ProductsList = p.Agendas;

            // Controle of Tab veranderd --> Pagina resetten
            if (Tab != previousTab)
            {
                Page = 0;
            }

            // Tab opslaan
            previousTab = Tab;

            // List en aantal pagina's ophalen aan de hand van geselecteerd Tab
            switch (Tab)
            {
                case 1:
                    // List Agendas ophalen en pagina's instellen
                    p.AgendasInvoegen();
                    ProductsList = p.Agendas;
                    maxPages = ProductsList.Count / maxProducts;
                    break;
                case 2:
                    // List Horloges ophalen en pagina's instellen
                    p.HorlogesInvoegen();
                    ProductsList = p.Horloges;
                    maxPages = ProductsList.Count / maxProducts;
                    break;
                case 3:
                    // List Portemonnees ophalen en pagina's instellen
                    p.PortemonneesInvoegen();
                    ProductsList = p.Portemonnees;
                    maxPages = ProductsList.Count / maxProducts;
                    break;
                case 4:
                    // List Pins ophalen en pagina's instellen
                    p.PinsInvoegen();
                    ProductsList = p.Pins;
                    maxPages = ProductsList.Count / maxProducts;
                    break;
            }

            // Producten invullen in panel
            for (int i = 0; i < maxProducts; i++)
            {
                // Picturebox en Label krijgen voor het product van de huidige pagina
                PictureBox picProduct = (PictureBox)pnlProducten.Controls["picProduct" + (i + 1)];
                Label lblProduct = (Label)pnlProducten.Controls["lblProduct" + (i + 1)];

                // Controle op meer producten
                if (i < ProductsList.Count)
                {
                    // Product ophalen op basis van pagina
                    var product = ProductsList[i + (maxProducts * Page)];

                    // Gegevens invullen in Picturebox en Label
                    if (picProduct != null)
                    {
                        picProduct.Image = product.Foto;
                    }
                    if (lblProduct != null)
                    {

                        lblProduct.Text = $"{product.Naam}\n € {product.Prijs}";
                    }

                    // Controle op lege slot
                    // Niets tonen in geval van geen product (leeg slot)
                    if (lblProduct.Text.Contains("Empty slot"))
                    {
                        pnlProducten.Controls["picProduct" + (i + 1)].Visible = false;
                        pnlProducten.Controls["lblProduct" + (i + 1)].Visible = false;
                        pnlProducten.Controls["btnMandje" + (i + 1)].Visible = false;
                    }
                    else
                    {
                        pnlProducten.Controls["picProduct" + (i + 1)].Visible = true;
                        pnlProducten.Controls["lblProduct" + (i + 1)].Visible = true;
                        pnlProducten.Controls["btnMandje" + (i + 1)].Visible = true;
                    }
                }
            }

            // Pagina knoppen aan/uit zetten aan de hand van huidige pagina
            btnVorige.Enabled = Page > 0;
            btnVolgende.Enabled = Page < maxPages - 1;

            // Huidige pagina tonen
            lblPagina.Text = $"pagina {Page + 1} / {maxPages}";
        }

        private void btnVorige_Click(object sender, EventArgs e)
        {
            // Pagina terug gaan --> waarde verminderen
            Page--;
            checkPage();
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            // Pagina verder gaan --> waarde vermeerderen
            Page++;
            checkPage();
        }

        private void btnMandje_Click(object sender, EventArgs e)
        {
            // Winkelmandje openen
            frmMandje Mandje = new frmMandje();
            Mandje.Cart = Cart;
            Mandje.customerName = customerNameHome;
            Mandje.userEmail = userEmail;
            Mandje.isAdmin = isAdmin;
            Mandje.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Admin menu openen
            frmAdmin Admin = new frmAdmin();
            Admin.Cart = Cart;
            Admin.customerName = customerNameHome;
            Admin.userEmail = userEmail;
            Admin.isAdmin = isAdmin;
            Admin.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Instellingen instellingen = new Instellingen();
            instellingen.customerName = customerNameHome;
            instellingen.userEmail = userEmail;
            instellingen.Cart = Cart;
            instellingen.isAdmin = isAdmin;
            instellingen.Show();
            this.Hide();
        }

        private void btnAfmelden_Click(object sender, EventArgs e)
        {
            frmStart start = new frmStart();
            start.Show();
            this.Close();
        }

        private void UpdateButton(int tab, System.Windows.Forms.Button selectedButton)
        {
            // Knoppen van Tabs updaten --> aan/uit zetten en kleur veranderen
            Tab = tab;

            btnAgendas.BackColor = Color.White;
            btnHorloges.BackColor = Color.White;
            btnPortemonnee.BackColor = Color.White;
            btnPins.BackColor = Color.White;

            btnAgendas.Enabled = true;
            btnHorloges.Enabled = true;
            btnPortemonnee.Enabled = true;
            btnPins.Enabled = true;

            selectedButton.BackColor = Color.FromArgb(243, 207, 195);
            selectedButton.Enabled = false;

            checkPage();
        }

        private void btnAgendas_Click(object sender, EventArgs e)
        {
            // Knop en waarde doorgeven
            UpdateButton(1, btnAgendas);
        }

        private void btnHorloges_Click(object sender, EventArgs e)
        {
            // Knop en waarde doorgeven
            UpdateButton(2, btnHorloges);
        }

        private void btnPortemonnee_Click(object sender, EventArgs e)
        {
            // Knop en waarde doorgeven
            UpdateButton(3, btnPortemonnee);
        }

        private void btnPins_Click(object sender, EventArgs e)
        {
            // Knop en waarde doorgeven
            UpdateButton(4, btnPins);
        }

        private void AddToCart(int id)
        {
            // Juiste Label gebruiken aan de hand van id
            Label lblProduct = (Label)pnlProducten.Controls["lblProduct" + id];

            // Tekstwaarde opvangen van Label
            string productText = lblProduct.Text;

            // String splitsen
            string[] productParts = productText.Split('€');

            // Prijs van product omzetten naar een double
            if (double.TryParse(productParts[1], out double prijs))
            {
                // Naam van product opvangen
                string naam = productParts[0].Trim();

                bool isFound = false;

                // Producten in Cart doorlopen
                foreach (var item in Cart)
                {
                    // Controle of product al in mandje zit
                    if (item.Naam == naam)
                    {
                        item.Aantal++;
                        isFound = true;
                        break;
                    }
                }

                // Controle product nog niet in Cart --> toevoegen
                if (!isFound)
                {
                    Cart.Add(new Cart(naam, prijs, 1));
                }
            }

            TotaalProducten();
        }

        private void TotaalProducten()
        {
            // Totale aantal producten berekenen in List (Cart)
            int Totaal = 0;
            foreach (var item in Cart)
            {
                Totaal += item.Aantal;
            }

            lblAantal.Text = $"Aantal producten: {Totaal}";
        }

        private void btnMandje1_Click(object sender, EventArgs e)
        {
            // ID doorgeven
            AddToCart(1);
        }

        private void btnMandje2_Click(object sender, EventArgs e)
        {
            // ID doorgeven
            AddToCart(2);
        }

        private void btnMandje3_Click(object sender, EventArgs e)
        {
            // ID doorgeven
            AddToCart(3);
        }

        private void btnMandje4_Click(object sender, EventArgs e)
        {
            // ID doorgeven
            AddToCart(4);
        }

        private void btnMandje5_Click(object sender, EventArgs e)
        {
            // ID doorgeven
            AddToCart(5);
        }

        private void btnMandje6_Click(object sender, EventArgs e)
        {
            // ID doorgeven
            AddToCart(6);
        }
    }
}
