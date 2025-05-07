namespace Inventa.Product.Domain.Entities
{
    public class ProductTag
    {
        public Guid ProductId { get; set; }
        public Guid TagId { get; set; }

        public ProductEntity? Product { get; set; }
        public Tag? Tag { get; set; }
    }
}
