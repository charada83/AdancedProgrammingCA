using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ShowData:DAO
    {
        DataTable dt = new DataTable();

        public DataTable ShowStudents()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Students", OpenCon());
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
    }
}
