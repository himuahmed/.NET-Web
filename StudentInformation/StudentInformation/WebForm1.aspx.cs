using StudentInformation.BLL;
using StudentInformation.DAL;
using StudentInformation.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInformation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name = studentName.Value;
            string email = studentEmail.Value;
            string regNo = studentRegNo.Value;
            string phoneNo = studentPhoneNo.Value;
            string address = studentAddress.Value;
            int age = Int32.Parse(studentAge.Value);
            Students student = new Students(name, email, regNo, phoneNo, age, address);
            //string insertQuery = "INSERT INTO studentTable(StudentName,RegNo,Email,Age,MobileNo,Address) VALUES ('" + student.StudentName + "','" + student.StudentEmail + "','" + student.StudentRegNo + "','" + student.StudentPhoneNo + "','" + student.StudentAddress + "'," + student.StudentAge + ")";
            StudentManager aStudent = new StudentManager();
            saveLabel.Text = aStudent.studentInfoSaver(student);
            studentGridView.DataSource = aStudent.viewStudents();
            studentGridView.DataBind();

        }

    }
}