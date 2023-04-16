namespace HotelReservationManager.Models.Client.Request
{
    public class ClientRequestDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public bool IsAdult { get; set; }
    }
}
