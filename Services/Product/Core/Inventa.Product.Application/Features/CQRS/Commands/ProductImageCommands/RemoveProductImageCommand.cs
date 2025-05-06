namespace Inventa.Product.Application.Features.CQRS.Commands.ProductImageCommands
{
    public class RemoveProductImageCommand
    {
        public Guid Id { get; set; }

        public RemoveProductImageCommand(Guid id)
        {
            Id = id;
        }
    }
}
