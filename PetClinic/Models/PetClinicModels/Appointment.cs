using System;
using System.ComponentModel.DataAnnotations;

namespace PetClinic.Models.PetClinicModels {
    public class Appointment {
        public int ID { get; set; }
        public string ClientName { get; set; }
        public string DoctorName { get; set; }

        [Display(Name = "Appointment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public int RoomNumber { get; set; }
        public string AppointmentID { get; set; }
    }

    //public class Appointment {
    //    public int Id { get; set; }
    //    public Guid AppointmentId { get; set; }
    //    public int DoctorId { get; set; }
    //    public int RoomId  { get; set; }
    //    public DateTime Date { get; set; }
    //    public string ClientName { get; set; }
    //}
}
