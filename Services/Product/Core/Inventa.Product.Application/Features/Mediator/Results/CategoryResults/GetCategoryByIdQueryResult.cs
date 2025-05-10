namespace Inventa.Product.Application.Features.Mediator.Results.CategoryResults
{
    public class GetCategoryByIdQueryResult
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Guid? ParentCategoryId { get; set; }
    }
}
