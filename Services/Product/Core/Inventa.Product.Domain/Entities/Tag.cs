namespace Inventa.Product.Domain.Entities
{
    public class Tag
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }

        public List<ProductTag>? ProductTags { get; set; }
    }
}
