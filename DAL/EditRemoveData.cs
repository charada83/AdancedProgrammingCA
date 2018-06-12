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
        public void EditStudent(int studentId, string email, string phone, string address1,string address2, string city, string county)
        {
            SqlCommand cmd = new SqlCommand("uspEditStudent", OpenCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("StudentId", studentId);
            cmd.Parameters.AddWithValue("Email", email);
            cmd.Parameters.AddWithValue("Phone", phone);
            cmd.Parameters.AddWithValue("AddressLine1", address1);
            cmd.Parameters.AddWithValue("AddressLine2", address2);
            cmd.Parameters.AddWithValue("City", city);
            cmd.Parameters.AddWithValue("County", county);

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
