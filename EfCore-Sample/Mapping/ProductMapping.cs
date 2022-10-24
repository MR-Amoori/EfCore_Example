using EfCore_Sample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore_Sample.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();

            builder.HasOne(x => x.ProductCategory).WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
