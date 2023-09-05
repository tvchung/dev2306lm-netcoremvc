using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Lesson02.Lab.ViewComponents.Models
{
    public class DataContext:DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category() { Id = 1, Name = "Quần Áo" },
                    new Category() { Id = 2, Name = "Túi xách" },
                    new Category() { Id = 3, Name = "Đồng hồ" },
                    new Category() { Id = 1, Name = "Ti vi" },
                    new Category() { Id = 1, Name = "Tủ lạnh" },
                    new Category() { Id = 1, Name = "Máy bơm" },
                    new Category() { Id = 1, Name = "Quạt điện" },
                    new Category() { Id = 1, Name = "Lò sưởi" }
                );
        }
    }
}
