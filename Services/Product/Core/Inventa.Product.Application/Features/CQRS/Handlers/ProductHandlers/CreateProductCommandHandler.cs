using Inventa.Product.Application.Features.CQRS.Commands.ProductCommands;
using Inventa.Product.Application.Interfaces;
using Inventa.Product.Domain.Entities;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class CreateProductImageCommandHandler
    {
        private readonly IProductRepository _productRepository;
        public CreateProductImageCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            await _productRepository.AddAsync(new ProductEntity
            {
                Barcode = command.Barcode,
                BrandId = command.BrandId,
                CategoryId = command.CategoryId,
                CreatedAt = command.CreatedAt,
                Description = command.Description,
                IsActive = true,
                Name = command.Name,
                Price = command.Price,
                SKU = command.SKU,
                StockQuantity = command.StockQuantity
            });
        }
    }
}
