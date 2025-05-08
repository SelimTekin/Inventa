using Inventa.Product.Application.Features.CQRS.Queries.TagQueries;
using Inventa.Product.Application.Features.CQRS.Results.TagResults;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.TagHandlers
{
    public class GetTagByIdQueryHandler
    {
        private readonly ITagRepository _tagRepository;
        public GetTagByIdQueryHandler(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public async Task<GetTagByIdQueryResult> Handle(GetTagByIdQuery query)
        {
            var value = await _tagRepository.GetByIdAsync(query.Id);
            return new GetTagByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name
            };
        }
    }
}
