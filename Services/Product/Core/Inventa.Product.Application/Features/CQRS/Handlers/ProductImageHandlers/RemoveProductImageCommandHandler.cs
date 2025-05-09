using Inventa.Product.Application.Features.CQRS.Commands.ProductImageCommands;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductImageHandlers
{
    public class RemoveProductImageCommandHandler
    {
        private readonly IProductImageRepository _productImageRepository;

        public RemoveProductImageCommandHandler(IProductImageRepository productImageRepository)
        {
            _productImageRepository = productImageRepository;
        }
        public async Task Handle(RemoveProductImageCommand command)
        {
            var value = await _productImageRepository.GetByIdAsync(command.Id);
            await _productImageRepository.DeleteAsync(value);
        }
    }
}
