using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemoo.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public Nullable<int> DepartmentId { get; set; }
    }
}