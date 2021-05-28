using MVCDemoo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            EmployeeDatabaseEntities1 db = new EmployeeDatabaseEntities1();
            Employee employee = db.Employees.SingleOrDefault(x => x.EmployeeId == 1);
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            employeeVM.EmployeeId = employee.EmployeeId;
            employeeVM.DepartmentId = employee.DepartmentId;
            employeeVM.Name = employee.Name;
            employeeVM.Gender = employee.Gender;
            employeeVM.City = employee.City;
            return View(employeeVM);
        }
    }
}