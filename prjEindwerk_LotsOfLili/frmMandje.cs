using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjEindwerk_LotsOfLili
{
    public partial class frmMandje : Form
    {
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
            UpdateListview();
        }

        private void UpdateListview()
        {
            lsvMandje.Items.Clear();
            Totaal = 0;

            foreach (var item in Cart)
            {
                ListViewItem listItem = new ListViewItem(item.Naam);
                listItem.SubItems.Add("€ " + item.Prijs.ToString());
                listItem.SubItems.Add(item.Aantal.ToString());
                lsvMandje.Items.Add(listItem);

                Totaal += item.Prijs * item.Aantal;
            }

            lblTotPrijs.Text = $"€ {Totaal}";
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();
            Home.Cart = Cart;
            Home.customerNameHome = customerName;
            Home.userEmail = userEmail;
            Home.Show();
            this.Hide();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            if (lsvMandje.SelectedItems.Count > 0)
            {
                string selectedProduct = lsvMandje.SelectedItems[0].Text;

                foreach (var item in Cart)
                {
                    if (item.Naam == selectedProduct)
                    {
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

                UpdateListview();
            }
        }

        private void btnVerwijderAlleGeselecteerd_Click(object sender, EventArgs e)
        {
            if (lsvMandje.SelectedItems.Count > 0)
            {
                string selectedProduct = lsvMandje.SelectedItems[0].Text;

                foreach (var item in Cart)
                {
                    if (item.Naam == selectedProduct)
                    {
                        Cart.Remove(item);
                        break;
                    }
                }

                UpdateListview();
            }
        }

        private void btnVerwijderAlles_Click(object sender, EventArgs e)
        {
            Cart.Clear();
            UpdateListview();
        }

        private void btnBetalen_Click(object sender, EventArgs e)
        {

        }
    }
}
