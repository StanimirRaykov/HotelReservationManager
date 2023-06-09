﻿namespace HotelReservationManager.Data.Entities
{
    public class Reservation : BaseEntity
    {
        public Reservation()
        {

        }
        public int RoomId { get; set; }
        public int UserId { get; set; }

        public IEnumerable<Client> Clients { get; set; }

        public DateTime DateOfAccommodation { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool BreakfastIncluded { get; set; }

        public bool AllInclusiveIncluded { get; set; }

        public double OwedAmount { get; set; }

        public virtual Room Room { get; set; }
    }
}
