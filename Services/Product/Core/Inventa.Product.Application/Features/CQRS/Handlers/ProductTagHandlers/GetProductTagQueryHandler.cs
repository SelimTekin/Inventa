using Inventa.Product.Application.Features.CQRS.Results.ProductTagResults;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductTagHandlers
{
    public class GetProductTagQueryHandler
    {
        private readonly IProductTagRepository _productTagRepository;
        public GetProductTagQueryHandler(IProductTagRepository productTagRepository)
        {
            _productTagRepository = productTagRepository;
        }
        public async Task<List<GetProductTagQueryResult>> Handle()
        {
            var values = await _productTagRepository.GetAllAsync();
            return values.Select(x => new GetProductTagQueryResult
            {
                ProductId = x.ProductId,
                TagId = x.TagId
            }).ToList(); ;
        }
    }
}
