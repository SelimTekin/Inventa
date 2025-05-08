using Inventa.Product.Application.Features.CQRS.Queries.ProductQueries;
using Inventa.Product.Application.Features.CQRS.Results.ProductResults;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class GetProductImageByIdQueryHandler
    {
        private readonly IProductRepository _productRepository;
        public GetProductImageByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
        {
            var values = await _productRepository.GetByIdAsync(query.Id);
            return new GetProductByIdQueryResult
            {
                Id = values.Id,
                Name = values.Name,
                Description = values.Description,
                Price = values.Price,
                StockQuantity = values.StockQuantity,
                SKU = values.SKU,
                Barcode = values.Barcode,
                CategoryId = values.CategoryId,
                BrandId = values.BrandId,
                IsActive = values.IsActive,
                CreatedAt = values.CreatedAt
            };
        }
    }
}
