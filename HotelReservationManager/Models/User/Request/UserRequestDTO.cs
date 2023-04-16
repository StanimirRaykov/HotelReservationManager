namespace HotelReservationManager.Models.User.Request
{
    public class UserRequestDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string UCN { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public DateTime AppointmentDate { get; set; }
        public bool IsActive { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool IsAdmin { get; set; }
    }
}
