using Microsoft.EntityFrameworkCore;
using UniversityRegistrationCore.Data;
using UniversityRegistrationCore.Repositories.Interfaces;

namespace UniversityRegistrationCore.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly UniversityDbContext _context;

        public Repository(UniversityDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
}
