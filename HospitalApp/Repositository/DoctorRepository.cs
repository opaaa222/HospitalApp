using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalApp.Repositository
{
    internal class DoctorRepository
    {
        private readonly Data.hospitalDbContext _context;

        public DoctorRepository(Data.hospitalDbContext context)
        {
            _context = context;
        }


        public ICollection<Models.Doctor> GetAllDoctors()
        {
            return _context.Doctors.ToList();
        }

        public void addDoctor(Models.Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }



    }
}
