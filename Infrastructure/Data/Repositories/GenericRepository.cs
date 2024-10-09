using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly EcommerceContext _context;

        public GenericRepository(EcommerceContext context)
        {
            _context = context;
        }

        public async Task<TEntity> Add(TEntity tentity)
        {
            await _context.Set<TEntity>().AddAsync(tentity);
            await _context.SaveChangesAsync();
            return tentity;
        }
        public async Task Edit(string id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(string id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }
    }
}
