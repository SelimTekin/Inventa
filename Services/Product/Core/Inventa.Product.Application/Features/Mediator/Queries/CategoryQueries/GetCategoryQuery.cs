using Inventa.Product.Application.Features.Mediator.Results.CategoryResults;
using MediatR;

namespace Inventa.Product.Application.Features.Mediator.Queries.CategoryQueries
{
    public class GetCategoryQuery : IRequest<List<GetCategoryQueryResult>>
    {
    }
}
