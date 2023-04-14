using System.ComponentModel.DataAnnotations;

namespace HotelReservationManager.DTO.Requests
{
    public class ProductRequestsDTO
    {
        [Required]
        public string Title { get; set; }
        [MaxLength(4000, ErrorMessage = "The description is limited to 4000 symbols.")]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        public int[] CategoryIds { get; set; }
    }
}
