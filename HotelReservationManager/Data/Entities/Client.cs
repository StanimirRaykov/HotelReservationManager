namespace HotelReservationManager.Data.Entities
{
    public class Client : BaseEntity
    {
        public Client() 
        {

        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public bool IsAdult { get; set; }

        public virtual Reservation Reservation { get; set; }

        public virtual Room Room { get; set; }

    }
}
