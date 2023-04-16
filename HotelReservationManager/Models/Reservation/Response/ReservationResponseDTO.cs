using HotelReservationManager.Data.Entities;
using HotelReservationManager.Models.Client.Request;
using HotelReservationManager.Models.Client.Response;
using HotelReservationManager.Models.Room.Response;
using HotelReservationManager.Models.User.Request;

namespace HotelReservationManager.Models.Reservation.Response
{
    public class ReservationResponseDTO : BaseResponseDTO
    {
        public int RoomId { get; set; }
        public UserRequestDTO user { get; set; }

        public IEnumerable<ClientRequestDTO> Clients { get; set; }

        public DateTime DateOfAccommodation { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool BreakfastIncluded { get; set; }

        public bool AllInclusiveIncluded { get; set; }

        public double OwedAmount { get; set; }

        public RoomPairResponseDTO Room { get; set; }

        public ClientPairResponseDTO Client { get; set; }
    }
}
