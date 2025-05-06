namespace Inventa.Product.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public Guid? ParentCategoryId { get; set; }

        public Category? ParentCategory { get; set; }
        public List<Category>? SubCategories { get; set; }
        public List<Product>? Products { get; set; }
    }
}
