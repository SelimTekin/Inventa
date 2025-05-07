namespace Inventa.Product.Application.Features.CQRS.Queries.TagQueries
{
    public class GetTagByIdQuery
    {
        public Guid Id { get; set; }
        public GetTagByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
