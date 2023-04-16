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
        public virtual async Task<T> Create(T item)
        {
            _context.Set<T>().Add(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<bool> DeleteById(int id)
        {
            var item = await GetById(id);
            if (item != null)
            {
                return await this.Delete(item);
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IEnumerable<T> GetByFilter(Func<T, bool> predicate)
        {
            return _context.Set<T>()
                .Where(predicate)
                .ToList();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);

        }

        public virtual async Task<T> Update(T item)
        {
            _context.Set<T>().Update(item);
            _context.Entry(item).Property(x => x.CreatedAt).IsModified = false;

            await _context.SaveChangesAsync();

            return item;
        }
        public async Task<bool> Delete(T item)
        {
            _context.Set<T>().Remove(item);
            return (await _context.SaveChangesAsync()) != 0;
        }
    }
}
