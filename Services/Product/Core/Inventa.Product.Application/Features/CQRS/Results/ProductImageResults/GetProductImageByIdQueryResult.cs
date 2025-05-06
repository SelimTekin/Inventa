namespace Inventa.Product.Application.Features.CQRS.Results.ProductImageResults
{
    public class GetProductImageByIdQueryResult
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}
