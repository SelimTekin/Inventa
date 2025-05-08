using Inventa.Product.Application.Features.Mediator.Commands.BrandCommands;
using Inventa.Product.Application.Interfaces;
using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler : IRequestHandler<RemoveBrandCommand>
    {
        private readonly IBrandRepository _brandRepository;
        public RemoveBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public async Task Handle(RemoveBrandCommand command, CancellationToken cancellationToken)
        {
            var value = await _brandRepository.GetByIdAsync(command.Id);
            await _brandRepository.DeleteAsync(value);
        }
    }
}
