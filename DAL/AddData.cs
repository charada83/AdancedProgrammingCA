using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class AddData:DAO
    {
        public void AddStaff(string staffName, string staffPass, string staffFullname)
        {
            Random r = new Random();
            SqlCommand cmd = new SqlCommand("INSERT INTO DBSStaff (UserName,Salt,Password,FullName) VALUES (@uname,@salt,@pass,@fullname)", OpenCon());
            cmd.Parameters.AddWithValue("@uname", staffName);
            cmd.Parameters.AddWithValue("@salt", r.Next());
            cmd.Parameters.AddWithValue("@pass", staffPass);
            cmd.Parameters.AddWithValue("@fullname", staffFullname);
            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void AddNewStudent(string FirstName, string LastName, string AddressLine1, string AddressLine2, string City, string County, string Email, string Phone)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Customer (FirstName,LastName, AddressLine1, AddressLine2, City, County, Email, Phone) " +
                "VALUES (@fname, @lname, @address1, @address2, @city, @county, @email, @phone)", OpenCon());
            cmd.Parameters.AddWithValue("@fname", FirstName);
            cmd.Parameters.AddWithValue("@lname", LastName);
            cmd.Parameters.AddWithValue("@address1", AddressLine1);
            cmd.Parameters.AddWithValue("@address2", AddressLine2);
            cmd.Parameters.AddWithValue("@city", City);
            cmd.Parameters.AddWithValue("@county", County);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@phone", Phone);
            cmd.ExecuteNonQuery();
            CloseCon();
        }
    }
}
