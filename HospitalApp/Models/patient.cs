using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HospitalApp.Models
{
    internal class patient
    {    


        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public ICollection<Doctor> Doctors { get; set; }    = new List<Doctor>();
        public registry Registry { get; set; }



    }
}
