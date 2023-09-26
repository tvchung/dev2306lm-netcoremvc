using Lesson06.TheoryCF.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Lesson06.TheoryCF.Models.BusinessModels
{
    public class BookManagementContext:DbContext
    {
        public BookManagementContext(DbContextOptions<BookManagementContext> options) : base(options)
        {

        }
        // Khai báo các thuộc tính biểu diễn tập thực thể
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
