namespace Inventa.Product.Application.Features.CQRS.Results.ProductTagResults
{
    public class GetProductTagByIdQueryResult
    {
        public Guid ProductId { get; set; }
        public Guid TagId { get; set; }
    }
}
