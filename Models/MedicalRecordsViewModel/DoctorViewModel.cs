using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalRecords.Models.MedicalRecordsViewModel
{
    public class DoctorViewModel
    {
        public int id_d { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool sex { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public Nullable<decimal> phone { get; set; }
        public string specialization { get; set; }
        public Nullable<int> age { get; set; }
        public List<Diagnose> diagnoses { get; set; }
    }
}