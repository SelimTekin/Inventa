using Inventa.Product.Application.Features.CQRS.Commands.ProductImageCommands;
using Inventa.Product.Application.Interfaces;
using Inventa.Product.Domain.Entities;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductImageHandlers
{
    public class CreateProductImageCommandHandler
    {
        private readonly IProductImageRepository _productImageRepository;
        public CreateProductImageCommandHandler(IProductImageRepository productImageRepository)
        {
            _productImageRepository = productImageRepository;
        }
        public async Task Handle(CreateProductImageCommand command)
        {
            await _productImageRepository.AddAsync(new ProductImage
            {
                ProductId = command.ProductId,
                ImageUrl = command.ImageUrl,
            });
        }
    }
}
