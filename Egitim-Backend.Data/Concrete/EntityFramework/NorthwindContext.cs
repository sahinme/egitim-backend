using Egitim_Backend.Entities.Concrete.Categories;
using Egitim_Backend.Entities.Concrete.Courses;
using Egitim_Backend.Entities.Concrete.Educators;
using Egitim_Backend.Entities.Concrete.Tenants;
using Egitim_Backend.Entities.Concrete.Users;
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
        
        public DbSet<Tenant> Tenants { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Educator> Educators { get; set; }

        public DbSet<Course> Courses { get; set; }
        
        public DbSet<CourseContent> CourseContents { get; set; }

        public DbSet<FavoriteCourse> FavoriteCourses { get; set; }
    
        public DbSet<GivenCourse> GivenCourses { get; set; }


    }
}