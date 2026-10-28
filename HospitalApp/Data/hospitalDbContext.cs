using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalApp.Data
{
    internal class hospitalDbContext : DbContext
    {
        public DbSet<Models.Doctor> Doctors { get; set; }
        public DbSet<Models.patient> Patients { get; set; }
        public DbSet<Models.registry> Registries { get; set; }
        public DbSet<Models.Diagnose> Diagnoses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-QV3K8PJ\\SQLEXPRESS;Database=HospitalDb;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }









    }
}
