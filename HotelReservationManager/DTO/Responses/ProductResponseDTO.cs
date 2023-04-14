namespace HotelReservationManager.DTO.Responses
{
    public class ProductResponseDTO : BaseResponseDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<CategoryResponseDTO> Categories { get; set; }
    }
}
