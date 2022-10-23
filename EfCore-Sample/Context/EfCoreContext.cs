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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(new Person()
            {
                Id = 1,
                UserName = "Admin",
                Password = "1234"
            });

            modelBuilder.ApplyConfiguration(new PersonMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
