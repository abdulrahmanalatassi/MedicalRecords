//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCTutorial2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MVCEmployee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        public Nullable<int> DepartmentDepartmentId { get; set; }
    
        public virtual Department Department { get; set; }
    }
}