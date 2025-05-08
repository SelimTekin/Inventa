using Inventa.Product.Application.Features.Mediator.Results.BrandResults;
using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Queries.BrandQueries
{
    public class GetBrandQuery : IRequest<List<GetBrandQueryResult>>
    {
    }
}
