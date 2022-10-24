using EfCore_Sample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore_Sample.Mapping
{
    public class BookToCategoryMapping : IEntityTypeConfiguration<BookToCategories>
    {
        public void Configure(EntityTypeBuilder<BookToCategories> builder)
        {
            builder.ToTable("BookToCategories");

            builder.HasKey(x => new { x.BookId, x.CategoryId });

            builder.HasOne(x => x.Book).WithMany(x => x.BookToCategories)
                .HasForeignKey(x => x.BookId);

            builder.HasOne(x => x.BookCategory).WithMany(x => x.BookToCategories)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
