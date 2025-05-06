namespace Inventa.Product.Application.Features.CQRS.Results.ProductResults
{
    public class GetProductByIdQueryResult
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}
