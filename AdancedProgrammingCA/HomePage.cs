
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
        public formSMS()
        {
            InitializeComponent();
        }

        HashData hash = new HashData();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = hash.HashPassword(txtPassword.Text);

            Login log = new Login(user, pass);

            string status = log.Username;

            if (status == "no")
            {
                MessageBox.Show("Failed to Login");
            }
            else
            {
                MessageBox.Show("Welcome " + status);
                this.Hide();
                ShowStudents students = new ShowStudents();
                students.Show();
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

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void exitLoginMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using the Student Management System");
            Application.Exit();
        }
    }
}
