using Inventa.Product.Application.Features.CQRS.Queries.ProductTagQueries;
using Inventa.Product.Application.Features.CQRS.Results.ProductTagResults;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductTagHandlers
{
    public class GetProductTagByIdQueryHandler
    {
        private readonly IProductTagRepository _productTagRepository;
        public GetProductTagByIdQueryHandler(IProductTagRepository productTagRepository)
        {
            _productTagRepository = productTagRepository;
        }
        public async Task<GetProductTagByIdQueryResult> Handle(GetProductTagByIdQuery query)
        {
            var productTag = await _productTagRepository.GetByIdAsync(query.Id);
            return new GetProductTagByIdQueryResult
            {
                ProductId = productTag.ProductId,
                TagId = productTag.TagId
            };
        }
    }
}
