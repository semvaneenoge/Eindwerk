using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEindwerk_LotsOfLili
{
    public partial class frmMandje : Form
    {
        public List<Cart> NewCart;

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

            foreach (var item in NewCart)
            {
                ListViewItem listItem = new ListViewItem(item.Naam);
                listItem.SubItems.Add("€ " + item.Prijs.ToString());
                listItem.SubItems.Add(item.Aantal.ToString());
                lsvMandje.Items.Add(listItem);

                Totaal += item.Prijs * item.Aantal;
            }

            lblTotaal.Text = $"De totale prijs is € {Totaal}";
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();
            Home.Cart = NewCart;
            Home.Show();
            this.Hide();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            if (lsvMandje.SelectedItems.Count > 0)
            {
                string selectedName = lsvMandje.SelectedItems[0].Text;

                foreach (var item in NewCart)
                {
                    if (item.Naam == selectedName)
                    {
                        if (item.Aantal > 1)
                        {
                            item.Aantal--;
                        }
                        else
                        {
                            NewCart.Remove(item);
                        }
                        break;
                    }
                }

                UpdateListview();
            }
        }
    }
}
