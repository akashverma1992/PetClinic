using System.ComponentModel.DataAnnotations;

namespace PetClinic.Models.PetClinicModels {
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        public string ClientName { get; set; }
    }
}