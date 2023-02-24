namespace toshko12d.Data
{
    public class Dog
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int BreedId { get; set; }
        public Breed Breds { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public bool Status { get; set; }

        public DateTime RegisterOn { get; set; }

		//1:m
		public ICollection<Reservation> Reservations { get; set; }
		
    }
}
