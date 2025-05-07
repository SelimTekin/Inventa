using Inventa.Product.Application.Interfaces;
using Inventa.Product.Domain.Entities;
using Inventa.Product.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Inventa.Product.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;
        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(ProductEntity product)
        {
            _context.Set<ProductEntity>().Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(ProductEntity product)
        {
            _context.Set<ProductEntity>().Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ProductEntity>> GetAllAsync()
        {
            return await _context.Set<ProductEntity>().ToListAsync();
        }

        public async Task<ProductEntity> GetByIdAsync(Guid id)
        {
            return await _context.Set<ProductEntity>().FindAsync(id);
        }

        public async Task UpdateAsync(ProductEntity product)
        {
            _context.Set<ProductEntity>().Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
