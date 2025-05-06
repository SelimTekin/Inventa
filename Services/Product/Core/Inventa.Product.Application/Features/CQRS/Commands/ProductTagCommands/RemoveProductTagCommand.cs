namespace Inventa.Product.Application.Features.CQRS.Commands.ProductTagCommands
{
    public class RemoveProductTagCommand
    {
        public Guid ProductId { get; set; }
        public Guid TagId { get; set; }

        public RemoveProductTagCommand(Guid productId, Guid tagId)
        {
            ProductId = productId;
            TagId = tagId;
        }
    }
}
