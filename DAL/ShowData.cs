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

        // public static System.Windows.Forms.DataGridView GRID { get; set; }

        public DataTable ShowStudents()
        {
            SqlCommand cmd = new SqlCommand("uspGetAllStudents", OpenCon());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Clear();
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

        public int GetCourseID(string level, string courseTitle)
        {
            return 2;
        }

        public Dictionary<String, String> GetStudentDataById(int studentId)
        {
            SqlCommand cmd = new SqlCommand("uspGetStudentById", OpenCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@studentId", studentId);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();

            Dictionary<String, String> student = new Dictionary<String, String>();

            student.Add("StudentId", rd[0].ToString());
            student.Add("FirstName", rd[1].ToString());
            student.Add("LastName", rd[2].ToString());
            student.Add("Email", rd[3].ToString());
            student.Add("Phone", rd[4].ToString());
            student.Add("AddressLine1", rd[5].ToString());
            student.Add("AddressLine2", rd[6].ToString());
            student.Add("City", rd[7].ToString());
            student.Add("County", rd[8].ToString());
            CloseCon();
            return student;
            
        }

    }
}
