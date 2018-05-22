using BIZ;
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
        public formSMS()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            Login log = new Login(user, pass);
            string status = log.CheckUserPass();

            if (status == "no")
            {
                MessageBox.Show("failed to Login");
            }
            //else
            //{
            //    MessageBox.Show("Success");
            //    lblDisplay.Text = "Welcome " + status;
            //    txtUser.Enabled = false;
            //    txtPass.Enabled = false;
            //    label1.Enabled = false;
            //    label2.Enabled = false;
            //    btnLogin.Enabled = false;
            //    btnReg.Enabled = false;
            //}
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Register register = new Register();
            //r.ShowDialog();
        }

        private void menuRegister_Click(object sender, EventArgs e)
        {
            //Register reg = new Register();
            //reg.ShowDialog();
        }

        private void menuExitLogin_Click(object sender, EventArgs e)
        {
            //Code to exit login
        }

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            //code to cancel login
        }
    }
}
