using HotelReservationManager.Data.Entities;

namespace HotelReservationManager.Services.Abstractions
{
    public interface IReservationService
    {
        public Task<Reservation> AddReservation(int roomId, DateTime accommodationDate, DateTime roomReleaseDate, bool breakfastIncluded, bool AllInclusiveIncluded, IEnumerable<Client> Clients);

        public Task<bool> UpdateReservation(int id,DateTime accomodationDate,DateTime roomReleaseDate,bool allInclusive,bool breakfastIncluded, bool AllInclusiveIncluded, IEnumerable<Client> Clients);

        public Task<bool> DeleteReservation(int id);

        public Task<Reservation> GetReservation(int id);
        public Task<IEnumerable<T>> GetAll<T>();

        //To do ...

    }
}
