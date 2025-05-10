using Inventa.Product.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventa.Product.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                  .HasMaxLength(150);

            builder.Property(p => p.Description)
                  .HasMaxLength(1000);

            builder.Property(p => p.Price)
                  .HasPrecision(18, 2);

            builder.Property(p => p.StockQuantity)
                  .HasDefaultValue(0);

            builder.Property(p => p.SKU)
                  .HasMaxLength(50);

            builder.HasIndex(p => p.SKU)
                  .IsUnique();

            builder.Property(p => p.Barcode)
                  .HasMaxLength(100);

            builder.Property(p => p.IsActive)
                  .HasDefaultValue(true);

            builder.Property(p => p.CreatedAt)
                  .HasDefaultValueSql("GETUTCDATE()");

            builder.HasOne(p => p.Category)
                  .WithMany(c => c.Products)
                  .HasForeignKey(p => p.CategoryId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Brand)
                  .WithMany()
                  .HasForeignKey(p => p.BrandId)
                  .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
