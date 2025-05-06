namespace Inventa.Product.Application.Features.Mediator.Commands.BrandCommands
{
    public class UpdateBrandCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
