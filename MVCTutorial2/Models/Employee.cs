using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial2.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string Address { get; set; }


        public virtual Department Department { get; set; }

    }
}