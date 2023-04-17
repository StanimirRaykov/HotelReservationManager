using HotelReservationManager.Data.Entities;
using HotelReservationManager.Models.Client.Request;
using HotelReservationManager.Models.User.Request;

namespace HotelReservationManager.Models.Reservation.Request
{
    public class ReservationRequestDTO
    {
        public int RoomId { get; set; }
        public int UserId { get; set; }

        public IEnumerable<ClientRequestDTO> Clients { get; set; }

        public DateTime DateOfAccommodation { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool BreakfastIncluded { get; set; }

        public bool AllInclusiveIncluded { get; set; }

        public double OwedAmount { get; set; }
    }
}
