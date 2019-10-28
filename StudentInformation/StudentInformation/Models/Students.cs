using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformation.Models
{
    public class Students
    {
        public int StudentId { set; get; }
        public string StudentName { set; get; }
        public string StudentEmail { set; get; }
        public string StudentRegNo { set; get; }
        public string StudentPhoneNo { set; get; }
        public int StudentAge { set; get; }
        public string StudentAddress { set; get; }



        public Students(string studentName, string studentEmail, string studentRegNo, string studentPhoneNo, int studentAge, string studentAddress): this()
        {
            StudentName = studentName;
            StudentEmail = studentEmail;
            StudentRegNo = studentRegNo;
            StudentPhoneNo = studentPhoneNo;
            StudentAge = studentAge;
            StudentAddress = studentAddress;
        }
        public Students()
        {
        }

        




    }
}