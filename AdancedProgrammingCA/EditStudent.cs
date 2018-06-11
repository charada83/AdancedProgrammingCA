using BAL.Enums;
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

namespace AdancedProgrammingCA
{
    public partial class EditStudent : FormMenu
    {
        ShowData sd = new ShowData();
        EditRemoveData edit = new EditRemoveData();

        public EditStudent(Dictionary<String, String> student)
        {
            InitializeComponent();
            cboEditCounty.DataSource = Enum.GetValues(typeof(Counties));
            txtEditFname.Text = student["FirstName"];
            txtEditSname.Text = student["LastName"];
            txtEditEmail.Text = student["Email"];
            txtEditPhone.Text = student["Phone"];
            txtEditAddress1.Text = student["AddressLine1"];
            txtEditAddress2.Text = student["AddressLine2"];
            txtEditCity.Text = student["City"];
            cboEditCounty.SelectedItem = Enum.Parse(typeof(Counties), student["County"]);

        }


        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            CancelItems();
        }

        public void CancelItems()
        {
            txtEditFname.Clear();
            txtEditSname.Clear();
            txtEditAddress1.Clear();
            txtEditAddress2.Clear();
            txtEditCity.Clear();
            cboEditCounty.SelectedItem = "";
            txtEditEmail.Clear();
            txtEditPhone.Clear();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            txtEditFname.Enabled = false;
            txtEditSname.Enabled = false;
            grpCourseDetails.Enabled = false;
            
        }

        private void btnEditStudent_Click_1(object sender, EventArgs e)
        {
            edit.EditStudent();

        }
    }
}
