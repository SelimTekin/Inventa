using Inventa.Product.Application.Features.CQRS.Commands.TagCommands;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.TagHandlers
{
    public class UpdateTagCommandHandler
    {
        private readonly ITagRepository _tagRepository;
        public UpdateTagCommandHandler(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public async Task Handle(UpdateTagCommand command)
        {
            var value = await _tagRepository.GetByIdAsync(command.Id);
            value.Name = command.Name;
            await _tagRepository.UpdateAsync(value);
        }
    }
}
