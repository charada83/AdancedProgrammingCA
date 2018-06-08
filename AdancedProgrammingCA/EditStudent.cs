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
        public EditStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
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
    }
}
