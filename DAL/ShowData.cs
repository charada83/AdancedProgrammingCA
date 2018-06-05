using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShowData:DAO
    {
        DataTable dt = new DataTable();

        public DataTable ShowStudents()
        {
            SqlCommand cmd = new SqlCommand("uspGetAllStudents", OpenCon());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }

        public DataTable GetCourses()
        {
            SqlCommand cmd = new SqlCommand("uspGetAllCourses", OpenCon());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }


    }
}
