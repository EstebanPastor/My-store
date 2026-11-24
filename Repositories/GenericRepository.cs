using Microsoft.EntityFrameworkCore;
using My_Store.Context;

namespace My_Store.Repositories
{
    public class GenericRepository<TEntity>(AppDbContext _dbContext) where TEntity : class
    {
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }
    }
}
