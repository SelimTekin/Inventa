using Inventa.Product.Domain.Entities;

namespace Inventa.Product.Application.Interfaces
{
    public interface IProductImageRepository
    {
        Task<List<ProductImage>> GetAllAsync();
        Task<ProductImage> GetByIdAsync(Guid id);
        Task AddAsync(ProductImage productImage);
        Task UpdateAsync(ProductImage productImage);
        Task DeleteAsync(ProductImage productImage);
    }
}
