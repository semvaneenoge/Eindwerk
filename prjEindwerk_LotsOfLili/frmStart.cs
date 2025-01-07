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

            txtEmail.ForeColor = Color.Gray;
            txtWW.ForeColor = Color.Gray;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login L = new Login();

            L.Email = txtEmail.Text;
            L.Wachtwoord = txtWW.Text;

            bool blnLogin = LoginDA.LoginValidation(L);

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

        private void btnRegistratie_Click(object sender, EventArgs e)
        {
            frmRegistratie Registreren = new frmRegistratie();
            this.Hide();
            Registreren.Show();
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
            if (txtWW.Text == "" || txtWW.Text == "Wachtwoord")
            {
                txtWW.ForeColor = Color.Gray;
            }
            else
            {
                txtWW.ForeColor = Color.Black;
                txtWW.PasswordChar = '*';
            }
        }
    }
}
