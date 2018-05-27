
using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdancedProgrammingCA
{
    public partial class formSMS : Form
    {
        HashData hash = new HashData();

        public formSMS()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = hash.HashPassword(txtPassword.Text);

            Login log = new Login(user, pass);
            string status = log.CheckUserPass();

            if (status == "no")
            {
                MessageBox.Show("Failed to Login");
            }
            else
            {
                MessageBox.Show("Login Successful");
             //   lblDisplay.Text = "Welcome " + status;
            //    txtUser.Enabled = false;
            //    txtPass.Enabled = false;
            //    label1.Enabled = false;
            //    label2.Enabled = false;
            //    btnLogin.Enabled = false;
            //    btnReg.Enabled = false;
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void menuRegister_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }

        private void menuExitLogin_Click(object sender, EventArgs e)
        {
            //Code to exit login
        }

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
