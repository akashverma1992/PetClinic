namespace PetClinic.Models.PetClinicModels {
    public class Client
    {
        public int ID { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public string AppointmentNumber { get; set; }
    }
}