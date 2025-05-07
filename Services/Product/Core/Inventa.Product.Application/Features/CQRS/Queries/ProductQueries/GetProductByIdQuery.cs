namespace Inventa.Product.Application.Features.CQRS.Queries.ProductQueries
{
    public class GetProductByIdQuery
    {
        public Guid Id { get; set; }
        public GetProductByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
