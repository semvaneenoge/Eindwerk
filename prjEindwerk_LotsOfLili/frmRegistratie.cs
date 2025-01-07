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
    public partial class frmRegistratie : Form
    {
        public frmRegistratie()
        {
            InitializeComponent();
        }

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            Login L = new Login();

            if (txtHerhaalWW.Text == txtWW.Text)
            {
                L.Voornaam = txtVoornaam.Text;
                L.Naam = txtNaam.Text;
                L.Adres = txtAdres.Text;
                L.Telefoon = txtTelefoon.Text;
                L.Email = txtEmail.Text;
                L.Wachtwoord = txtWW.Text;

                LoginDA.Registreren(L);
                Home Dashboard = new Home();
                this.Close();
                Dashboard.Show();
            }
            else
            {
                MessageBox.Show("Foutieve gegevens");
            }
        }

        private void txtVoornaam_Enter(object sender, EventArgs e)
        {
            txtVoornaam.Clear();
            txtVoornaam.ForeColor = Color.Black;
        }

        private void txtNaam_Enter(object sender, EventArgs e)
        {
            txtNaam.Clear();
            txtNaam.ForeColor = Color.Black;
        }

        private void txtAdres_Enter(object sender, EventArgs e)
        {
            txtAdres.Clear();
            txtAdres.ForeColor = Color.Black;
        }

        private void txtTelefoon_Enter(object sender, EventArgs e)
        {
            txtTelefoon.Clear();
            txtTelefoon.ForeColor = Color.Black;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtEmail.ForeColor = Color.Black;
        }

        private void txtWW_Enter(object sender, EventArgs e)
        {
            txtWW.Clear();
            txtWW.ForeColor = Color.Black;
        }

        private void txtHerhaalWW_Enter(object sender, EventArgs e)
        {
            txtHerhaalWW.Clear();
            txtHerhaalWW.ForeColor = Color.Black;
        }

        private void txtVoornaam_Leave(object sender, EventArgs e)
        {
            if (txtVoornaam.Text == "")
            {
                txtVoornaam.Text = "Voornaam";
                txtVoornaam.ForeColor = Color.Black;
            }
        }

        private void txtNaam_Leave(object sender, EventArgs e)
        {
            txtNaam.Text = "Naam";
        }

        private void txtAdres_Leave(object sender, EventArgs e)
        {
            txtAdres.Text = "Adres";
        }

        private void txtTelefoon_Leave(object sender, EventArgs e)
        {
            txtTelefoon.Text = "Telefoon";
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.Text = "Email";
        }

        private void txtWW_Leave(object sender, EventArgs e)
        {
            txtWW.Text = "Wachtwoord";
        }

        private void txtHerhaalWW_Leave(object sender, EventArgs e)
        {
            txtHerhaalWW.Text = "Wachtwoord herhalen";
        }
    }
}
