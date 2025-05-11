using Inventa.Product.Application.Features.Mediator.Queries.CategoryQueries;
using Inventa.Product.Application.Features.Mediator.Results.CategoryResults;
using Inventa.Product.Application.Interfaces;
using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoryByIdQueryResult>
    {
        private readonly ICategoryRepository _categoryRepository;
        public GetCategoryByIdQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.Id);
            return new GetCategoryByIdQueryResult
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                ParentCategoryId = category.ParentCategoryId
            };
        }
    }
}
