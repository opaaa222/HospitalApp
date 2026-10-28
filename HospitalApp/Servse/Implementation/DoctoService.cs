using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalApp.Servse.Implementation
{
    internal class DoctoService
    {
        private readonly Repositository.DoctorRepository _doctorRepository;
        public DoctoService(Repositository.DoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public ICollection<Models.Doctor> GetAllDoctors()
        {   
            var doctors = _doctorRepository.GetAllDoctors();
            if (doctors == null || doctors.Count == 0)
            {
                throw new Exception("No doctors found.");
            }


            return doctors;
        }


        public void AddDoctor(Models.DTOs.CreateDoctorDTO doctorDTO)
        {
            if (doctorDTO == null)
            {
                throw new ArgumentNullException(nameof(doctorDTO), "Doctor data cannot be null.");
            }
            var doctor = new Models.Doctor
            {
                Name = doctorDTO.Name,
                Specialization = doctorDTO.Specialization,
                RoomId = doctorDTO.RoomId
            };
            _doctorRepository.addDoctor(doctor);
        }



    }
}
