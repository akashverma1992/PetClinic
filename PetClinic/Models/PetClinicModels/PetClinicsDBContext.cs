using System.Data.Entity;

namespace PetClinic.Models.PetClinicModels {
    public class PetClinicsDBContext : DbContext {

        public PetClinicsDBContext() : base("name=PetClinicConnection") {

        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
