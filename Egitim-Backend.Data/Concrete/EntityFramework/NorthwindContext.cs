using Egitim_Backend.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Egitim_Backend.Data.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"DESKTOP-5LD89I3\SQLEXPRESS;Database=Egitim;Trusted_Connection=True");
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}