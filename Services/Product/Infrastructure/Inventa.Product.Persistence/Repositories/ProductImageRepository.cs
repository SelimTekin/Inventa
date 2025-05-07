using Inventa.Product.Application.Interfaces;
using Inventa.Product.Domain.Entities;
using Inventa.Product.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Inventa.Product.Persistence.Repositories
{
    public class ProductImageRepository : IProductImageRepository
    {
        private readonly ProductDbContext _context;
        public ProductImageRepository(ProductDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(ProductImage productImage)
        {
            _context.Set<ProductImage>().Add(productImage);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(ProductImage productImage)
        {
            _context.Set<ProductImage>().Remove(productImage);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ProductImage>> GetAllAsync()
        {
            return await _context.Set<ProductImage>().ToListAsync();
        }

        public async Task<ProductImage> GetByIdAsync(Guid id)
        {
            return await _context.Set<ProductImage>().FindAsync(id);
        }

        public async Task UpdateAsync(ProductImage productImage)
        {
            _context.Set<ProductImage>().Update(productImage);
            await _context.SaveChangesAsync();
        }
    }
}
