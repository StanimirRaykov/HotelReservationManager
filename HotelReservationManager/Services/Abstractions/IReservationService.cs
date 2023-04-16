using HotelReservationManager.Data.Entities;
using HotelReservationManager.Models.Client.Request;
using HotelReservationManager.Models.Reservation;
using HotelReservationManager.Models.Reservation.Request;
using HotelReservationManager.Models.Reservation.Response;

namespace HotelReservationManager.Services.Abstractions
{
    public interface IReservationService
    {
        public Task<ReservationResponseDTO> AddReservation(int roomId, DateTime accommodationDate, DateTime roomReleaseDate, bool breakfastIncluded, bool AllInclusiveIncluded, IEnumerable<ClientRequestDTO> Clients);

        public Task<ReservationResponseDTO> UpdateReservation(int id,DateTime accomodationDate,DateTime roomReleaseDate,bool allInclusive,bool breakfastIncluded, bool AllInclusiveIncluded, IEnumerable<ClientRequestDTO> Clients);

        public Task<ReservationResponseDTO> DeleteReservation(int id);

        public Task<ReservationResponseDTO> GetReservationById(int id);
        public Task<ICollection<ReservationResponseDTO>> GetAllReservations<T>();

        //To do ...

    }
}
