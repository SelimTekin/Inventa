using Inventa.Product.Application.Features.CQRS.Results.TagResults;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.TagHandlers
{
    public class GetTagQueryHandler
    {
        private readonly ITagRepository _tagRepository;
        public GetTagQueryHandler(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public async Task<List<GetTagQueryResult>> Handle()
        {
            var values = await _tagRepository.GetAllAsync();
            return values.Select(x => new GetTagQueryResult
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}
