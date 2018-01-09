using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetClinic.Models.PetClinicModels {
    public class Appointment {
        [Key]
        public int AppointmentID { get; set; }
        [Display(Name = "Appointment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public int DoctorID { get; set; }
        public int ClientID { get; set; }
        public int RoomID { get; set; }

        [ForeignKey("DoctorID")]
        public virtual Doctor Doctor { get; set; }
        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }
        [ForeignKey("RoomID")]
        public virtual Room Room { get; set; }
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
