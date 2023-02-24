namespace toshko12d.Data
{
    public class Breed
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime RegisterOn { get; set; }
		//1:m
		public ICollection<Dog> Dogs { get; set; }
	}
}
