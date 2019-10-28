using StudentInformation.DAL;
using StudentInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformation.BLL
{
    public class StudentManager
    {
        StudentHandler handlerStudent = new StudentHandler();
        public string studentInfoSaver(Students student)
        {
            bool checkData = handlerStudent.saveStudent(student);
            if(checkData==true)
            {
                return "Saved successfully";
            }
            else
            {
               return  "Error occured";
            }
          
        }

        public List<Students> viewStudents()
        {
          return  handlerStudent.viewStudent();

        }
    }
}