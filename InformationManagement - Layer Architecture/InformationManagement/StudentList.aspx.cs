using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InformationManagement.BLL;
using InformationManagement.Models;

namespace InformationManagement
{
    public partial class StudentList : System.Web.UI.Page
    {
        StudentManager aManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowAllStudentInfo();
        }

        private void ShowAllStudentInfo()
        {
            StudentGrirdView.DataSource = aManager.GetAllStudent(); ;
            StudentGrirdView.DataBind();
        }
    }
}