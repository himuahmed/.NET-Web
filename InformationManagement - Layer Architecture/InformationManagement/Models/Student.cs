using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationManagement.Models
{
    public class Student
    {
   
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string RegNo { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNo { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }

        public Student()
        {

        }
        public Student(string studentName,string regNo,string emailAddress,string mobileNo,int age,string address)
        {
           StudentName = studentName;
           RegNo = regNo;
           EmailAddress = emailAddress;
           MobileNo = mobileNo;
           Age = age;
           Address = address;

        }

    }
}