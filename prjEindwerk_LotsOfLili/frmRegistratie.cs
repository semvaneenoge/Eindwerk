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

            txtVoornaam.ForeColor = Color.Gray;
            txtNaam.ForeColor = Color.Gray;
            txtAdres.ForeColor = Color.Gray;
            txtTelefoon.ForeColor = Color.Gray;
            txtEmail.ForeColor = Color.Gray;
            txtWW.ForeColor = Color.Gray;
            txtHerhaalWW.ForeColor = Color.Gray;
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

        private void txtVoornaam_TextChanged(object sender, EventArgs e)
        {
            if (txtVoornaam.Text == "" || txtVoornaam.Text == "Email")
            {
                txtVoornaam.ForeColor = Color.Gray;
            }
            else
            {
                txtVoornaam.ForeColor = Color.Black;
            }
        }

        private void txtNaam_TextChanged(object sender, EventArgs e)
        {
            if (txtNaam.Text == "" || txtNaam.Text == "Email")
            {
                txtNaam.ForeColor = Color.Gray;
            }
            else
            {
                txtNaam.ForeColor = Color.Black;
            }
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            if (txtAdres.Text == "" || txtAdres.Text == "Email")
            {
                txtAdres.ForeColor = Color.Gray;
            }
            else
            {
                txtAdres.ForeColor = Color.Black;
            }
        }

        private void txtTelefoon_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefoon.Text == "" || txtTelefoon.Text == "Email")
            {
                txtTelefoon.ForeColor = Color.Gray;
            }
            else
            {
                txtTelefoon.ForeColor = Color.Black;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtEmail.Text == "Email")
            {
                txtEmail.ForeColor = Color.Gray;
            }
            else
            {
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtWW_TextChanged(object sender, EventArgs e)
        {
            if (txtWW.Text == "" || txtWW.Text == "Email")
            {
                txtWW.ForeColor = Color.Gray;
            }
            else
            {
                txtWW.ForeColor = Color.Black;
                txtWW.PasswordChar = '*';
            }
        }

        private void txtHerhaalWW_TextChanged(object sender, EventArgs e)
        {
            if (txtHerhaalWW.Text == "" || txtHerhaalWW.Text == "Email")
            {
                txtHerhaalWW.ForeColor = Color.Gray;
            }
            else
            {
                txtHerhaalWW.ForeColor = Color.Black;
                txtHerhaalWW.PasswordChar = '*';
            }
        }
    }
}
