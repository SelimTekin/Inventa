using Inventa.Product.Application.Features.CQRS.Queries.ProductImageQueries;
using Inventa.Product.Application.Features.CQRS.Results.ProductImageResults;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductImageHandlers
{
    public class GetProductImageByIdQueryHandler
    {
        private readonly IProductImageRepository _productImageRepository;
        public GetProductImageByIdQueryHandler(IProductImageRepository productImageRepository)
        {
            _productImageRepository = productImageRepository;
        }
        public async Task<GetProductImageByIdQueryResult> Handle(GetProductImageByIdQuery query)
        {
            var value = await _productImageRepository.GetByIdAsync(query.Id);
            return new GetProductImageByIdQueryResult
            {
                Id = value.Id,
                ProductId = value.ProductId,
                ImageUrl = value.ImageUrl
            };
        }
    }
}
