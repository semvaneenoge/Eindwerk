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

        public string userEmail;

        public List<Cart> Cart;

        public string customerName;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();
            Home.Cart = Cart;
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

            string productNaam = txtProductNaam.Text;

            if (!double.TryParse(txtProductPrijs.Text, out double productPrijs))
            {
                MessageBox.Show("Geef een geldige prijs in te geven.", "Prijs");
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
        }
    }
}
