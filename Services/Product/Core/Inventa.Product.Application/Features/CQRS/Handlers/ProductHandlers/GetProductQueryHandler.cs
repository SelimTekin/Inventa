using Inventa.Product.Application.Features.CQRS.Results.ProductResults;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class GetProductQueryHandler
    {
        private readonly IProductRepository _productRepository;
        public GetProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<GetProductQueryResult>> Handle()
        {
            var values = await _productRepository.GetAllAsync();
            return values.Select(x => new GetProductQueryResult
            {
                Id = x.Id,
                Barcode = x.Barcode,
                BrandId = x.BrandId,
                CategoryId = x.CategoryId,
                CreatedAt = x.CreatedAt,
                Description = x.Description,
                IsActive = x.IsActive,
                Name = x.Name,
                Price = x.Price,
                SKU = x.SKU,
                StockQuantity = x.StockQuantity
            }).ToList();
        }
    }
}
