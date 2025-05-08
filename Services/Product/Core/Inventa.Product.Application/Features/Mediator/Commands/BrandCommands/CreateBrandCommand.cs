using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Commands.BrandCommands
{
    public class CreateBrandCommand : IRequest
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
