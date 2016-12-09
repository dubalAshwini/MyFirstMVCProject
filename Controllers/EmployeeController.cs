using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myFirstMVCProject.Models;

namespace myFirstMVCProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details(int id)
        {
            //Employee Employee = new Models.Employee()
            //{
            //    EmployeeId = 101,
            //    Name = "Ashwini",
            //    Gender = "Female",
            //    City = "Melbourne"
            //};
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);
            return View(employee);
        }
    }
}