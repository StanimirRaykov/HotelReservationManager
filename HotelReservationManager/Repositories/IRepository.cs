using HotelReservationManager.Data.Entities;

namespace HotelReservationManager.Repositories
{
        public interface IRepository<T> where T : BaseEntity
        {
            Task<T> GetByIdAsync(int id);
            Task<ICollection<T>> GetAllAsync();
            ICollection<T> GetByFilter(Func<T, bool> predicate);
            Task<T> CreateAsync(T item);
            Task<T> UpdateAsync(T item);
            Task<T> DeleteAsync(int id);
        }
}
