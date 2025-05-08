namespace Inventa.Product.Application.Features.CQRS.Commands.ProductTagCommands
{
    public class GetProductTagByIdCommand
    {
        public Guid ProductId { get; set; }
        public Guid TagId { get; set; }
    }
}
