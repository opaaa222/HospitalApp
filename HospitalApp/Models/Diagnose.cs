using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalApp.Models
{
    internal class Diagnose
    {
        public int Id { get; set; } 
        public string Description { get; set; }
        public  int RegistryId { get; set; }
        public registry Registry { get; set; }


    }
}
