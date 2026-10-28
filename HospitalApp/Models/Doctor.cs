using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalApp.Models
{
    internal class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }

        public int RoomId { get; set; }
        public ICollection<patient> Patients { get; set; } = new List<patient>();


    }
}
