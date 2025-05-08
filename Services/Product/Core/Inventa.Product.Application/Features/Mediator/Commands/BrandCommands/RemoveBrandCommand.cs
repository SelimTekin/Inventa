using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Commands.BrandCommands
{
    public class RemoveBrandCommand : IRequest
    {
        public Guid Id { get; set; }

        public RemoveBrandCommand(Guid id)
        {
            Id = id;
        }
    }
}
