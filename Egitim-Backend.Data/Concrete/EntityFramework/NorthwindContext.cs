using Egitim_Backend.Entities.Concrete.Categories;
using Microsoft.EntityFrameworkCore;

namespace Egitim_Backend.Data.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=Egitim;Integrated Security=True");
        }

        public DbSet<Category> Categories { get; set; }
    }
}