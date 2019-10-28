using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using InformationManagement.Models;
using InformationManagement.Models.ViewModels;

namespace InformationManagement.DAL
{
    public class StudentGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["IMDB"].ConnectionString;
        
        public bool SaveStudent(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO " +
                           "Student_tbl(StudentName, RegNo," +
                           " Email, MobileNo, Age, Address, DepartmentId)" +
                           "VALUES('" + student.StudentName + "','" + student.RegNo + "'," +
                           "'" + student.EmailAddress + "','" + student.MobileNo + "'," +
                           "" + student.Age + ",'" + student.Address + "',"+ student.DepartmentId+")";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();

            if (rowEffect > 0)
                return true;
            return false;
        }

        public Student GetExistStudent(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Student_tbl WHERE RegNo = '" + student.RegNo +"'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            Student aStudent = null;
            while (reader.Read())
            {
                aStudent = new Student();
                aStudent.StudentId = Convert.ToInt32(reader["StudentId"]);
                aStudent.StudentName = reader["StudentName"].ToString();
                aStudent.RegNo = reader["RegNo"].ToString();
                aStudent.Address = reader["Address"].ToString();
                aStudent.MobileNo = reader["MobileNo"].ToString();
                aStudent.Age = Int32.Parse(reader["Age"].ToString());
                aStudent.EmailAddress = reader["Email"].ToString();
            }
            reader.Close();
            connection.Close();

            return aStudent;
        }

        public List<DepartmentWiseStudentViewModel> GetAllStudent()
        {
            List<DepartmentWiseStudentViewModel> studentList = new List<DepartmentWiseStudentViewModel>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM DepartmentWiseStudent";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                DepartmentWiseStudentViewModel st  = new DepartmentWiseStudentViewModel();
                st.StudentName = reader["StudentName"].ToString();
                st.Email = reader["Email"].ToString();
                st.RegNo = reader["RegNo"].ToString();
                st.Address = reader["Address"].ToString();
                st.Age = Convert.ToInt32(reader["Age"]);
                st.MobileNo = reader["MobileNo"].ToString();
                st.Department = reader["Department"].ToString();
                st.Code = reader["Code"].ToString();

                studentList.Add(st);
            }


            reader.Close();
            connection.Close();

            return studentList;
        }

        public bool UpdateStudent(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"UPDATE Student_tbl SET StudentName = '"+student.StudentName+"', Email = '"+student.EmailAddress+"', MobileNo = '"+student.MobileNo+"', Address = '"+student.Address+"', Age = "+student.Age+"WHERE RegNo = '"+student.RegNo+"';";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();

            if (rowEffect > 0)
                return true;
            return false;
        }

        public bool DeleteStudent(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"DELETE FROM Student_tbl WHERE RegNo = '"+student.RegNo+"';";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();

            if (rowEffect > 0)
                return true;
            return false;
        }
    }
}