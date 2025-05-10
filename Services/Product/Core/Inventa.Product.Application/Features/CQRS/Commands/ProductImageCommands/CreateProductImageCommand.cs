namespace Inventa.Product.Application.Features.CQRS.Commands.ProductImageCommands
{
    public class CreateProductImageCommand
    {
        public Guid ProductId { get; set; }
        public string? ImageUrl { get; set; }
    }
}
