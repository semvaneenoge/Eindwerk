using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjEindwerk_LotsOfLili.DA;
using prjEindwerk_LotsOfLili.Model;

namespace prjEindwerk_LotsOfLili
{
    public partial class frmAdmin : Form
    {
        public bool isAdmin;

        public int userID;

        public string userEmail;

        public List<Cart> Cart;

        public string customerName;

        Dictionary<string, int> klantNaamID = new Dictionary<string, int>();

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lsbKlanten.Items.Clear();
            lsvBestellingen.Items.Clear();
            lsvDetails.Items.Clear();

            BestellingDA bestellingDA = new BestellingDA();

            List<(int klantID, string klantNaam)> klanten = bestellingDA.GetCustomerNames();

            klantNaamID.Clear();
            foreach (var klant in klanten)
            {
                klantNaamID[klant.klantNaam] = klant.klantID;
                lsbKlanten.Items.Add(klant.klantNaam);
            }
        }

        private void lsbKlanten_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvBestellingen.Items.Clear();
            lsvDetails.Items.Clear();

            BestellingDA bestellingDA = new BestellingDA();

            if (lsbKlanten.SelectedItems.Count > 0)
            {
                string selectedName = lsbKlanten.SelectedItem.ToString();
                int klantID = klantNaamID[selectedName];

                List<(int, DateTime)> bestellingen = bestellingDA.GetOrdersByCustomer(klantID);

                foreach (var (bestellingID, datum) in bestellingen)
                {
                    ListViewItem item = new ListViewItem(bestellingID.ToString());
                    item.SubItems.Add(datum.ToShortDateString());
                    item.Tag = bestellingID;
                    lsvBestellingen.Items.Add(item);
                }
            }
        }

        private void lsvBestellingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvDetails.Items.Clear();

            BestellingDA bestellingDA = new BestellingDA();

            if (lsvBestellingen.SelectedItems.Count > 0)
            {
                int bestellingID = (int)lsvBestellingen.SelectedItems[0].Tag;

                List<Cart> lijstProducten = bestellingDA.GetOrderDetails(bestellingID);

                foreach (Cart product in lijstProducten)
                {
                    ListViewItem item = new ListViewItem(product.Naam);
                    item.SubItems.Add(product.Prijs.ToString());
                    item.SubItems.Add(product.Aantal.ToString());
                    lsvDetails.Items.Add(item);
                }
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();
            Home.Cart = Cart;
            Home.userID = userID;
            Home.customerNameHome = customerName;
            Home.userEmail = userEmail;
            Home.isAdmin = isAdmin;
            Home.Show();
            this.Hide();
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmHome Home = new frmHome();
            Home.Cart = Cart;
            Home.userID = userID;
            Home.customerNameHome = customerName;
            Home.userEmail = userEmail;
            Home.isAdmin = isAdmin;
            Home.Show();
            this.Hide();
        }

        private void btnProductFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            ofd.Title = "Kies een foto voor het product.";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnProductToevoegen_Click(object sender, EventArgs e)
        {
            string productType = "";
            string productNaam = "";

            if (rdbAgendas.Checked)
            {
                productType = "Agenda";
            }
            else if (rdbHorloges.Checked)
            {
                productType = "Horloge";
            }
            else if (rdbPortemonnees.Checked)
            {
                productType = "Portemonnee";
            }
            else if (rdbPins.Checked)
            {
                productType = "Pin";
            }
            else
            {
                MessageBox.Show("Selecteer een type.", "Type");
                return;
            }

            if (txtProductNaam.Text != "")
            {
                productNaam = txtProductNaam.Text;
            }

            if (!double.TryParse(txtProductPrijs.Text, out double productPrijs))
            {
                MessageBox.Show("Gelieve een geldige prijs in te geven.", "Prijs");
                return;
            }

            if (txtProductPrijs.Text.Contains("."))
            {
                MessageBox.Show("gelieve een komma te gebruiken i.p.v. een punt.", "Prijs");
                return;
            }

            Image productFoto = picFoto.Image;
            if (productFoto == null)
            {
                MessageBox.Show("Selecteer een foto.", "Foto");
                return;
            }

            ProductDA.ProductToevoegen(productType, productNaam, productPrijs, productFoto);

            txtProductNaam.Clear();
            txtProductPrijs.Clear();
            rdbAgendas.Checked = false;
            rdbHorloges.Checked = false;
            rdbPortemonnees.Checked = false;
            rdbPins.Checked = false;
        }

        private void btnProductVerwijderen_Click(object sender, EventArgs e)
        {
            string productType = "";

            if (rdbAgendas.Checked)
            {
                productType = "Agenda";
            }
            else if (rdbHorloges.Checked)
            {
                productType = "Horloge";
            }
            else if (rdbPortemonnees.Checked)
            {
                productType = "Portemonnee";
            }
            else if (rdbPins.Checked)
            {
                productType = "Pin";
            }
            else
            {
                MessageBox.Show("Selecteer een type.");
                return;
            }

            string productNaam = txtProductNaam.Text;

            ProductDA.ProductVerwijderen(productType, productNaam);

            txtProductNaam.Clear();
            txtProductPrijs.Clear();
            rdbAgendas.Checked = false;
            rdbHorloges.Checked = false;
            rdbPortemonnees.Checked = false;
            rdbPins.Checked = false;
        }
    }
}
