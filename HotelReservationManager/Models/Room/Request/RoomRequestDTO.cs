namespace HotelReservationManager.Models.Room.Request
{
    public class RoomRequestDTO
    {
        public int Size { get; set; }
        public string Type { get; set; } //to do...
        public bool isTaken { get; set; }
        public double AdultPrice { get; set; }
        public double ChildPrice { get; set; }

        public int RoomNumber { get; set; }
    }
}
