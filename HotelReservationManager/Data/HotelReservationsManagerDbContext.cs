using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HotelReservationManager.Data.Entities;

namespace HotelReservationManager.Data
{
    public class HotelReservationsManagerDbContext :IdentityDbContext
    {
        public HotelReservationsManagerDbContext(DbContextOptions options)
            :base (options)
        {
            
        }
        public DbSet<Reservation> Reservations { get; set;}
        public DbSet<Room> Rooms { get; set;}
        public DbSet<Client> Clients { get; set;}
        public DbSet<User> User { get; set; }
    }
}
