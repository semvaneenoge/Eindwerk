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
            //
            // berekingen pagina --> Pagina = 0 (Horloge[i + (6 * Pagina)]
            //
            // Namen variabelen/objecten aanpassen

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

        private void lblBorder(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            ControlPaint.DrawBorder(e.Graphics, lblProduct1.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void checkPage()
        {
            ProductDA p = new ProductDA();

            int maxProducts = 6;

            switch (Tab)
            {
                // Agendas
                case 1:
                    p.AgendasInvoegen();

                    for (int i = 0; i < maxProducts; i++)
                    {
                        PictureBox picTest = (PictureBox)pnlProducten.Controls["picProduct" + (i + 1)];
                        Label lblTest = (Label)pnlProducten.Controls["lblProduct" + (i + 1)];

                        if (i < p.Agendas.Count)
                        {
                            var product = p.Agendas[i + (maxProducts * Pagina)];

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

                // Horloges
                case 2:
                    p.HorlogesInvoegen();

                    for (int i = 0; i < maxProducts; i++)
                    {
                        PictureBox picTest = (PictureBox)pnlProducten.Controls["picProduct" + (i + 1)];
                        Label lblTest = (Label)pnlProducten.Controls["lblProduct" + (i + 1)];

                        if (i < p.Horloges.Count)
                        {
                            var product = p.Horloges[i + (maxProducts * Pagina)];

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

                // Portemonnees
                case 3:
                    p.PortemonneesInvoegen();

                    for (int i = 0; i < maxProducts; i++)
                    {
                        PictureBox picTest = (PictureBox)pnlProducten.Controls["picProduct" + (i + 1)];
                        Label lblTest = (Label)pnlProducten.Controls["lblProduct" + (i + 1)];

                        if (i < p.Portemonnees.Count)
                        {
                            var product = p.Portemonnees[i + (maxProducts * Pagina)];

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

                // Pins
                case 4:
                    p.PinsInvoegen();

                    for (int i = 0; i < maxProducts; i++)
                    {
                        PictureBox picTest = (PictureBox)pnlProducten.Controls["picProduct" + (i + 1)];
                        Label lblTest = (Label)pnlProducten.Controls["lblProduct" + (i + 1)];

                        if (i < p.Pins.Count)
                        {
                            var product = p.Pins[i + (maxProducts * Pagina)]; // Error door max. pagina (out of range)

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

            btnVorige.Enabled = Pagina > 0;
            btnVolgende.Enabled = Pagina < 1; // veranderen naar max. pagina

            lblPagina.Text = $"pagina {Pagina + 1} / 2";
        }

        private void btnVorige_Click(object sender, EventArgs e)
        {
            Pagina--;
            checkPage();
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            Pagina++;
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
            btnAgendas.Enabled = false;
            btnHorloges.Enabled = true;
            btnPortemonnee.Enabled = true;
            btnPins.Enabled = true;
            checkPage();
        }

        private void btnHorloges_Click(object sender, EventArgs e)
        {
            Tab = 2;
            btnAgendas.Enabled = true;
            btnHorloges.Enabled = false;
            btnPortemonnee.Enabled = true;
            btnPins.Enabled = true;
            checkPage();
        }

        private void btnPortemonnee_Click(object sender, EventArgs e)
        {
            Tab = 3;
            btnAgendas.Enabled = true;
            btnHorloges.Enabled = true;
            btnPortemonnee.Enabled = false;
            btnPins.Enabled = true;
            checkPage();
        }

        private void btnPins_Click(object sender, EventArgs e)
        {
            Tab = 4;
            btnAgendas.Enabled = true;
            btnHorloges.Enabled = true;
            btnPortemonnee.Enabled = true;
            btnPins.Enabled = false;
            checkPage();
        }

//        To reset your `Pagina` variable to 0 whenever the tab changes, you can reset the `Pagina` value within the logic for switching tabs, such as within the event that handles tab switching.
//        Assuming that `Tab` is the variable that determines which category is currently displayed (Agendas, Horloges, etc.), you can simply reset the `Pagina` value whenever the tab changes.

//Here’s an updated version of your code where the `Pagina` resets to 0 whenever the tab is switched:

//### Option 1: Inside `checkPage` method
//Modify your `checkPage()` method by checking if the `Tab` has changed and resetting the `Pagina` to 0 before updating the UI.

//```csharp
//private void checkPage()
//        {
//            ProductDA p = new ProductDA();
//            int maxProducts = 6;

//            // Reset Pagina when switching tabs
//            if (Tab != previousTab) // Assuming you have a `previousTab` variable
//            {
//                Pagina = 0; // Reset Pagina
//            }

//            previousTab = Tab; // Store the current tab for comparison next time

//            switch (Tab)
//            {
//                case 1: // Agendas
//                    p.AgendasInvoegen();
//                    break;
//                case 2: // Horloges
//                    p.HorlogesInvoegen();
//                    break;
//                case 3: // Portemonnees
//                    p.PortemonneesInvoegen();
//                    break;
//                case 4: // Pins
//                    p.PinsInvoegen();
//                    break;
//            }

//            // Load products
//            for (int i = 0; i < maxProducts; i++)
//            {
//                PictureBox picTest = (PictureBox)pnlProducten.Controls["picProduct" + (i + 1)];
//                Label lblTest = (Label)pnlProducten.Controls["lblProduct" + (i + 1)];

//                if (i < GetProductList().Count)
//                {
//                    var product = GetProductList()[i + (maxProducts * Pagina)];
//                    if (picTest != null)
//                    {
//                        picTest.Image = product.Foto;
//                    }
//                    if (lblTest != null)
//                    {
//                        lblTest.Text = $"{product.Naam}\n{product.Prijs}";
//                    }
//                }
//                else
//                {
//                    if (picTest != null)
//                    {
//                        picTest.Image = null;
//                    }
//                    if (lblTest != null)
//                    {
//                        lblTest.Text = "Geen product gevonden";
//                    }
//                }
//            }

//            // Enable or disable navigation buttons
//            btnVorige.Enabled = Pagina > 0;
//            btnVolgende.Enabled = Pagina < 1;

//            lblPagina.Text = $"pagina {Pagina + 1} / 2";
//        }

//        private List<Product> GetProductList()
//        {
//            switch (Tab)
//            {
//                case 1:
//                    return p.Agendas;
//                case 2:
//                    return p.Horloges;
//                case 3:
//                    return p.Portemonnees;
//                case 4:
//                    return p.Pins;
//                default:
//                    return new List<Product>();
//            }
//        }
//```

//### Option 2: Inside Tab Change Event
//If there is a tab change event (like a button or tab control change), you can reset `Pagina` to 0 inside that event handler directly:

//```csharp
//private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // Reset Pagina when switching tabs
//            Pagina = 0;

//            // You may want to update the 'Tab' variable to match the current tab
//            Tab = tabControl.SelectedIndex; // Assuming you're using TabControl and 0-indexed tabs

//            checkPage(); // Call your checkPage method to update the content
//        }
//```

//This way, each time you change tabs, `Pagina` will be reset to 0, and no errors will occur because the pagination logic will restart from the beginning of the new tab.

//### Additional Notes:
//- If you're handling the tab switching with a different approach (e.g., button clicks), ensure you reset `Pagina` in that handler.
//- The `Tab` variable should match the current tab so you can correctly load the right data when switching tabs.

    }
}
