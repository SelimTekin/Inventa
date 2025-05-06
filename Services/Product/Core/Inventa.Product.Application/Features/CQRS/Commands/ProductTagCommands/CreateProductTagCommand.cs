namespace Inventa.Product.Application.Features.CQRS.Commands.ProductTagCommands
{
    public class CreateProductTagCommand
    {
        public Guid ProductId { get; set; }
        public Guid TagId { get; set; }
    }
}
