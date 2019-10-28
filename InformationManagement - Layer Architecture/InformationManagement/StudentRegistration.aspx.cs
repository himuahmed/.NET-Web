using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InformationManagement.BLL;
using InformationManagement.Models;

namespace InformationManagement
{
    public partial class StudentInfoUi : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        DepartmentManager departmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDropDownDepartment();
            }
            
        }

        private void BindDropDownDepartment()
        {

            ddlDepartment.DataTextField = "Name";
            ddlDepartment.DataValueField = "DepartmentId";
            ddlDepartment.DataSource = departmentManager.GetAllDepartment();
            ddlDepartment.DataBind();
        }


        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name = inputStudentName.Value;
            string regNo = inputRegNo.Value;
            string email = inputEmailAddress.Value;
            string mobileNo = inputMobileNo.Value;
            int age = Convert.ToInt32(inputAge.Value);
            string address = inputAddess.Value;
            int departmentId = Convert.ToInt32(ddlDepartment.SelectedValue);
            Student student = new Student(name, regNo, email, mobileNo, age, address);
            student.DepartmentId = departmentId;

            messageLabel.Text =  studentManager.SaveStudent(student);
        }

       

        
        protected void ClearField()
        {
            inputStudentName.Value=String.Empty;
            inputRegNo.Value=String.Empty;
            inputEmailAddress.Value=String.Empty;
            inputMobileNo.Value=String.Empty;
            inputAge.Value = String.Empty;
            inputAddess.Value=String.Empty;
        }

        protected void updateButton_OnClick(object sender, EventArgs e)
        {
            string name = inputStudentName.Value;
            string regNo = inputRegNo.Value;
            string email = inputEmailAddress.Value;
            string mobileNo = inputMobileNo.Value;
            int age = Convert.ToInt32(inputAge.Value);
            string address = inputAddess.Value;

            Student student = new Student(name, regNo,email,mobileNo,age,address);

           messageLabel.Text = studentManager.UpdateStudent(student);
        }

        protected void deleteButton_OnClick(object sender, EventArgs e)
        {
            string name = inputStudentName.Value;
            string regNo = inputRegNo.Value;
            string email = inputEmailAddress.Value;
            string mobileNo = inputMobileNo.Value;
            int age = Convert.ToInt32(inputAge.Value);
            string address = inputAddess.Value;
            Student student = new Student(name, regNo, email, mobileNo, age, address);

            messageLabel.Text = studentManager.DeleteStudent(student);
        }
    }
}