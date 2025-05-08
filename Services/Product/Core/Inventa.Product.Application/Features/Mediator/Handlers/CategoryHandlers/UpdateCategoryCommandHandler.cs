using Inventa.Product.Application.Features.Mediator.Commands.CategoryCommands;
using Inventa.Product.Application.Interfaces;
using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository;
        public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task Handle(UpdateCategoryCommand command, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(command.Id);
            category.Name = command.Name;
            category.Description = command.Description;
            category.ParentCategoryId = command.ParentCategoryId;
            await _categoryRepository.UpdateAsync(category);
        }
    }
}
