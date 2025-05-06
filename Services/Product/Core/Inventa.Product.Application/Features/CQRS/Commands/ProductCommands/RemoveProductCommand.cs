namespace Inventa.Product.Application.Features.CQRS.Commands.ProductCommands
{
    public class RemoveProductCommand
    {
        public Guid Id { get; set; }

        public RemoveProductCommand(Guid id)
        {
            Id = id;
        }
    }
}
