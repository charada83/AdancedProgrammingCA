using System;
using System.Collections.Generic;
using System.Data;
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
            
            SqlCommand cmd = new SqlCommand("INSERT INTO DBSStaff (Firstname, Surname, Username,Password) VALUES (@fname, @sname, @uname,@pass)", OpenCon());
            cmd.Parameters.AddWithValue("@fname", staffFirstname);
            cmd.Parameters.AddWithValue("@sname", staffSurname);
            cmd.Parameters.AddWithValue("@uname", staffUsername);
            cmd.Parameters.AddWithValue("@pass", staffPass);
            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void AddNewStudent(string FirstName, string LastName, string Email, string Phone, string AddressLine1, string AddressLine2, string City, string County, int CourseId)
        {
            SqlCommand cmd = new SqlCommand("uspAddStudent", OpenCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@AddressLine1", AddressLine1);
            cmd.Parameters.AddWithValue("@AddressLine2", AddressLine2);
            cmd.Parameters.AddWithValue("@City", City);
            cmd.Parameters.AddWithValue("@County", County);
            cmd.Parameters.AddWithValue("@CourseId", CourseId);
      
            cmd.Parameters.AddWithValue("@StudentId", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();

            string id = cmd.Parameters["@StudentId"].ToString();
            CloseCon();
        }   

        
    }
}
