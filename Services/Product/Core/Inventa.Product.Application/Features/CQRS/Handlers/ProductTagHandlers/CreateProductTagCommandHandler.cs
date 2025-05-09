using Inventa.Product.Application.Features.CQRS.Commands.ProductTagCommands;
using Inventa.Product.Application.Interfaces;
using Inventa.Product.Domain.Entities;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductTagHandlers
{
    public class CreateProductTagCommandHandler
    {
        private readonly IProductTagRepository _productTagRepository;
        public CreateProductTagCommandHandler(IProductTagRepository productTagRepository)
        {
            _productTagRepository = productTagRepository;
        }
        public async Task Handle(CreateProductTagCommand command)
        {
            await _productTagRepository.AddAsync(new ProductTag
            {
                ProductId = command.ProductId,
                TagId = command.TagId
            });
        }
    }
}
