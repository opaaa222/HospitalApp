using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalApp.Models.DTOs
{
    internal class CreateDoctorDTO
    {
        public string Name { get; set; }    
        public string Specialization { get; set; }
        public int RoomId { get; set; }



    }
}
