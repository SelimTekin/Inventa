namespace Inventa.Product.Application.Features.Mediator.Results.BrandResults
{
    public class GetBrandByIdQueryResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
