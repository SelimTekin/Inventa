using Inventa.Product.Application.Features.CQRS.Commands.ProductCommands;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class RemoveProductCommandHandler
    {
        private readonly IProductRepository _productRepository;
        public RemoveProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task Handle(RemoveProductCommand command)
        {
            var value = await _productRepository.GetByIdAsync(command.Id);
            await _productRepository.DeleteAsync(value);
        }
    }
}
