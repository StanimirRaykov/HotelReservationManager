using HotelReservationManager.Data.Entities;
using HotelReservationManager.Models.Room;
using HotelReservationManager.Models.Room.Request;
using HotelReservationManager.Models.Room.Response;

namespace HotelReservationManager.Services.Abstractions
{
    public interface IRoomService
    {
        public Task<RoomResponseDTO> AddRoomAsync(RoomRequestDTO room);


        public Task<RoomResponseDTO> RemoveRoomAsync(int RoomId);

        public Task<RoomResponseDTO> UpdateRoomAsync(int RoomId, RoomRequestDTO room);

        public Task<ICollection<RoomResponseDTO>> GetAllAsync();//ICollection or IEnumerable?

        public Task<RoomResponseDTO> GetRoomByIdAsync(int id);

        //To do...
    }
}
