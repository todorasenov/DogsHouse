using System.ComponentModel.DataAnnotations.Schema;

namespace toshko12d.Data
{
    public class Reservation
    {
        public int Id { get; set; }

        public int DateOn { get; set; }

        public int DateReturn { get; set; }

        public int Days { get; set; }
        [Column(TypeName="decimal(10,2)")]

        public decimal Price { get; set; }

        public int CellNumber { get; set; }

        public string Description { get; set; }

        public DateTime RegisterOn { get; set; }
//m:1
        public int DogId { get; set; }
        
        public Dog Dogs { get; set; }

        //M:1

        public string ClientId { get; set; }

        public Client Clients { get; set; }
    }
}
