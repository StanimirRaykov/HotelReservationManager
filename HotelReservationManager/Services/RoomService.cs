using HotelReservationManager.Data.Entities;
using HotelReservationManager.Models.Client.Request;
using HotelReservationManager.Models.Client.Response;
using HotelReservationManager.Models.Reservation.Response;
using HotelReservationManager.Models.Room.Request;
using HotelReservationManager.Models.Room.Response;
using HotelReservationManager.Repositories;
using HotelReservationManager.Services.Abstractions;

namespace HotelReservationManager.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRepository<Room> _roomRepository;

        public RoomService(IRepository<Room> roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<RoomResponseDTO> AddRoom(int size, string type, bool isTaken, double adultPrice, double childPrice, int roomNumber)
        {
            var item = await _roomRepository.Create(new Room()
            {
                Size = size,
                Type = type,
                IsTaken = isTaken,
                AdultPrice = adultPrice,
                ChildPrice = childPrice,
                RoomNumber = roomNumber
            });

            return new RoomResponseDTO()
            {
                Id = item.Id,
                Size = item.Size,
                Type = item.Type,
                IsTaken = item.IsTaken,
                AdultPrice = item.AdultPrice,
                ChildPrice = item.ChildPrice,
                RoomNumber = item.RoomNumber,
                CreatedAt = item.CreatedAt,
                ModifiedAt = item.ModifiedAt
            };

        }

        public IEnumerable<RoomResponseDTO> GetAll()
        {
            return _roomRepository.GetAll()
                .Select(item => new RoomResponseDTO()
                {
                    Id = item.Id,
                    Size = item.Size,
                    Type = item.Type,
                    IsTaken = item.IsTaken,
                    AdultPrice = item.AdultPrice,
                    ChildPrice = item.ChildPrice,
                    RoomNumber = item.RoomNumber,
                    CreatedAt = item.CreatedAt,
                    ModifiedAt = item.ModifiedAt
                }).ToList();

        }

        public async Task<RoomResponseDTO> GetRoomById(int id)
        {
            var item = await _roomRepository.GetById(id);
            return new RoomResponseDTO()
            {
                Id = item.Id,
                Size = item.Size,
                Type = item.Type,
                IsTaken = item.IsTaken,
                AdultPrice = item.AdultPrice,
                ChildPrice = item.ChildPrice,
                RoomNumber = item.RoomNumber,
                CreatedAt = item.CreatedAt,
                ModifiedAt = item.ModifiedAt
            };
        }

        public async Task<bool> RemoveRoom(int roomId)
        {
            return await _roomRepository.DeleteById(roomId);
        }

        public async Task<RoomResponseDTO> UpdateRoom(int roomId, int size, string type, bool isTaken, double adultPrice, double childPrice, int roomNumber)
        {
            var item = await _roomRepository.GetById(roomId);
            if (item != null)
            {
                item.Id = roomId;
                item.Size = size;
                item.Type = type;
                item.IsTaken = isTaken;
                item.AdultPrice = adultPrice;
                item.ChildPrice = childPrice;
                item.RoomNumber = roomNumber;
            }

            item = await _roomRepository.Create(item);
            return new RoomResponseDTO()
            {
                Id = item.Id,
                Size = item.Size,
                Type = item.Type,
                IsTaken = item.IsTaken,
                AdultPrice = item.AdultPrice,
                ChildPrice = item.ChildPrice,
                RoomNumber = item.RoomNumber,
                CreatedAt = item.CreatedAt,
                ModifiedAt = item.ModifiedAt
            };
        }
    }
}

