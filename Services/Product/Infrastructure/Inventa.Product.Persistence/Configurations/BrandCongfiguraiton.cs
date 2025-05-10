using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Inventa.Product.Domain.Entities;

namespace Inventa.Product.Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                   .HasMaxLength(100);

            builder.Property(b => b.Description)
                   .HasMaxLength(1000);

            builder.Property(b => b.Country)
                   .HasMaxLength(100);

            builder.Property(b => b.LogoUrl)
                   .HasMaxLength(500);

            builder.HasMany(b => b.Products)
                   .WithOne(p => p.Brand)
                   .HasForeignKey(p => p.BrandId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
