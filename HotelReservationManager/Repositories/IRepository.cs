using HotelReservationManager.Data.Entities;

namespace HotelReservationManager.Repositories
{
        public interface IRepository<T> where T : BaseEntity
        {
            public Task<T> GetById(int id);
            public IEnumerable<T> GetAll();
            public IEnumerable<T> GetByFilter(Func<T, bool> predicate);
            public Task<T> Create(T item);
            public Task<T> Update(T item);
            public Task<bool> Delete(T item);
            public Task<bool> DeleteById(int id);
    }
}
