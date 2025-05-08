using Inventa.Product.Application.Interfaces;
using Inventa.Product.Domain.Entities;
using Inventa.Product.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Inventa.Product.Persistence.Repositories
{
    public class ProductTagRepository : IProductTagRepository
    {
        private readonly ProductDbContext _context;
        public ProductTagRepository(ProductDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(ProductTag productTag)
        {
            _context.Set<ProductTag>().Add(productTag);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(ProductTag productTag)
        {
            _context.Set<ProductTag>().Remove(productTag);
            await _context.SaveChangesAsync();
        }
        public async Task<List<ProductTag>> GetAllAsync()
        {
            return await _context.Set<ProductTag>().ToListAsync();
        }
        public async Task<ProductTag> GetByIdAsync(Guid id)
        {
            return await _context.Set<ProductTag>().FindAsync(id);
        }
    }
}
