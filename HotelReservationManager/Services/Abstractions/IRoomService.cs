using HotelReservationManager.Data.Entities;
using HotelReservationManager.Models.Room;
using HotelReservationManager.Models.Room.Request;
using HotelReservationManager.Models.Room.Response;

namespace HotelReservationManager.Services.Abstractions
{
    public interface IRoomService
    {
        public Task<RoomResponseDTO> AddRoom(int size, string type, bool isTaken, double adultPrice, double childPrice, int roomNumber);


        public Task<bool> RemoveRoom(int roomId);

        public Task<RoomResponseDTO> UpdateRoom(int roomId, int size, string type, bool isTaken, double adultPrice, double childPrice, int roomNumber);

        public IEnumerable<RoomResponseDTO> GetAll();//ICollection or IEnumerable?

        public Task<RoomResponseDTO> GetRoomById(int id);

        //To do...
    }
}
