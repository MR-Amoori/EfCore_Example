using EfCore_Sample.Mapping;
using EfCore_Sample.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCore_Sample.Context
{
    public class EfCoreContext : DbContext
    {
        public EfCoreContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<PersonInformation> PersonInformation { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<BookToCategories> BookToCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonMapping());
            modelBuilder.ApplyConfiguration(new PersonInformationMapping());

            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new ProductCategoryMapping());

            modelBuilder.ApplyConfiguration(new BookMapping());
            modelBuilder.ApplyConfiguration(new BookCategoryMapping());
            modelBuilder.ApplyConfiguration(new BookToCategoryMapping());

            #region Seed Data
            modelBuilder.Entity<Person>().HasData(new Person()
            {
                Id = 1,
                UserName = "Admin",
                Password = "Mramoori021_@"
            });
            modelBuilder.Entity<PersonInformation>().HasData(new Models.PersonInformation()
            {
                PersonInfoId = 1,
                PersonId = 1,
                Age = 17,
                PhoneNumber = "09035170373"
            });
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
