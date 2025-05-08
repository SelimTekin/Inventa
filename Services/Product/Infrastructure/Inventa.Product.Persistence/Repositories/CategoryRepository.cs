using Inventa.Product.Domain.Entities;
using Inventa.Product.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Inventa.Product.Persistence.Repositories
{
    public class CategoryRepository
    {
        private readonly ProductDbContext _context;
        public CategoryRepository(ProductDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Category category)
        {
            _context.Set<Category>().Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Category category)
        {
            _context.Set<Category>().Remove(category);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Set<Category>().ToListAsync();
        }

        public async Task<Category> GetByIdAsync(Guid id)
        {
            return await _context.Set<Category>().FindAsync(id);
        }

        public async Task UpdateAsync(Category category)
        {
            _context.Set<Category>().Update(category);
            await _context.SaveChangesAsync();
        }
    }
}
