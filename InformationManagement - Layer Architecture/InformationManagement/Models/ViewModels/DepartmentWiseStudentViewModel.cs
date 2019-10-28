using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationManagement.Models.ViewModels
{
    public class DepartmentWiseStudentViewModel
    {
        public string StudentName { get; set; }
        public string RegNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Code { get; set; }


    }
}