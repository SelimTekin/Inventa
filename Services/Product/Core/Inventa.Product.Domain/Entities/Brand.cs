namespace Inventa.Product.Domain.Entities
{
    public class Brand
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public List<Product>? Products { get; set; }
    }
}
