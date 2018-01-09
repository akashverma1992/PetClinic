using System.ComponentModel.DataAnnotations;

namespace PetClinic.Models.PetClinicModels {
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        public int RoomNumber { get; set; }
    }
}