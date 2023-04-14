using System.ComponentModel.DataAnnotations;

namespace HotelReservationManager.Data
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; } 
        public DateTime Created { get; set; }  
        public DateTime Modified { get; set; }

    }
}
