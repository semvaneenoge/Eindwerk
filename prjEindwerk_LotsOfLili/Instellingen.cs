using prjEindwerk_LotsOfLili.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using prjEindwerk_LotsOfLili.DA;

namespace prjEindwerk_LotsOfLili
{
    public partial class Instellingen : Form
    {
        public string customerName;

        int pogingen;

        public Instellingen()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();
            Home.customerNameHome = customerName;
            Home.Show();
            this.Hide();
        }

        private void btnWWVeranderen_Click(object sender, EventArgs e)
        {
            Gebruikers G = new Gebruikers();

            GebruikersDA.WWControle(G);

            string ww = Interaction.InputBox("Gelieve uw wachtwoord eerst in te geven.", "Controle");

            string newWW = Interaction.InputBox("Gelieve uw nieuw wachtwoord in te voeren.", "");

            GebruikersDA.WWVeranderen(G, ww, newWW);
        }
    }
}
