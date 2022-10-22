using EfCore_Sample.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCore_Sample.Context
{
    public class EfCoreContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public EfCoreContext(DbContextOptions options) : base(options)
        {

        }
    }
}
