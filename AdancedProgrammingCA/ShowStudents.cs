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
        DAO dao = new DAO();
        ShowData sd = new ShowData();
        public ShowStudents()
        {
            InitializeComponent();

        }

        private void ShowStudents_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = sd.ShowStudents();
            dgvStudents.DataSource = dt;    
        }
    }
}
