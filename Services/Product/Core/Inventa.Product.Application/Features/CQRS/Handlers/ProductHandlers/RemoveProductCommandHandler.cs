using Inventa.Product.Application.Features.CQRS.Commands.ProductCommands;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class RemoveProductImageCommandHandler
    {
        private readonly IProductRepository _productRepository;
        public RemoveProductImageCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task Handle(RemoveProductCommand command, CancellationToken cancellationToken)
        {
            var value = await _productRepository.GetByIdAsync(command.Id);
            await _productRepository.DeleteAsync(value);
        }
    }
}
