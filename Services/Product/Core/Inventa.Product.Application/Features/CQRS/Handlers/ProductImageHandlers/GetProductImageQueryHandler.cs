using Inventa.Product.Application.Features.CQRS.Results.ProductImageResults;
using Inventa.Product.Application.Interfaces;
using Inventa.Product.Domain.Entities;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductImageHandlers
{
    public class GetProductImageQueryHandler
    {
        private readonly IProductImageRepository _productImageRepository;
        public GetProductImageQueryHandler(IProductImageRepository productImageRepository)
        {
            _productImageRepository = productImageRepository;
        }
        public async Task<List<GetProductImageQueryResult>> Handle()
        {
            var values = await _productImageRepository.GetAllAsync();
            return values.Select(x => new GetProductImageQueryResult
            {
                Id = x.Id,
                ProductId = x.ProductId,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}
