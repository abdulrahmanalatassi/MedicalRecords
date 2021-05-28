using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            MVCTurtorialEntities db = new MVCTurtorialEntities();
            Employee employee = new Employee();

            EmployeeViewModel employeeVM = new EmployeeViewModel();
            employeeVM.EmployeeId = employee.EmployeeId;
            employeeVM.Name = employee.Name;
            employeeVM.DepartmentId = employee.DepartmentId;
            employeeVM.Address = employee.Address;
            return View(employeeVM);
        }
    }
}