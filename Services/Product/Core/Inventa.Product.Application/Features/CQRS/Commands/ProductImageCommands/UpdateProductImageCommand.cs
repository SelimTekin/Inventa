namespace Inventa.Product.Application.Features.CQRS.Commands.ProductImageCommands
{
    public class UpdateProductImageCommand
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}
