using System.ComponentModel.DataAnnotations.Schema;

namespace toshko12d.Data
{
    public class Reservation
    {
        public int Id { get; set; }

        public DateTime DateOn { get; set; }

        public DateTime DateReturn { get; set; }
        public string DogName { get; set; }
        public string DogBreed { get; set; }

        public int CellNumber { get; set; }

        public int ServiceId { get; set; }
        public Service Services { get; set; }

        public string ClientId { get; set; }

        public Client Clients { get; set; }
        public DateTime RegisterOn { get; set; }
    }
}
