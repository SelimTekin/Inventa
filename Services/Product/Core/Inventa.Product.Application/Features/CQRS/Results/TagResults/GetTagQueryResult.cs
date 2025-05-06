namespace Inventa.Product.Application.Features.CQRS.Results.TagResults
{
    public class GetTagQueryResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
