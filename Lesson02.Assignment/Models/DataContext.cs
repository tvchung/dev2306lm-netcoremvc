using Microsoft.EntityFrameworkCore;

namespace Lesson02.Assignment.Models
{
    public class DataContext: DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options)
             : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        //The below is used to seeding the DB
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
            modelBuilder.Entity<Product>().HasData(
                    new Product() { Id = 1, Name = "Bộ đồ bơi cho trẻ em nam", Image = "~/Images/img1.jpg", Price = 50000, SalePrice = 35000, Description = "Bộ đồ bơi cho trẻ em nam", Status = true, CategoryId = 1 },
                    new Product() { Id = 1, Name = "Bộ đồ bơi cho trẻ em nữ", Image = "~/Images/img2.jpg", Price = 50000, SalePrice = 35000, Description = "Bộ đồ bơi cho trẻ em nữ", Status = true, CategoryId = 1 },
                    new Product() { Id = 1, Name = "Bộ đồ bơi cho trẻ từ 3-5 tuổi", Image = "~/Images/img3.jpg", Price = 50000, SalePrice = 35000, Description = "Bộ đồ bơi cho trẻ em từ 3-5 tuổi", Status = true, CategoryId = 1 },
                    new Product() { Id = 1, Name = "Bộ đồ bơi cho trẻ em thời trang", Image = "~/Images/img4.jpg", Price = 50000, SalePrice = 35000, Description = "Bộ đồ bơi cho trẻ em thời trang", Status = true, CategoryId = 1 },
                    new Product() { Id = 1, Name = "Túi thời trang mẫu mới 2023", Image = "~/Images/img5.jpg", Price = 50000, SalePrice = 35000, Description = "Túi thời trang mẫu mới 2023", Status = true, CategoryId = 2 },
                    new Product() { Id = 1, Name = "Túi thời trang da cá sấu", Image = "~/Images/img6.jpg", Price = 50000, SalePrice = 35000, Description = "Túi thời trang da cá sấu", Status = true, CategoryId = 2 },
                    new Product() { Id = 1, Name = "Túi thời trang da cá sấu 2023", Image = "~/Images/img7.jpg", Price = 50000, SalePrice = 35000, Description = "Túi thời trang da cá sấu 2023", Status = true, CategoryId = 2 }
                );
        }
    }
}
