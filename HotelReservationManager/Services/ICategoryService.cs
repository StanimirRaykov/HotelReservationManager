using HotelReservationManager.Data;
using HotelReservationManager.DTO.Requests;
using HotelReservationManager.DTO.Responses;

namespace HotelReservationManager.Services
{
    public interface ICategoryService
    {
        //TODO: Should we use DTOs here?
        public Task<ProductResponseDTO> GetCategoryByIdAsync(int categoryId);
        public Task<ICollection<ProductResponseDTO>> GetAllCategorysAsync();
        public Task<ProductResponseDTO> CreateAsync(CategoryRequestDTO category);
        public Task<ProductResponseDTO> UpdateAsync(CategoryRequestDTO category);
        public Task<ProductResponseDTO> DeleteAsync(int categoryId);
    }
}
