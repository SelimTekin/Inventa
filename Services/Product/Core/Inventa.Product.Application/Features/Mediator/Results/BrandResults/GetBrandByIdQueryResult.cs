namespace Inventa.Product.Application.Features.Mediator.Results.BrandResults
{
    public class GetBrandByIdQueryResult
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Country { get; set; }
        public string? LogoUrl { get; set; }
    }
}
