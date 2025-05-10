namespace Inventa.Product.Application.Features.CQRS.Results.TagResults
{
    public class GetTagByIdQueryResult
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}
