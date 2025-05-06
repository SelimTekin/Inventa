namespace Inventa.Product.Application.Features.Mediator.Commands.BrandCommands
{
    public class RemoveBrandCommand
    {
        public Guid Id { get; set; }

        public RemoveBrandCommand(Guid id)
        {
            Id = id;
        }
    }
}
