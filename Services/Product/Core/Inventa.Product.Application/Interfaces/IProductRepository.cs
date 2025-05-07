using Inventa.Product.Domain.Entities;

namespace Inventa.Product.Application.Interfaces
{
    public interface IProductRepository
    {
        Task<List<ProductEntity>> GetAllAsync();
        Task<ProductEntity> GetByIdAsync(Guid id);
        Task AddAsync(ProductEntity product);
        Task UpdateAsync(ProductEntity product);
        Task DeleteAsync(ProductEntity product);
    }
}
