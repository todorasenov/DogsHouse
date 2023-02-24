using Microsoft.AspNetCore.Identity;

namespace toshko12d.Data
{
    public class Client:IdentityUser
    {
        public string Family { get; set; }

        public DateTime RegisterOn { get; set; }
        //1:m
        public ICollection<Reservation> Reservations { get; set; }

    }
}
