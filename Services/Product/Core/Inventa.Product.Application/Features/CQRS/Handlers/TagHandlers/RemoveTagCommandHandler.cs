using Inventa.Product.Application.Features.CQRS.Commands.TagCommands;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.TagHandlers
{
    public class RemoveTagCommandHandler
    {
        private readonly ITagRepository _tagRepository;
        public RemoveTagCommandHandler(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public async Task Handle(RemoveTagCommand request)
        {
            var value = await _tagRepository.GetByIdAsync(request.Id);
            await _tagRepository.DeleteAsync(value);
        }
    }
}
