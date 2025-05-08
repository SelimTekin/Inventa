namespace Inventa.Product.Application.Features.CQRS.Commands.ProductTagCommands
{
    public class GetProductTagCommand
    {
        public Guid ProductId { get; set; }
        public Guid TagId { get; set; }
    }
}
