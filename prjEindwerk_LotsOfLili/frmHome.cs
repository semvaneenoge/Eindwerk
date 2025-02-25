﻿using Google.Protobuf.WellKnownTypes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjEindwerk_LotsOfLili
{
    public partial class frmHome : Form
    {
        public bool isAdmin {  get; set; }

        int Page, Tab, previousTab, maxPages;

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
            // Probeer process memory te verminderen
            //
            // !!! Commentaar typen bij ALLES !!!
            //
            // buttons --> copy code verminderen
            //
            // Verder testen --> meer producten plaatsen in Pins --> kijken if maxPages verandert !!!

            ProductDA p = new ProductDA();

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

            lblGebruiker.Text = Name;
        }

        private void lblBorder(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            ControlPaint.DrawBorder(e.Graphics, lblProduct1.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void checkPage()
        {
            ProductDA p = new ProductDA();

            int maxProducts = 6;
            var ProductsList = p.Agendas;

            if (Tab != previousTab)
            {
                Page = 0;
            }

            previousTab = Tab;

            switch (Tab)
            {
                case 1:
                    p.AgendasInvoegen();
                    ProductsList = p.Agendas;
                    maxPages = ProductsList.Count / maxProducts;
                    break;
                case 2:
                    p.HorlogesInvoegen();
                    ProductsList = p.Horloges;
                    maxPages = ProductsList.Count / maxProducts;
                    break;
                case 3:
                    p.PortemonneesInvoegen();
                    ProductsList = p.Portemonnees;
                    maxPages = ProductsList.Count / maxProducts;
                    break;
                case 4:
                    p.PinsInvoegen();
                    ProductsList = p.Pins;
                    maxPages = ProductsList.Count / maxProducts;
                    break;
            }

            for (int i = 0; i < maxProducts; i++)
            {
                PictureBox picTest = (PictureBox)pnlProducten.Controls["picProduct" + (i + 1)];
                Label lblTest = (Label)pnlProducten.Controls["lblProduct" + (i + 1)];

                if (i < ProductsList.Count)
                {
                    var product = ProductsList[i + (maxProducts * Page)];

                    if (picTest != null)
                    {
                        picTest.Image = product.Foto;
                    }
                    if (lblTest != null)
                    {
                        lblTest.Text = $"{product.Naam}\n € {product.Prijs}";
                    }
                }
            }

            btnVorige.Enabled = Page > 0;
            btnVolgende.Enabled = Page < maxPages - 1;

            lblPagina.Text = $"pagina {Page + 1} / {maxPages}";
        }

        private void btnVorige_Click(object sender, EventArgs e)
        {
            Page--;
            checkPage();
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            Page++;
            checkPage();
        }

        private void btnMandje_Click(object sender, EventArgs e)
        {
            // Winkelmandje openen
            frmMandje Mandje = new frmMandje();
            Mandje.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Admin menu openen
            frmAdmin Admin = new frmAdmin();
            Admin.Show();
        }

        private void UpdateButton(int tab, System.Windows.Forms.Button selectedButton)
        {
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
            UpdateButton(1, btnAgendas);
        }

        private void btnHorloges_Click(object sender, EventArgs e)
        {
            UpdateButton(2, btnHorloges);
        }

        private void btnPortemonnee_Click(object sender, EventArgs e)
        {
            UpdateButton(3, btnPortemonnee);
        }

        private void btnPins_Click(object sender, EventArgs e)
        {
            UpdateButton(4, btnPins);
        }
    }
}
