using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Solid.Core.Entities;

namespace Solid.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Clinic_db");
            }
        }


        public DbSet<Appointment> AppointmentList { get; set; }
        public DbSet<Doctor> DoctorList { get; set; }
        public DbSet<Patient> PatientList { get; set; }
    }
}
