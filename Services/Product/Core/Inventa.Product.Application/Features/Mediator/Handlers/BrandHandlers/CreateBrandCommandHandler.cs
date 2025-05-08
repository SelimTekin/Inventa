using Inventa.Product.Application.Features.Mediator.Commands.BrandCommands;
using Inventa.Product.Application.Interfaces;
using Inventa.Product.Domain.Entities;
using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand>
    {
        private readonly IBrandRepository _brandRepository;

        public CreateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public async Task Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            await _brandRepository.AddAsync(new Brand
            {
                Description = request.Description,
                Name = request.Name
            });
        }
    }
}
