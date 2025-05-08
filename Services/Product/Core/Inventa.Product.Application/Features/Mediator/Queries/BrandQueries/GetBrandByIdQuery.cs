using Inventa.Product.Application.Features.Mediator.Results.BrandResults;
using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Queries.BrandQueries
{
    public class GetBrandByIdQuery : IRequest<GetBrandByIdQueryResult>
    {
        public Guid Id { get; set; }
        public GetBrandByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
