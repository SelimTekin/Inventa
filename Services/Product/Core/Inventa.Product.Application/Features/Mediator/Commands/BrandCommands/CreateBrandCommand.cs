using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Commands.BrandCommands
{
    public class CreateBrandCommand : IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Country { get; set; }
        public string? LogoUrl { get; set; }
    }
}
