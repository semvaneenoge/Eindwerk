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
        List<(string Naam, double Prijs)> TestCart;

        double  Totaal;

        public frmMandje(List<(string Naam, double Prijs)> cart)
        {
            InitializeComponent();
            TestCart = cart;
        }

        private void frmMandje_Load(object sender, EventArgs e)
        {
            foreach (var item in TestCart)
            {
                ListViewItem items = new ListViewItem(item.Naam);
                items.SubItems.Add("€ " + item.Prijs.ToString());
                lsvMandje.Items.Add(items);

                Totaal += item.Prijs;
            }

            lblTotaal.Text = $"€ {Totaal}";
        }
    }
}
