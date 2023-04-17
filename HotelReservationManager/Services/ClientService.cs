using HotelReservationManager.Data.Entities;
using HotelReservationManager.Models.Client.Response;
using HotelReservationManager.Repositories;
using HotelReservationManager.Services.Abstractions;
using System.Security.Cryptography.X509Certificates;
using HotelReservationManager.Models.Room.Response;
using HotelReservationManager.Models.Client.Request;

namespace HotelReservationManager.Services
{
    public class ClientService : IClientService
    {
        private readonly IRepository<Client> _clientRepository;
        public ClientService(IRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<ClientResponseDTO> AddClient(string firstName, string lastName, int phoneNumber, string email, bool isAdult)
        {
            var item = await _clientRepository.Create(new Client()
            { 
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                Email = email,
                IsAdult = isAdult
            });

            return new ClientResponseDTO()
            {
                Id = item.Id,
                FirstName = item.FirstName,
                LastName = item.LastName,
                PhoneNumber = item.PhoneNumber,
                Email = item.Email,
                IsAdult = item.IsAdult,
                Room = new RoomPairResponseDTO()
                {
                    RoomId = item.Room.Id,
                    RoomType = item.Room.Type
                },
                CreatedAt = item.CreatedAt,
                ModifiedAt = item.ModifiedAt

            };
        }

        public async Task<ClientResponseDTO> UpdateClient(int id, string firstName, string lastName, int phoneNumber, string email, bool isAdult)
        {
            var item = await _clientRepository.GetById(id);
            if(item != null)
            {
                item.Id = id;
                item.FirstName = firstName;
                item.LastName = lastName;
                item.PhoneNumber = phoneNumber;
                item.Email = email;
                item.IsAdult = isAdult;
            }

            item = await _clientRepository.Create(item);

            return new ClientResponseDTO()
            {
                Id = item.Id,
                FirstName = item.FirstName,
                LastName = item.LastName,
                PhoneNumber = item.PhoneNumber,
                Email = item.Email,
                IsAdult = item.IsAdult,
                Room = new RoomPairResponseDTO()
                { 
                    RoomId = item.Room.Id,
                    RoomType = item.Room.Type
                },
                CreatedAt = item.CreatedAt,
                ModifiedAt = item.ModifiedAt
            };
        }

        public IEnumerable<ClientResponseDTO> GetAllClients()
        {
            return _clientRepository.GetAll()
                .Select(item => new ClientResponseDTO()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    PhoneNumber = item.PhoneNumber,
                    Email = item.Email,
                    IsAdult = item.IsAdult,
                    Room = new RoomPairResponseDTO()
                    {
                        RoomId = item.Room.Id,
                        RoomType = item.Room.Type
                    },
                    CreatedAt = item.CreatedAt,
                    ModifiedAt = item.ModifiedAt
                }).ToList();
        }

        public async Task<ClientResponseDTO> GetClientById(int id)
        {
            var item = await _clientRepository.GetById(id);
            return new ClientResponseDTO()
            {
                Id = item.Id,
                FirstName = item.FirstName,
                LastName = item.LastName,
                PhoneNumber = item.PhoneNumber,
                Email = item.Email,
                IsAdult = item.IsAdult,
                Room = new RoomPairResponseDTO()
                {
                    RoomId = item.Room.Id,
                    RoomType = item.Room.Type
                },
                CreatedAt = item.CreatedAt,
                ModifiedAt = item.ModifiedAt
            };

        }

        public async Task<bool> RemoveClient(int ClientId)
        {
            return await _clientRepository.DeleteById(ClientId);

        }
    }
}
