using Inventa.Product.Application.Interfaces;
using Inventa.Product.Domain.Entities;
using Inventa.Product.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Inventa.Product.Persistence.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ProductDbContext _context;
        public BrandRepository(ProductDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Brand brand)
        {
            _context.Set<Brand>().Add(brand);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Brand brand)
        {
            _context.Set<Brand>().Remove(brand);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Brand>> GetAllAsync()
        {
            return await _context.Set<Brand>().ToListAsync();
        }

        public async Task<Brand> GetByIdAsync(Guid id)
        {
            return await _context.Set<Brand>().FindAsync(id);
        }

        public async Task UpdateAsync(Brand brand)
        {
            _context.Set<Brand>().Update(brand);
            await _context.SaveChangesAsync();
        }
    }
}
