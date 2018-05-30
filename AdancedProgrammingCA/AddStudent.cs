using BAL;
using BAL.Enums;
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
    public partial class AddStudent : FormMenu
    {
        public AddStudent()
        {
            InitializeComponent();
            cboAddCounty.DataSource = Enum.GetValues(typeof(Counties));
    
            cboAddCourse.DataSource = Enum.GetValues(typeof(Courses));
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string firstName = txtAddFname.Text;
            string lastName = txtAddSname.Text;
            string addressLine1 = txtAddAddress1.Text;
            string addressLine2 = txtAddAddress2.Text;
            string city = txtAddCity.Text;
           // Counties county = Enum.TryParse(cboAddCounty.SelectedValue.ToString(), out county);
            string email = txtAddEmail.Text;
            string phone = txtAddPhone.Text;
            string level = rdoPostgrad.ToString();
           // Courses course = cboAddCourse.SelectedItem.ToString();

            // method to call from BIZ
            //AddNewStudent addStu = new AddNewStudent(firstname, lastname, addressLine1, addessLine2);
            //addStu.AddStudentToDb();

           // CancelItems();

           // MessageBox.Show("Student added to database");
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            CancelItems();          
        }

        public void CancelItems()
        {
            txtAddFname.Clear();
            txtAddSname.Clear();
            txtAddAddress1.Clear();
            txtAddAddress2.Clear();
            txtAddCity.Clear();
            cboAddCounty.SelectedItem = "";
            txtAddEmail.Clear();
            txtAddPhone.Clear();
        }
    }
}
