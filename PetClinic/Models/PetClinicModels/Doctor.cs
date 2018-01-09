using System.ComponentModel.DataAnnotations;

namespace PetClinic.Models.PetClinicModels {
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
    }
}
