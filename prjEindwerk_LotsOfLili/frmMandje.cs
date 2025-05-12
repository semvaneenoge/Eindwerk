using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace prjEindwerk_LotsOfLili
{
    public partial class frmMandje : Form
    {
        public bool isAdmin;

        public string userEmail;

        public List<Cart> Cart;

        public string customerName;

        double  Totaal;

        public frmMandje()
        {
            InitializeComponent();

            // --- notes ---
        }

        private void frmMandje_Load(object sender, EventArgs e)
        {
            // Listview updaten bij laden van form
            UpdateListview();

            checkList();
        }

        private void checkList()
        {
            if (lsvMandje.Items.Count == 0)
            {
                btnBetalen.Enabled = false;
            }
            else
            {
                btnBetalen.Enabled = true;
            }
        }

        private void UpdateListview()
        {
            // Listview leegmaken, prijs = 0
            lsvMandje.Items.Clear();
            Totaal = 0;

            // Controle op items in list
            foreach (var item in Cart)
            {
                ListViewItem listItem = new ListViewItem(item.Naam);
                listItem.SubItems.Add("€ " + item.Prijs.ToString());
                listItem.SubItems.Add(item.Aantal.ToString());
                // Listview vullen
                lsvMandje.Items.Add(listItem);

                // Totale prijs berekenen
                Totaal += item.Prijs * item.Aantal;
            }

            // Totale prijs tonen
            lblTotPrijs.Text = $"€ {Totaal}";
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            // Waarden doorgeven en Home weergeven
            frmHome Home = new frmHome();
            Home.Cart = Cart;
            Home.customerNameHome = customerName;
            Home.userEmail = userEmail;
            Home.isAdmin = isAdmin;
            Home.Show();
            this.Hide();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            // Cointrole of item geselecteerd is
            if (lsvMandje.SelectedItems.Count > 0)
            {
                // Naam van geselecteerde item opvangen
                string selectedProduct = lsvMandje.SelectedItems[0].Text;

                // Lijst controleren
                foreach (var item in Cart)
                {
                    // Controle op naam in List gelijk aan geselecteerde product
                    if (item.Naam == selectedProduct)
                    {
                        // Aantal verminderen of item verwijderen
                        if (item.Aantal > 1)
                        {
                            item.Aantal--;
                        }
                        else
                        {
                            Cart.Remove(item);
                        }
                        break;
                    }
                }

                // List terug updaten
                UpdateListview();

                checkList();
            }
        }

        private void btnVerwijderAlleGeselecteerd_Click(object sender, EventArgs e)
        {
            // Cointrole of item geselecteerd is
            if (lsvMandje.SelectedItems.Count > 0)
            {
                // Naam van geselecteerde item opvangen
                string selectedProduct = lsvMandje.SelectedItems[0].Text;

                // Lijst controleren
                foreach (var item in Cart)
                {
                    // Controle op naam in List gelijk aan geselecteerde product
                    if (item.Naam == selectedProduct)
                    {
                        // Item verwijderen uit List
                        Cart.Remove(item);
                        break;
                    }
                }

                // List terug updaten
                UpdateListview();

                checkList();
            }
        }

        private void btnVerwijderAlles_Click(object sender, EventArgs e)
        {
            // List leegmaken en listview updaten
            Cart.Clear();
            UpdateListview();

            checkList();
        }

        private void btnBetalen_Click(object sender, EventArgs e)
        {
            try
            {
                // Tekst van mail maken
                string emailTekst = "Bedankt voor het shoppen bij Lots of Lili! Gelieve het geld over te maken op ons banknummer: BE20 9733 5462 4556.\n\n" +
                    "Hier een lijst van alle gekochte producten:\n\n";

                // Producten toevoegen aan tekst
                foreach (var item in Cart)
                {
                    emailTekst += $"{item.Naam} - {item.Aantal} x € {item.Prijs} = € {item.Aantal * item.Prijs}\n";
                }

                // Totaalbedrag toevoegen aan tekst
                emailTekst += $"\nTotaalbedrag: € {Totaal}";

                // Nieuwe mail maken
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("eindwerk.lotsoflili@gmail.com");
                mail.To.Add(userEmail);
                mail.Subject = "Betalen Lots of Lili";
                mail.Body = emailTekst;

                // Smtp-client instellen voor het verzenden van de email (via gmail)
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("eindwerk.lotsoflili@gmail.com", "aefq jsmm sgty iwga");
                smtp.EnableSsl = true;

                // Mail verzenden
                smtp.Send(mail);
                MessageBox.Show("Email is succesvol verzonden.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden bij het verzenden van de email: {ex.Message}.");
            }

            // List leegmaken en listview updaten
            Cart.Clear();
            UpdateListview();
        }

        private void frmMandje_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Waarden doorgeven en Home weergeven
            frmHome Home = new frmHome();
            Home.Cart = Cart;
            Home.customerNameHome = customerName;
            Home.userEmail = userEmail;
            Home.isAdmin = isAdmin;
            Home.Show();
            this.Hide();
        }
    }
}
