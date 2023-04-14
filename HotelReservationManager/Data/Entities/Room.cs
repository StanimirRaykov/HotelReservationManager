namespace HotelReservationManager.Data.Entities
{
    public class Room : BaseEntity
    {
        public Room() 
        {

        }
        public int Size { get; set; }
        public string Type { get; set; }
        public bool Free { get; set; }
        public double AdultPrice { get; set; }
        public double ChildPrice { get; set; }

        public int RoomNumber { get; set; }
    }
}
