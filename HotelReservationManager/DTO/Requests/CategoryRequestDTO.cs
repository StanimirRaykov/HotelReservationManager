using System.ComponentModel.DataAnnotations;

namespace HotelReservationManager.DTO.Requests
{
    public class CategoryRequestDTO
    {
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Title { get; set; }
    }
}
