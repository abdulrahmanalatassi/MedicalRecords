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
    
    public partial class Attachment
    {
        public int id_dig { get; set; }
        public string attachment1 { get; set; }
    
        public virtual Diagnose Diagnose { get; set; }
    }
}
