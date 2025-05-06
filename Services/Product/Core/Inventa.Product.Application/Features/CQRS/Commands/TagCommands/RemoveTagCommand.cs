namespace Inventa.Product.Application.Features.CQRS.Commands.TagCommands
{
    public class RemoveTagCommand
    {
        public Guid Id { get; set; }

        public RemoveTagCommand(Guid id)
        {
            Id = id;
        }
    }
}
