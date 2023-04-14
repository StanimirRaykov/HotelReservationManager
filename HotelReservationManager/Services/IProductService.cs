using HotelReservationManager.DTO.Requests;
using HotelReservationManager.DTO.Responses;

namespace HotelReservationManager.Services
{
    public interface IProductService
    {
        //TODO: Should we use DTOs here?
        public Task<ProductResponseDTO> GetProductByIdAsync(int productId);
        public Task<ICollection<ProductResponseDTO>> GetAllProductsAsync();
        public Task<ProductResponseDTO> CreateAsync(ProductRequestsDTO item, string userId);
        public Task<ProductResponseDTO> UpdateAsync(int productID, ProductRequestsDTO item, string userId);
        public Task<ProductResponseDTO> DeleteAsync(int productId);
    }
}
