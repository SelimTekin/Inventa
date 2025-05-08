using Inventa.Product.Application.Features.CQRS.Commands.ProductTagCommands;
using Inventa.Product.Application.Interfaces;

namespace Inventa.Product.Application.Features.CQRS.Handlers.ProductTagHandlers
{
    public class RemoveProductTagCommandHandler
    {
        private readonly IProductTagRepository _productTagRepository;
        public RemoveProductTagCommandHandler(IProductTagRepository productTagRepository)
        {
            _productTagRepository = productTagRepository;
        }
        public async Task Handle(RemoveProductTagCommand request, CancellationToken cancellationToken)
        {
            var value = await _productTagRepository.GetByIdAsync(request.ProductId);
            await _productTagRepository.DeleteAsync(value);
        }
    }
}
