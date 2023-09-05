using Lesson03.Review.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson03.Review.Controllers
{
    public class ProductController : Controller
    {
        private List<Category> lstCategory = new List<Category>()
        {
            new Category(){Id=1,Name="Quần Áo"},
            new Category(){Id=2,Name="Túi xách"},
            new Category(){Id=3,Name="Đồng hồ"},
            new Category(){Id=4,Name="Ti vi"},
            new Category(){Id=5,Name="Tủ lạnh"},
            new Category(){Id=6,Name="Máy bơm"},
            new Category(){Id=7,Name="Quạt điện"},
            new Category(){Id=8,Name="Lò sưởi"}
        };

        private List<Product> lstProduct = new List<Product>()
        {
             new Product(){Id=1, Name="Bộ đồ bơi cho trẻ em nam",Image="/Images/img1.jpg",Price=50000,SalePrice=35000,Description="Bộ đồ bơi cho trẻ em nam",Status=true,CategoryId=1},
            new Product(){Id=1, Name="Bộ đồ bơi cho trẻ em nữ",Image="/Images/img2.jpg",Price=50000,SalePrice=35000,Description="Bộ đồ bơi cho trẻ em nữ",Status=true,CategoryId=1},
            new Product(){Id=1, Name="Bộ đồ bơi cho trẻ từ 3-5 tuổi",Image="/Images/img1.jpg",Price=50000,SalePrice=35000,Description="Bộ đồ bơi cho trẻ em từ 3-5 tuổi",Status=true,CategoryId=1},
            new Product(){Id=1, Name="Bộ đồ bơi cho trẻ em thời trang",Image="/Images/img2.jpg",Price=50000,SalePrice=35000,Description="Bộ đồ bơi cho trẻ em thời trang",Status=true,CategoryId=1},
            new Product(){Id=1, Name="Túi thời trang mẫu mới 2023",Image="/Images/img1.jpg",Price=50000,SalePrice=35000,Description="Túi thời trang mẫu mới 2023",Status=true,CategoryId=2},
            new Product(){Id=1, Name="Túi thời trang da cá sấu",Image="/Images/img2.jpg",Price=50000,SalePrice=35000,Description="Túi thời trang da cá sấu",Status=true,CategoryId=2},
            new Product(){Id=1, Name="Túi thời trang da cá sấu 2023",Image="/Images/img1.jpg",Price=50000,SalePrice=35000,Description="Túi thời trang da cá sấu 2023",Status=true,CategoryId=2}

        };

        public IActionResult Index(int? id)
        {
            ViewBag.Categories = lstCategory;
            if(id != null)
            {
                lstProduct = lstProduct.Where(x => x.CategoryId == id.Value).ToList();
            }
            ViewBag.Products = lstProduct;
            return View();
        }
    }
}
