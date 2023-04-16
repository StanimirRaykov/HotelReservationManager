using HotelReservationManager.Models.Reservation.Response;
using HotelReservationManager.Models.Room.Response;

namespace HotelReservationManager.Models.Client.Response
{
    public class ClientResponseDTO : BaseResponseDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public bool IsAdult { get; set; }
        public RoomPairResponseDTO Room { get; set; }

        public ReservationPairResponseDTO Reservation { get; set; }
    }
}
