namespace Inventa.Product.Domain.Entities
{
    public class Brand
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Country { get; set; }
        public string? LogoUrl { get; set; }

        public List<ProductEntity>? Products { get; set; }
    }
}
