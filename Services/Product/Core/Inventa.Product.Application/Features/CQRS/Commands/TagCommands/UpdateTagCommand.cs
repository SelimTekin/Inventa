namespace Inventa.Product.Application.Features.CQRS.Commands.TagCommands
{
    public class UpdateTagCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
