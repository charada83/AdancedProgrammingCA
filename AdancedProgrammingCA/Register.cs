using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace AdancedProgrammingCA
{
    public partial class Register : Form
    {
        HashData hash = new HashData();
        public Register()
        {
            InitializeComponent();          
        }

        private void btnRegForm_Click(object sender, EventArgs e)
        {
            string regFirstname = txtRegFirstname.Text;
            string regSurname = txtRegSurname.Text;
            string regUser = txtRegUsername.Text;
            string regPass = hash.HashPassword(txtRegPassword.Text);
            

            AddData ad = new AddData();
            ad.AddStaff(regFirstname, regSurname, regUser, regPass);
            MessageBox.Show("Registration Successful. Please Login");
            this.Close();
        }

        private void btnCancelReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
