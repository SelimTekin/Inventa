namespace Inventa.Product.Domain.Entities
{
    public class ProductEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string? SKU { get; set; } // Stock Keeping Unit
        public string? Barcode { get; set; }
        public Guid CategoryId { get; set; }
        public Guid BrandId { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Category? Category { get; set; }
        public Brand? Brand { get; set; }
        public List<ProductImage>? ProductImages { get; set; }
        public List<ProductTag>? ProductTags { get; set; }
    }
}
