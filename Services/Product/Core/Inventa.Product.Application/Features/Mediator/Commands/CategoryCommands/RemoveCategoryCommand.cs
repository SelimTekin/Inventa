using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Commands.CategoryCommands
{
    public class RemoveCategoryCommand : IRequest
    {
        public Guid Id { get; set; }

        public RemoveCategoryCommand(Guid id)
        {
            Id = id;
        }
    }
}
