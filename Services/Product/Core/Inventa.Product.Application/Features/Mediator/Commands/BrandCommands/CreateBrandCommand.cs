namespace Inventa.Product.Application.Features.Mediator.Commands.BrandCommands
{
    public class CreateBrandCommand
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
