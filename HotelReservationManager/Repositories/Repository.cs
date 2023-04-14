using HotelReservationManager.Data;
using HotelReservationManager.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelReservationManager.Repositories
{
    public class Repository<T> : IRepository<T>
         where T : BaseEntity
    {
        private readonly HotelReservationsManagerDbContext _context;

        public Repository(HotelReservationsManagerDbContext context)
        {
            _context = context;
        }
        public virtual async Task<T> CreateAsync(T item)
        {
            _context.Set<T>().Add(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public virtual async Task<T> DeleteAsync(int id)
        {
            var item = await GetByIdAsync(id);
            _context.Remove(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public virtual async Task<ICollection<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual ICollection<T> GetByFilter(Func<T, bool> predicate)
        {
            return _context.Set<T>()
                .Where(predicate)
                .ToList();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>()
                .FindAsync(id);

        }

        public virtual async Task<T> UpdateAsync(T item)
        {
            _context.Set<T>().Update(item);
            _context.Entry(item).Property(x => x.CreatedAt).IsModified = false;

            await _context.SaveChangesAsync();

            return item;
        }
    }
}
