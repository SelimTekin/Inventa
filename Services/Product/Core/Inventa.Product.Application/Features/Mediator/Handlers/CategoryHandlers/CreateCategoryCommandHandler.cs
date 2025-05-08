using Inventa.Product.Application.Features.Mediator.Commands.CategoryCommands;
using Inventa.Product.Application.Interfaces;
using Inventa.Product.Domain.Entities;
using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository;
        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            await _categoryRepository.AddAsync(new Category
            {
                Description = request.Description,
                Name = request.Name,
                ParentCategoryId = request.ParentCategoryId,
            });
        }
    }
}
