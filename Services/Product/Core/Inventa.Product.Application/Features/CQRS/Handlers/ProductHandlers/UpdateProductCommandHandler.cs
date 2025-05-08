using Inventa.Product.Application.Features.CQRS.Commands.ProductCommands;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class UpdateProductImageCommandHandler
    {
        private readonly IProductRepository _productRepository;
        public UpdateProductImageCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            var values = await _productRepository.GetByIdAsync(command.Id);
            values.SKU = command.SKU;
            values.Name = command.Name;
            values.Description = command.Description;
            values.Price = command.Price;
            values.StockQuantity = command.StockQuantity;
            values.Barcode = command.Barcode;
            values.CategoryId = command.CategoryId;
            values.BrandId = command.BrandId;
            values.IsActive = command.IsActive;
            values.CreatedAt = command.CreatedAt;
            await _productRepository.UpdateAsync(values);
        }
    }
}
