namespace PetClinic.Migrations {
    using PetClinic.Models.PetClinicModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PetClinic.Models.PetClinicModels.PetClinicsDBContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PetClinic.Models.PetClinicModels.PetClinicsDBContext context) {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Rooms.AddOrUpdate(i => i.RoomID,
                new Room {
                    RoomID = 1,
                    RoomNumber = 101
                },
                new Room {
                    RoomID = 2,
                    RoomNumber = 102
                },
                new Room {
                    RoomID = 3,
                    RoomNumber = 103
                });

            context.Doctors.AddOrUpdate(i => i.DoctorID,
                new Doctor {
                    DoctorID = 110,
                    DoctorName = "Dr.Abhinav"
                },
                new Doctor {
                    DoctorID = 120,
                    DoctorName = "Dr.Shivam"
                },
                new Doctor {
                    DoctorID = 130,
                    DoctorName = "Dr.Akshay"
                });

            context.Clients.AddOrUpdate<Client>(i => i.ClientID,
                new Client {
                    ClientID = 1,
                    ClientName = "Aakash Verma"
                },
                new Client {
                    ClientID = 2,
                    ClientName = "Shruti Bhalla"
                },
                new Client {
                    ClientID = 3,
                    ClientName = "Ajay Biswas"
                });
        }
    }
}
