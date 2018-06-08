
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

namespace AdancedProgrammingCA
{
    
    public partial class AddStudent : FormMenu
    {
        DAO dao = new DAO();
        ShowData sd = new ShowData();

        public AddStudent()
        {
            InitializeComponent();
            cboAddCounty.DataSource = Enum.GetValues(typeof(Counties));
            cboAddCounty.SelectedItem = "Select County";
            //cboAddCourse.DataSource = Enum.GetValues(typeof(Courses));
            cboAddCourse.DataSource = sd.GetCourses();
        }

        //public void FillCourseCombo()
        //{
        //    cboAddCourse.ValueMember = "CourseId";
        //    cboAddCourse.DisplayMember = "CourseTitle";
        //    cboAddCourse.DataSource = sd.GetCourses();
        //}

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //if (RegexValidation.checkEmail(txtAddEmail.Text.ToString()))
            //{
            //    lblValidEmail.Text = "Email Valid";
            //}
            //else
            //{
            //    lblValidEmail.Text = "Invalid Email";
            //}

            string id = lblShowStudentId.Text;
            string firstName = txtAddFname.Text;
            string lastName = txtAddSname.Text;
            string addressLine1 = txtAddAddress1.Text;
            string addressLine2 = txtAddAddress2.Text;
            string city = txtAddCity.Text;
            string county = cboAddCounty.SelectedItem.ToString();
            string email = txtAddEmail.Text;
            string phone = txtAddPhone.Text;
            int courseId = int.Parse(cboAddCourse.ValueMember);
            string courseTitle = cboAddCourse.SelectedValue.ToString();
            string level = LevelChoice();

            AddNewStudent addStu = new AddNewStudent(firstName, lastName, addressLine1, addressLine2, city, county, email, phone, courseId);
            addStu.AddStudentToDb();

            CancelItems();

            MessageBox.Show("Student added to database");

            
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

       public void Validation(string re, TextBox txt, Label lbl)
        {

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

        private void cboAddCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

            cboAddCourse.DisplayMember = "CourseTitle";
            cboAddCourse.ValueMember = "CourseId";
            
        }
    }
}
