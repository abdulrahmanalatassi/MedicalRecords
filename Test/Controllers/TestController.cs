using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            EmployeeDatabaseEntities db = new EmployeeDatabaseEntities();
            Employee employeeVM = db.Employees.SingleOrDefault(x => x.EmployeeId==1);

            EmployeeViewModel vm = new EmployeeViewModel();

            vm.EmployeeId = employeeVM.EmployeeId;
            vm.Departmentd = employeeVM.Departmentd;
            vm.Name = employeeVM.Name;
            vm.Gender = employeeVM.Gender;
            vm.City = employeeVM.City;

            return View(employeeVM);
        }
    }
}