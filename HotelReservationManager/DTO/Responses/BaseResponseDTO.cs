namespace HotelReservationManager.DTO.Responses
{
    public abstract class BaseResponseDTO
    {

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified {get; set; }
    }
}
