
using BAL.Enums;
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
using DAL;
using System.Text.RegularExpressions;

namespace AdancedProgrammingCA
{

   public partial class AddStudent : FormMenu
    {
        DAO dao = new DAO();
        ShowData sd = new ShowData();
        //RegexValidation val = new RegexValidation();
        
        public AddStudent()
        {
            InitializeComponent();
            cboAddCounty.DataSource = Enum.GetValues(typeof(Counties));
            cboAddCounty.SelectedItem = "Select County";
            cboAddCourse.DataSource = Enum.GetValues(typeof(Courses));
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string firstName = txtAddFname.Text;
            string lastName = txtAddSname.Text;
            string email = txtAddEmail.Text;
            string phone = txtAddPhone.Text;
            string addressLine1 = txtAddAddress1.Text;
            string addressLine2 = txtAddAddress2.Text;
            string city = txtAddCity.Text;
            string county = cboAddCounty.SelectedItem.ToString();         
            string courseTitle = cboAddCourse.SelectedValue.ToString();
            string level = LevelChoice();

            int courseId = sd.GetCourseID(level, courseTitle);

            if (Validation() == 0)
            {
                errorProvider1.Clear();
                AddNewStudent addStu = new AddNewStudent(firstName, lastName, email, phone, addressLine1, addressLine2, city, county, courseId);
                addStu.AddStudentToDb();
                MessageBox.Show("Student added to database");
                CancelItems();

                Program.SHOW_STUDENTS.RefreshGrid();

                this.Close();
            }          
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

        public int Validation()
        {
            int flag = 0;
            Regex r = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            Regex num = new Regex(@"^[0-9]*$");

            if (txtAddFname.Text == "")
            {
                txtAddFname.Focus();
                errorProvider1.SetError(txtAddFname, MessageBox.Show("Please enter Firstname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                flag = 1;
            }
            else if (txtAddSname.Text == "")
            {
                txtAddSname.Focus();
                errorProvider1.SetError(txtAddSname, MessageBox.Show("Please enter Surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                flag = 1;
            }
            else if (!r.IsMatch(txtAddEmail.Text))
            {
                txtAddEmail.Focus();
                errorProvider1.SetError(txtAddEmail, MessageBox.Show("Please enter valid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                flag = 1;
            }
            else if (!num.IsMatch(txtAddPhone.Text))
            {
                txtAddPhone.Focus();
                errorProvider1.SetError(txtAddPhone, MessageBox.Show("Please enter numbers only for Phone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                flag = 1;
            }
            else if (txtAddAddress1.Text == "")
            {
                txtAddAddress1.Focus();
                errorProvider1.SetError(txtAddAddress1, MessageBox.Show("Please enter Address Line1 details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                flag = 1;
            }
            else if (txtAddCity.Text == "")
            {
                txtAddCity.Focus();
                errorProvider1.SetError(txtAddCity, MessageBox.Show("Please enter City", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                flag = 1;
            }
            else if (cboAddCounty.Text == "")
            {
                cboAddCounty.Focus();
                errorProvider1.SetError(cboAddCounty, MessageBox.Show("Please enter City", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                flag = 1;
            }
            else if (cboAddCourse.SelectedItem.ToString() == "")
            {
                cboAddCourse.Focus();
                errorProvider1.SetError(cboAddCourse, MessageBox.Show("Please select a Course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                flag = 1;
            }
            else if (!rdoPostgrad.Checked && !rdoUndergrad.Checked)
            {
                rdoUndergrad.Focus();
                errorProvider1.SetError(rdoUndergrad, MessageBox.Show("Please select a Level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                flag = 1;
            }

            return flag;
        }
            


        public string LevelChoice()
        {
            if (rdoPostgrad.Checked)
            {
                return "Postgraduate";
            }
            else
            {
                return "Undergraduate";
            }
        }

        private void txtAddFname_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtAddSname_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtAddEmail_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
