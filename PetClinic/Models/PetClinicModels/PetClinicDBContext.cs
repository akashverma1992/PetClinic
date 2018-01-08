using System.Data.Entity;

namespace PetClinic.Models.PetClinicModels {
    public class PetClinicDBContext : DbContext {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
