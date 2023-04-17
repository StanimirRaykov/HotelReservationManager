using HotelReservationManager.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata;
using HotelReservationManager.Models.User;
using HotelReservationManager.Models.User.Response;
using HotelReservationManager.Models.User.Request;

namespace HotelReservationManager.Services.Abstractions
{
    public interface IUserService
    {
        public Task<UserResponseDTO> AddUser(string username, string password, string firstName, string middleName, string lastName, string ucn, int phoneNumber, string email, DateTime appointmentDate, bool isActive, bool isAdmin);
        public Task<bool> RemoveUser(int userId);

        public Task<UserResponseDTO> UpdateUser(int userId,string username, string password, string firstName, string midlleName, string lastName, string ucn, int phoneNumber, string email, DateTime appointmentDate, bool isActive, bool isAdmin);

        public IEnumerable<UserResponseDTO> GetAll();//ICollection or IEnumerable?
        public Task<UserResponseDTO> GetUserById(int userId);

        //to do ...
    }
}
