using HotelReservationManager.Data.Entities;
using HotelReservationManager.Models.Client.Request;
using HotelReservationManager.Models.Reservation;
using HotelReservationManager.Models.Reservation.Request;
using HotelReservationManager.Models.Reservation.Response;
using HotelReservationManager.Models.User.Request;

namespace HotelReservationManager.Services.Abstractions
{
    public interface IReservationService
    {
        public Task<ReservationResponseDTO> AddReservation(int roomId, int userId, IEnumerable<ClientRequestDTO> Clients, DateTime accommodationDate, DateTime roomReleaseDate, bool breakfastIncluded, bool AllInclusiveIncluded, double owedAmount);

        public Task<ReservationResponseDTO> UpdateReservation(int reservationId, int roomId, int userId, IEnumerable<ClientRequestDTO> Clients, DateTime accommodationDate, DateTime roomReleaseDate, bool breakfastIncluded, bool AllInclusiveIncluded, double owedAmount);

        public Task<bool> DeleteReservation(int ReservationId);

        public Task<ReservationResponseDTO> GetReservationById(int ReservationId);
        public Task<ICollection<ReservationResponseDTO>> GetAllReservations();

        //To do ...

    }
}
