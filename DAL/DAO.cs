using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class DAO
    {
        private SqlConnection con;

        public DAO()
        {
            // ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString
            // "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\charl\OneDrive\Documents\AdvancedProgramming\AdvancedProgCA\AdancedProgrammingCA\AdancedProgrammingCA\Database.mdf;Integrated Security=True" providerName="System.Data.SqlClient
            con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\charl\OneDrive\Documents\AdvancedProgramming\AdvancedProgCA\AdancedProgrammingCA\AdancedProgrammingCA\Database.mdf; Integrated Security = True");
        }

        public SqlConnection OpenCon()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.Open();
            }
            return con;
        }

        public void CloseCon()
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
    
}
