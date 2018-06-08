using BAL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdancedProgrammingCA
{
    public partial class ShowStudents : FormMenu
    {

        public ShowStudents()
        {
            InitializeComponent();

        }

        private void ShowStudents_Load(object sender, EventArgs e)
        {
            ShowData sd = new ShowData();
            dgvStudents.DataSource = sd.ShowStudents();
                   
        }

        //private AddNewStudent GetSelectedStudent()
        //{
        //    AddNewStudent student = null;
        //    int studentId;
        //    int columnIndex = 0;
        //    int rowIndex = 0;
        //    if (dgvStudents.SelectedRows.Count > 0)
        //    {
        //        rowIndex = dgvStudents.SelectedRows[0].Index;
        //        studentId = (int)dgvStudents.Rows[rowIndex].Cells[columnIndex].Value;
        //    }

        //}
    }
}
