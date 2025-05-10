using Inventa.Product.Application.Features.Mediator.Queries.BrandQueries;
using Inventa.Product.Application.Features.Mediator.Results.BrandResults;
using Inventa.Product.Application.Interfaces;
using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler : IRequestHandler<GetBrandByIdQuery, GetBrandByIdQueryResult>
    {
        private readonly IBrandRepository _brandRepository;
        public GetBrandByIdQueryHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _brandRepository.GetByIdAsync(request.Id);
            return new GetBrandByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name,
                Description = value.Description,
                LogoUrl = value.LogoUrl,
                Country = value.Country
            };
        }
    }
}
