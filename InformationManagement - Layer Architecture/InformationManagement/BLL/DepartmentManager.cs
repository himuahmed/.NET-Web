using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InformationManagement.DAL;
using InformationManagement.Models;

namespace InformationManagement.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway gateway = new DepartmentGateway();
        public List<Department> GetAllDepartment()
        {
           return gateway.GetAllDepartmentFromDB();
        }
    }
}