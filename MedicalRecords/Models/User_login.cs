//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicalRecords.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_login
    {
        public string username { get; set; }
        public string password { get; set; }
        public Nullable<int> flag { get; set; }
        public Nullable<int> id_d { get; set; }
    
        public virtual Doctor Doctor { get; set; }
    }
}
