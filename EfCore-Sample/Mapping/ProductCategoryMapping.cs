using EfCore_Sample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore_Sample.Mapping
{
    public class ProductCategoryMapping : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategories");

            builder.HasKey(x => x.CategoryId);

            builder.HasMany(x => x.Products).WithOne(x => x.ProductCategory)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
