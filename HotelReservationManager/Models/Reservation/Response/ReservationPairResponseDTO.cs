using HotelReservationManager.Data.Entities;
using HotelReservationManager.Models.User.Request;

namespace HotelReservationManager.Models.Reservation.Response
{
    public class ReservationPairResponseDTO
    {
        public int ReservationId { get; set; }
        public int UserId { get; set; }

    }
}
