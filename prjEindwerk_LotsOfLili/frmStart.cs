using prjEindwerk_LotsOfLili.DA;
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

namespace prjEindwerk_LotsOfLili
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Gebruikers G = new Gebruikers();

            G.Email = txtEmailInlog.Text;
            G.Wachtwoord = txtWWInlog.Text;

            bool blnLogin = GebruikersDA.LoginValidation(G);

            if (blnLogin == true)
            {
                this.Hide();
                Home Dashboard = new Home();
                Dashboard.Show();
            }
            else
            {
                MessageBox.Show("Verkeerde combinatie");
            }
        }

        private void Reset()
        {
            Text = "";
        }

        private void btnRegistratie_Click(object sender, EventArgs e)
        {
            grbRegistreer.Visible = true;
        }

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            Gebruikers G = new Gebruikers();

            if (txtHerhaalWW.Text == txtWWRegistreer.Text)
            {
                G.Voornaam = txtVoornaam.Text;
                G.Naam = txtNaam.Text;
                G.Adres = txtAdres.Text;
                G.Telefoon = txtTelefoon.Text;
                G.Email = txtEmailRegistreer.Text;
                G.Wachtwoord = txtWWRegistreer.Text;

                GebruikersDA.Registreren(G);

                this.Hide();
                Home Dashboard = new Home();
                Dashboard.Show();
            }
            else
            {
                MessageBox.Show("Foutieve gegevens.");
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            grbRegistreer.Visible = false;
        }

        private void txtWWInlog_Enter(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtWWInlog_Leave(object sender, EventArgs e)
        {

        }

        private void txtWWRegistreer_Enter(object sender, EventArgs e)
        {

        }

        private void txtWWRegistreer_Leave(object sender, EventArgs e)
        {

        }

        private void txtHerhaalWW_Enter(object sender, EventArgs e)
        {

        }

        private void txtHerhaalWW_Leave(object sender, EventArgs e)
        {

        }
    }
}
