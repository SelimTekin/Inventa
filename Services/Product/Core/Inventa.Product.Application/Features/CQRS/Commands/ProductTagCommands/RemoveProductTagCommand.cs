namespace Inventa.Product.Application.Features.CQRS.Commands.ProductTagCommands
{
    public class RemoveProductTagCommand
    {
        public Guid ProductId { get; set; }
        public RemoveProductTagCommand(Guid productId)
        {
            ProductId = productId;
        }
    }
}
