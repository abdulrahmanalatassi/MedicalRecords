using MVCTutorial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            MVCTurtorialEntities db = new MVCTurtorialEntities();
            Employee employee = new Employee();

            EmployeeViewModel vm = new EmployeeViewModel();


            vm.EmployeeId = employee.EmployeeId;
            vm.DepartmentId = employee.DepartmentId;
            vm.Name = employee.Name;
            vm.Address = employee.Address;
           // List<Employee> employeelist = db.Employees.ToList();

            return View();
        }


        
    }
}