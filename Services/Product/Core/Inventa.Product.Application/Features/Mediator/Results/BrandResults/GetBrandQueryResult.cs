namespace Inventa.Product.Application.Features.Mediator.Results.BrandResults
{
    public class GetBrandQueryResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
