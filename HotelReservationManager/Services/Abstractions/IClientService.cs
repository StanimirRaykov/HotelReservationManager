using HotelReservationManager.Data.Entities;
using HotelReservationManager.Models.Client;
using HotelReservationManager.Models.Client.Request;
using HotelReservationManager.Models.Client.Response;

namespace HotelReservationManager.Services.Abstractions
{
    public interface IClientService
    {
        public Task<ClientResponseDTO> AddClient(string firstName, string lastName, int phoneNumber, string email, bool isAdult);

        public Task<bool> RemoveClient(int ClientId);

        public Task<ClientResponseDTO> UpdateClient(int id, string firstName, string lastName, int phoneNumber, string email, bool isAdult);//?

        public IEnumerable<ClientResponseDTO> GetAllClients();//ICollection or IEnumerable? 

        public Task<ClientResponseDTO> GetClientById(int CLientId);

        //to do ... 
    }
}
