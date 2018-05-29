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
        public ShowStudents()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Student", dao.OpenCon());
            SqlDataReader dr = cmd.ExecuteReader();

            //Add Datagrid to Show Students
            while (dr.Read())
            {
                ListViewItem stu = new ListViewItem(dr["StudentId"].ToString());
                stu.SubItems.Add(dr["FirstName" + "LastName"].ToString());
                stu.SubItems.Add(dr["AddressLine1" + "AddressLine2" + "City" + "County"].ToString());
                
                //myList.Items.Add(stu);
            }
            dao.CloseCon();
        }
    }
}
