using Inventa.Product.Application.Features.Mediator.Commands.BrandCommands;
using Inventa.Product.Application.Interfaces;
using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand>
    {
        private readonly IBrandRepository _brandRepository;
        public UpdateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public async Task Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            var value = await _brandRepository.GetByIdAsync(request.Id);
            value.Name = request.Name;
            value.Description = request.Description;
            await _brandRepository.UpdateAsync(value);
        }
    }
}
