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
    
    public partial class Equipment
    {
        public int id_e { get; set; }
        public string name { get; set; }
        public bool available { get; set; }
        public int id_h { get; set; }
    
        public virtual Hospital Hospital { get; set; }
    }
}
