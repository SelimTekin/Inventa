using Inventa.Product.Application.Features.CQRS.Commands.TagCommands;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.TagHandlers
{
    public class UpdateTagCommandHadnler
    {
        private readonly ITagRepository _tagRepository;
        public UpdateTagCommandHadnler(ITagRepository tagRepository)
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
