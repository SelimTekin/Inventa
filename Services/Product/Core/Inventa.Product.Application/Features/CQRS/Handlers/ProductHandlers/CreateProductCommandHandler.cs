using Inventa.Product.Application.Features.CQRS.Commands.ProductCommands;
using Inventa.Product.Application.Interfaces;
using Inventa.Product.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<CreateProductCommandHandler> _logger;
        public CreateProductCommandHandler(IProductRepository productRepository, ILogger<CreateProductCommandHandler> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }
        public async Task Handle(CreateProductCommand command)
        {
            _logger.LogInformation("Creating a new product with Name: {Name}", command.Name);
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
