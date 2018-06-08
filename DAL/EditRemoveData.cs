using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EditRemoveData:DAO
    {
        public void EditStudent()
        {
            SqlCommand cmd = new SqlCommand("uspEditStudent", OpenCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            CloseCon();

        }

        public void DeleteStudent()
        {
            SqlCommand cmd = new SqlCommand("uspDeleteStudent", OpenCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            CloseCon();
        }
    }
}
