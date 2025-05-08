using Inventa.Product.Application.Features.Mediator.Queries.CategoryQueries;
using Inventa.Product.Application.Features.Mediator.Results.CategoryResults;
using Inventa.Product.Application.Interfaces;
using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, List<GetCategoryQueryResult>>
    {
        private readonly ICategoryRepository _categoryRepository;
        public GetCategoryQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<List<GetCategoryQueryResult>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _categoryRepository.GetAllAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                Description = x.Description,
                Id = x.Id,
                Name = x.Name,
            }).ToList();
        }
    }
}
