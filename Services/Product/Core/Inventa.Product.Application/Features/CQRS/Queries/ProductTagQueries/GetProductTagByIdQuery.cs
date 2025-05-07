namespace Inventa.Product.Application.Features.CQRS.Queries.ProductTagQueries
{
    public class GetProductTagByIdQuery
    {
        public Guid Id { get; set; }
        public GetProductTagByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
