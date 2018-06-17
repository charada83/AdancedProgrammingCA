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
        ShowData sd = new ShowData();

        public ShowStudents()
        {
            InitializeComponent();

        }

        public int GetCurrentStudentId()
        {
            return (int)dgvStudents.CurrentRow.Cells[0].Value;
        }

        public void RefreshGrid()
        {
    
            dgvStudents.DataSource = sd.ShowStudents();
            
        }

        private void ShowStudents_Load(object sender, EventArgs e)
        {
            
            Program.GRID = dgvStudents;
            Program.SHOW_STUDENTS = this;
            this.RefreshGrid();

        }

    }
}
