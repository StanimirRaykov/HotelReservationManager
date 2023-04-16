using HotelReservationManager.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata;
using HotelReservationManager.Models.User;
using HotelReservationManager.Models.User.Response;
using HotelReservationManager.Models.User.Request;

namespace HotelReservationManager.Services.Abstractions
{
    public interface IUserService
    {
        public Task<UserResponseDTO> AddUserAsync(UserRequestDTO user);
        public Task<UserResponseDTO> RemoveUserAsync(int UserId);

        public Task<UserResponseDTO> UpdateUserAsync<T>(UserRequestDTO user);

        public Task<ICollection<UserResponseDTO>> GetAllUsers<T>();//ICollection or IEnumerable?
        public Task<UserResponseDTO> GetUserById(int id);

        //to do ...
    }
}
