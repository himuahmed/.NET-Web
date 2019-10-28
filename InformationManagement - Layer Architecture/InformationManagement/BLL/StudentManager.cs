using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InformationManagement.DAL;
using InformationManagement.Models;
using InformationManagement.Models.ViewModels;

namespace InformationManagement.BLL
{
    public class StudentManager
    {
        StudentGateway gateway = new StudentGateway();
        public string SaveStudent(Student student)
        {

            Student aStudent = gateway.GetExistStudent(student);
            if (aStudent != null)
            {
                return "Registration no already exists. Please enter unique reg no";
            }

            bool isSaved = gateway.SaveStudent(student);

            if (isSaved)
            {
                return "Student saved successfully";
            }
            else
            {
                return "Save failed";
            }
        }

        public List<DepartmentWiseStudentViewModel> GetAllStudent()
        {
            return gateway.GetAllStudent();
        }

        public string UpdateStudent(Student student)
        {
            Student aStudent =  gateway.GetExistStudent(student);

            if (aStudent != null)
            {
                bool isUpdated = gateway.UpdateStudent(student);
                if (isUpdated)
                {
                    return "Update Successfull";
                }
                else
                {
                    return "Failed";
                }
            }
            else
            {
                return "Student does not exists";
            }
        }

        public string DeleteStudent(Student student)
        {
            Student aStudent = gateway.GetExistStudent(student);

            if (aStudent != null)
            {
                bool isDeleted = gateway.DeleteStudent(student);
                if (isDeleted)
                {
                    return "Delete Successfull";
                }
                else
                {
                    return "Failed";
                }
            }
            else
            {
                return "Student does not exists";
            }
        }
    }
}