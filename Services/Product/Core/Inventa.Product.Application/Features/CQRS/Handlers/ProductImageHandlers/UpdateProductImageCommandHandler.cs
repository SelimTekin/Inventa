using Inventa.Product.Application.Features.CQRS.Commands.ProductImageCommands;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductImageHandlers
{
    public class UpdateProductImageCommandHandler
    {
        private readonly IProductImageRepository _productImageRepository;
        public UpdateProductImageCommandHandler(IProductImageRepository productImageRepository)
        {
            _productImageRepository = productImageRepository;
        }
        public async Task Handle(UpdateProductImageCommand command)
        {
            var value = await _productImageRepository.GetByIdAsync(command.Id);
            value.ImageUrl = command.ImageUrl;
            await _productImageRepository.UpdateAsync(value);
        }
    }
}
