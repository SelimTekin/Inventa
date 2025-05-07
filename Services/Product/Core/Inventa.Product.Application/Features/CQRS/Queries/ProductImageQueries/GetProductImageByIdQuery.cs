namespace Inventa.Product.Application.Features.CQRS.Queries.ProductImageQueries
{
    public class GetProductImageByIdQuery
    {
        public Guid Id { get; set; }
        public GetProductImageByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
