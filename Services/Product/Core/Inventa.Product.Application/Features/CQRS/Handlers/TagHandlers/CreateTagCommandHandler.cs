using Inventa.Product.Application.Features.CQRS.Commands.TagCommands;
using Inventa.Product.Application.Interfaces;
using Inventa.Product.Domain.Entities;

namespace Inventa.Product.Application.Features.CQRS.Handlers.TagHandlers
{
    public class CreateTagCommandHandler
    {
        private readonly ITagRepository _tagRepository;
        public CreateTagCommandHandler(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public async Task Handle(CreateTagCommand command)
        {
            await _tagRepository.AddAsync(new Tag
            {
                Name = command.Name
            });
        }
    }
}
