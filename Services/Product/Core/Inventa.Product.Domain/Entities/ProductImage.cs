namespace Inventa.Product.Domain.Entities
{
    public class ProductImage
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ProductId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

        public ProductEntity? Product { get; set; }
    }
}
