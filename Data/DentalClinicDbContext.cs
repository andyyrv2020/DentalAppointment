using DentalAppointment.Models;
using Microsoft.EntityFrameworkCore;

namespace DentalAppointment.Data
{
    public class DentalClinicDbContext : DbContext
    {
        public DentalClinicDbContext(DbContextOptions<DentalClinicDbContext> options) : base(options)
        {
        }

        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }

    }
}