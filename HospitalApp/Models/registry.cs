using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalApp.Models
{
    internal class registry
    {
        public int Id { get; set; }
        public DateTime OpenDate { get; set; }
        public int PatientId { get; set; }
        public patient Patient { get; set; }
        public ICollection<Diagnose> Diagnoses { get; set; } = new List<Diagnose>();


    }
}
