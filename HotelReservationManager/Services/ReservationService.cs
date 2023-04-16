using HotelReservationManager.Data.Entities;
using HotelReservationManager.Models.Client.Request;
using HotelReservationManager.Models.Client.Response;
using HotelReservationManager.Models.Reservation.Response;
using HotelReservationManager.Models.Room.Response;
using HotelReservationManager.Models.User.Request;
using HotelReservationManager.Repositories;
using HotelReservationManager.Services.Abstractions;

namespace HotelReservationManager.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IRepository<Reservation> _reservationRepository;
        
        private readonly IRepository<User> _userRepository;
        public ReservationService(IRepository<Reservation> reservationRepository, IRepository<User> userRepository)
        {
            _reservationRepository = reservationRepository;
            _userRepository = userRepository;
        }

        public async Task<ReservationResponseDTO> AddReservation(int roomId, int userId, IEnumerable<ClientRequestDTO> clients, DateTime accommodationDate, DateTime roomReleaseDate, bool breakfastIncluded, bool allInclusiveIncluded, double owedAmount)
        {
            var clientEntities = clients.Select(dto => new Client
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
                IsAdult = dto.IsAdult
            }).ToList();

            var item = await _reservationRepository.Create(new Reservation()
            {
                RoomId = roomId,
                UserId = userId,
                Clients = clientEntities,
                DateOfAccommodation = accommodationDate,
                ReleaseDate = roomReleaseDate,
                BreakfastIncluded = breakfastIncluded,
                AllInclusiveIncluded = allInclusiveIncluded,
                OwedAmount = owedAmount
            });

            return new ReservationResponseDTO()
            {
                Id = item.Id,
                RoomId = item.RoomId,
                UserId = item.UserId,
                Clients = (IEnumerable<ClientRequestDTO>)item.Clients.Select(c => new ClientResponseDTO 
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    PhoneNumber = c.PhoneNumber,
                    Email = c.Email,
                    IsAdult = c.IsAdult
                }),
                DateOfAccommodation = item.DateOfAccommodation,
                ReleaseDate = item.ReleaseDate,
                BreakfastIncluded = item.BreakfastIncluded,
                AllInclusiveIncluded = item.AllInclusiveIncluded,
                OwedAmount = item.OwedAmount,
                Room = new RoomPairResponseDTO() 
                {
                    RoomId = item.Room.Id,
                    RoomType = item.Room.Type
                },
                CreatedAt = item.CreatedAt,
                ModifiedAt = item.ModifiedAt

            };
        }

        public async Task<bool> DeleteReservation(int ReservationId)
        {
            return await _reservationRepository.DeleteById(ReservationId);
        }

        public async Task<ICollection<ReservationResponseDTO>> GetAllReservations()
        {
            return _reservationRepository.GetAll()
                .Select(item => new ReservationResponseDTO()
                {
                    Id = item.Id,
                    RoomId = item.RoomId,
                    UserId = item.UserId,
                    Clients = (IEnumerable<ClientRequestDTO>)item.Clients.Select(c => new ClientResponseDTO
                    {
                        FirstName = c.FirstName,
                        LastName = c.LastName,
                        PhoneNumber = c.PhoneNumber,
                        Email = c.Email,
                        IsAdult = c.IsAdult
                    }),
                    DateOfAccommodation = item.DateOfAccommodation,
                    ReleaseDate = item.ReleaseDate,
                    BreakfastIncluded = item.BreakfastIncluded,
                    AllInclusiveIncluded = item.AllInclusiveIncluded,
                    OwedAmount = item.OwedAmount,
                    Room = new RoomPairResponseDTO()
                    {
                        RoomId = item.Room.Id,
                        RoomType = item.Room.Type
                    },
                    CreatedAt = item.CreatedAt,
                    ModifiedAt = item.ModifiedAt
                }).ToList();
        }

        public async Task<ReservationResponseDTO> GetReservationById(int id)
        {
            var item = await _reservationRepository.GetById(id);
            return new ReservationResponseDTO()
            {
                Id = item.Id,
                RoomId = item.RoomId,
                UserId = item.UserId,
                Clients = (IEnumerable<ClientRequestDTO>)item.Clients.Select(c => new ClientResponseDTO
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    PhoneNumber = c.PhoneNumber,
                    Email = c.Email,
                    IsAdult = c.IsAdult
                }),
                DateOfAccommodation = item.DateOfAccommodation,
                ReleaseDate = item.ReleaseDate,
                BreakfastIncluded = item.BreakfastIncluded,
                AllInclusiveIncluded = item.AllInclusiveIncluded,
                OwedAmount = item.OwedAmount,
                Room = new RoomPairResponseDTO()
                {
                    RoomId = item.Room.Id,
                    RoomType = item.Room.Type
                },
                CreatedAt = item.CreatedAt,
                ModifiedAt = item.ModifiedAt
            };
        }

        public async Task<ReservationResponseDTO> UpdateReservation(int reservationId, int roomId, int userId, IEnumerable<ClientRequestDTO> clients, DateTime accommodationDate, DateTime roomReleaseDate, bool breakfastIncluded, bool allInclusiveIncluded, double owedAmount)
        {
            var clientEntities = clients.Select(dto => new Client
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
                IsAdult = dto.IsAdult
            }).ToList();

            var item = await _reservationRepository.GetById(reservationId);
            if (item != null)
            {
                item.Id = reservationId;
                item.RoomId = roomId;
                item.UserId = userId;
                item.Clients = clientEntities;
                item.DateOfAccommodation = accommodationDate;
                item.ReleaseDate = roomReleaseDate;
                item.BreakfastIncluded = breakfastIncluded;
                item.AllInclusiveIncluded = allInclusiveIncluded;
            }

            item = await _reservationRepository.Create(item);
            return new ReservationResponseDTO()
            {
                Id = item.Id,
                RoomId = item.RoomId,
                UserId = item.UserId,
                Clients = (IEnumerable<ClientRequestDTO>)item.Clients.Select(c => new ClientResponseDTO
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    PhoneNumber = c.PhoneNumber,
                    Email = c.Email,
                    IsAdult = c.IsAdult
                }),
                DateOfAccommodation = item.DateOfAccommodation,
                ReleaseDate = item.ReleaseDate,
                BreakfastIncluded = item.BreakfastIncluded,
                AllInclusiveIncluded = item.AllInclusiveIncluded,
                OwedAmount = item.OwedAmount,
                Room = new RoomPairResponseDTO()
                {
                    RoomId = item.Room.Id,
                    RoomType = item.Room.Type
                },
                CreatedAt = item.CreatedAt,
                ModifiedAt = item.ModifiedAt

            };
        }
    }
}
