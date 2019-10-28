using StudentInformation.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentInformation.DAL
{
    public class StudentHandler
    {
        public bool saveStudent(Students student)
        {
            string connectionString = @"Server = DESKTOP-LH38MQH;Database = StudentInformationDB;Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            string insertQuery = "INSERT INTO studentTable(StudentName,RegNo,Email,Age,MobileNo,Address) VALUES ('" + student.StudentName + "','" + student.StudentEmail + "','" + student.StudentRegNo + "','" + student.StudentPhoneNo + "','" + student.StudentAddress + "'," + student.StudentAge + ");";
            SqlCommand command = new SqlCommand(insertQuery, connection);
            connection.Open();
            int isinsert = command.ExecuteNonQuery();
            connection.Close();
            if (isinsert > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }

        public List<Students> viewStudent()
        {
            List<Students> studentList = new List<Students>();
            string connectionString = @"Server = DESKTOP-LH38MQH;Database = StudentInformationDB;Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            string selectQuery = "SELECT * FROM studentTable";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            connection.Open();
            SqlDataReader studentReader = command.ExecuteReader();
                
            while(studentReader.Read())
            {
                int id = (int)studentReader["id"];
                string name = (string)studentReader["StudentName"].ToString();
                string regNo = (string)studentReader["RegNo"].ToString();
                string email = (string)studentReader["Email"].ToString();
                string mobileNo = (string)studentReader["MobileNo"].ToString();
                int age = (int)studentReader["Age"];
                string address = (string)studentReader["Address"].ToString();
                Students student = new Students(name, regNo, email, mobileNo, age, address);
                student.StudentId = id;
                studentList.Add(student);
            }
            studentReader.Close();
            return studentList;
        }
    }
}