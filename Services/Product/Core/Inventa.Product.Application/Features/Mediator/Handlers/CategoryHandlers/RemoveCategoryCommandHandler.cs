using Inventa.Product.Application.Features.Mediator.Commands.CategoryCommands;
using Inventa.Product.Application.Interfaces;
using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler : IRequestHandler<RemoveCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository;
        public RemoveCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
        {
            var value = await _categoryRepository.GetByIdAsync(request.Id);
            await _categoryRepository.DeleteAsync(value);
        }
    }
}
