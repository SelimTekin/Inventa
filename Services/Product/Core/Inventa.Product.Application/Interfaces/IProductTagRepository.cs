using Inventa.Product.Domain.Entities;

namespace Inventa.Product.Application.Interfaces
{
    public interface IProductTagRepository
    {
        Task<List<ProductTag>> GetAllAsync();
        Task<ProductTag> GetByIdAsync(Guid id);
        Task AddAsync(ProductTag productTag);
        Task UpdateAsync(ProductTag productTag);
        Task DeleteAsync(ProductTag productTag);
    }
}
