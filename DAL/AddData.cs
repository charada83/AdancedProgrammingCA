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
        public void AddStaff(string staffFirstname, string staffSurname, string staffUsername, string staffPass)
        {
            
            SqlCommand cmd = new SqlCommand("INSERT INTO DBSStaff (Firstname, Surname, UserName,Password) VALUES (@fname, @sname, @uname,@pass)", OpenCon());
            cmd.Parameters.AddWithValue("@fname", staffFirstname);
            cmd.Parameters.AddWithValue("@sname", staffSurname);
            cmd.Parameters.AddWithValue("@uname", staffUsername);
            cmd.Parameters.AddWithValue("@pass", staffPass);
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
