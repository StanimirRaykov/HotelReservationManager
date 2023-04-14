using HotelReservationManager.Data.Entities;

namespace HotelReservationManager.Services.Abstractions
{
    public interface IClientService
    {
        public Task<T> AddClientAsync<T>(Client client);

        public Task RemoveClientAsynch(int id);

        public Task<T> UpdateClientAsync<T>(Client client);//?

        public Task<IEnumerable<T>> GetAllClients<T>();

        public Task<Client> GetClientById(int id);

        //to do ... 
    }
}
