namespace HotelReservationManager.Data.Entities
{
    public class Room : BaseEntity
    {
        public Room() 
        {

        }
        public int Size { get; set; }
        public string Type { get; set; } //to do...
        public bool isTaken { get; set; }
        public double AdultPrice { get; set; }
        public double ChildPrice { get; set; }

        public int RoomNumber { get; set; }
        public virtual IEnumerable<Reservation> Reservations { get; set; }

        public virtual IEnumerable<Client> Clients { get; set; }    
    }
}
