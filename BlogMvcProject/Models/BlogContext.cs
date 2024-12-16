using Microsoft.EntityFrameworkCore;

namespace BlogMvcApp.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Örnek: Varsayılan veri ekleme (seeding)
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Technology" },
                new Category { CategoryId = 2, CategoryName = "Lifestyle" }
            );

        }
    }
}