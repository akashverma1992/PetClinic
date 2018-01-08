namespace PetClinic.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PetClinic.Models.PetClinicModels;

    internal sealed class Configuration : DbMigrationsConfiguration<PetClinic.Models.PetClinicModels.PetClinicDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PetClinic.Models.PetClinicModels.PetClinicDBContext";
        }

        protected override void Seed(PetClinic.Models.PetClinicModels.PetClinicDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Appointments.AddOrUpdate(i => i.ID,
                new Appointment {
                    ClientName = "Aakash Verma",
                    DoctorName = "Dr. Abhinav",
                    Date = DateTime.Parse("2018-02-11"),
                    RoomNumber = 202,
                    AppointmentID = "AakashVerma-202-2018-02-11"
                }
            );

            context.Clients.AddOrUpdate(i => i.ID,
                new Client {
                    ClientName = "Aakash Verma",
                    Address = "Delhi",
                    Age = 25,
                    AppointmentNumber = "AakashVerma-202-2018-02-11"
                }
            );

            context.Doctors.AddOrUpdate(i => i.ID,
                new Doctor {
                    DoctorName = "Dr.Abhinav",
                    RoomNumber = 302,
                    Speciality = "Eyes"
                },
                new Doctor {
                    DoctorName = "Dr.Shivam",
                    RoomNumber = 102,
                    Speciality = "Skin"
                },
                new Doctor {
                    DoctorName = "Dr.Keshav",
                    RoomNumber = 202,
                    Speciality = "Bones"
                });
        }
    }
}
