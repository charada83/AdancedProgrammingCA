using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class CheckLogin : DAO
    {
        public string[] CheckUser(string user)
        {
            SqlDataReader dr = null;

            SqlCommand cmd = new SqlCommand("SELECT * FROM DBSStaff WHERE UserName=@uname", OpenCon());
            cmd.Parameters.AddWithValue("@uname", user);

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string[] ret = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ret[i] = "" + dr[i];
                }
                return ret;
            }
            else
            {
                return null;
            }
        }
    }
}
