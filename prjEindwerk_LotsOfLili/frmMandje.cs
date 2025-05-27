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
using prjEindwerk_LotsOfLili.DA;
using prjEindwerk_LotsOfLili.Helper;

namespace prjEindwerk_LotsOfLili
{
    public partial class frmMandje : Form
    {
        public bool isAdmin;

        public int userID;

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
                listItem.SubItems.Add("€ " + item.Prijs.ToString("0.00"));
                listItem.SubItems.Add(item.Aantal.ToString());
                // Listview vullen
                lsvMandje.Items.Add(listItem);

                // Totale prijs berekenen
                Totaal += item.Prijs * item.Aantal;
            }

            // Totale prijs tonen
            lblTotPrijs.Text = $"€ {Totaal.ToString("0.00")}";
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            // Waarden doorgeven en Home weergeven
            frmHome Home = new frmHome();
            Home.Cart = Cart;
            Home.userID = userID;
            Home.customerNameHome = customerName;
            Home.userEmail = userEmail;
            Home.isAdmin = isAdmin;
            Home.Show();
            this.Hide();
        }

        private void frmMandje_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Waarden doorgeven en Home weergeven
            frmHome Home = new frmHome();
            Home.Cart = Cart;
            Home.userID = userID;
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
            BestellingDA bestellingDA = new BestellingDA();

            try
            {
                // Tekst van mail maken (klant)
                string bodyEmailKlant = $@"
<!DOCTYPE html>
<html>
<head>
<style>
th {{margin-left: 50px}}
td {{margin-left: 50px}}
</style>
</head>
<body>
    <p>Bedankt voor het shoppen bij Lots of Lili! Gelieve het geld over te maken op ons banknummer: BE20 9733 5462 4556.</p>
    <p>Hier een lijst van alle gekochte producten:</p>
<table>
    <tr>
        <th style='padding-right: 10px;'>Product</th>
        <th style='padding-right: 10px;'>Aantal</th>
        <th style='padding-right: 10px;'>Prijs</th>
        <th style='padding-right: 10px;'>Totaal</th>
    </tr>";

                // Producten toevoegen aan tekst
                foreach (var item in Cart)
                {
                    bodyEmailKlant += $@"
    <tr>
        <td style='padding-right: 10px;'>{item.Naam}</td>
        <td style='padding-right: 10px;'>{item.Aantal}</td>
        <td style='padding-right: 10px;'>€ {item.Prijs.ToString("0.00")}</td>
        <td style='padding-right: 10px;'>€ {(item.Aantal * item.Prijs).ToString("0.00")}</td>
    </tr>";
                }

                // Totaalbedrag toevoegen aan tekst
                bodyEmailKlant += $@"
<p>Totaalbedrag: € {Totaal.ToString("0.00")}</p>
</table>
</body>
</html>";

                // Nieuwe mail maken
                MailMessage mailKlant = new MailMessage();
                mailKlant.From = new MailAddress("eindwerk.lotsoflili@gmail.com");
                mailKlant.To.Add(userEmail);
                mailKlant.Subject = "Betalen Lots of Lili";
                mailKlant.Body = bodyEmailKlant;
                mailKlant.IsBodyHtml = true;

                // Smtp-client instellen voor het verzenden van de email (via gmail)
                SmtpClient smtpKlant = new SmtpClient("smtp.gmail.com");
                smtpKlant.Port = 587;
                smtpKlant.Credentials = new NetworkCredential("testen.eindwerk@gmail.com", "lijw vqjp inbo avjd");
                smtpKlant.EnableSsl = true;
                    
                // M1ail verzenden
                smtpKlant.Send(mailKlant);

                try
                {
                    // Tekst van mail maken
                    string bodyEmailAdmin = $@"
<!DOCTYPE html>
<html>
<body>
    <p>Er is een bestelling geplaatst.</p>
    <p>Naam: {customerName}</p>
    <p>Email: {userEmail}</p>
    <p>
    <br>
    <p>Bestelde producten:</p>
<table>
    <tr>
        <th style='padding-right: 10px;'>Product</th>
        <th style='padding-right: 10px;'>Aantal</th>
        <th style='padding-right: 10px;'>Prijs</th>
        <th style='padding-right: 10px;'>Totaal</th>
    </tr>";
                    
                    // Producten toevoegen aan tekst
                    foreach (var item in Cart)
                    {
                        bodyEmailKlant += $@"
    <tr>
        <td style='padding-right: 10px;'>{item.Naam}</td>
        <td style='padding-right: 10px;'>{item.Aantal}</td>
        <td style='padding-right: 10px;'>€ {item.Prijs.ToString("0.00")}</td>
        <td style='padding-right: 10px;'>€ {(item.Aantal * item.Prijs).ToString("0.00")}</td>
    </tr>";
                    }

                    bodyEmailKlant += $@"
<p>Totaalbedrag: € {Totaal.ToString("0.00")}</p>
</table>
</body>
</html>";

                    // Nieuwe mail maken
                    MailMessage mailAdmin = new MailMessage();
                    mailAdmin.From = new MailAddress("eindwerk.lotsoflili@gmail.com");
                    mailAdmin.To.Add("testen.eindwerk@gmail.com");
                    mailAdmin.Subject = "Bestelling Lots of Lili";
                    mailAdmin.Body = bodyEmailKlant;
                    mailAdmin.IsBodyHtml = true;

                    // Smtp-client instellen voor het verzenden van de email (via gmail)
                    SmtpClient smtpAdmin = new SmtpClient("smtp.gmail.com");
                    smtpAdmin.Port = 587;
                    smtpAdmin.Credentials = new NetworkCredential("eindwerk.lotsoflili@gmail.com", "aefq jsmm sgty iwga");
                    smtpAdmin.EnableSsl = true;

                    // Mail verzenden
                    smtpAdmin.Send(mailAdmin);

                    bestellingDA.SaveCartAsJSON(userID, Cart);

                    MessageBox.Show("Email is succesvol verzonden.");
                }
                catch (Exception ex1)
                {
                    MessageBox.Show($"Er is een fout opgetreden bij het verzenden van de email: {ex1.Message}.");
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show($"Er is een fout opgetreden bij het verzenden van de email: {ex2.Message}.");
            }

            // List leegmaken en listview updaten
            Cart.Clear();
            UpdateListview();
            checkList();
        }
    }
}
