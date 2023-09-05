using Lesson02.Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson02.Assignment1.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> listProduct = new List<Product>()
        {
            new Product(){Id=1, Name="Bộ đồ bơi cho trẻ em nam",Image="~/Images/img1.jpg",Price=50000,SalePrice=35000,Description="Bộ đồ bơi cho trẻ em nam",Status=true,CategoryId=1},
            new Product(){Id=1, Name="Bộ đồ bơi cho trẻ em nữ",Image="~/Images/img2.jpg",Price=50000,SalePrice=35000,Description="Bộ đồ bơi cho trẻ em nữ",Status=true,CategoryId=1},
            new Product(){Id=1, Name="Bộ đồ bơi cho trẻ từ 3-5 tuổi",Image="~/Images/img3.jpg",Price=50000,SalePrice=35000,Description="Bộ đồ bơi cho trẻ em từ 3-5 tuổi",Status=true,CategoryId=1},
            new Product(){Id=1, Name="Bộ đồ bơi cho trẻ em thời trang",Image="~/Images/img4.jpg",Price=50000,SalePrice=35000,Description="Bộ đồ bơi cho trẻ em thời trang",Status=true,CategoryId=1},
            new Product(){Id=1, Name="Túi thời trang mẫu mới 2023",Image="~/Images/img5.jpg",Price=50000,SalePrice=35000,Description="Túi thời trang mẫu mới 2023",Status=true,CategoryId=2},
            new Product(){Id=1, Name="Túi thời trang da cá sấu",Image="~/Images/img6.jpg",Price=50000,SalePrice=35000,Description="Túi thời trang da cá sấu",Status=true,CategoryId=2},
            new Product(){Id=1, Name="Túi thời trang da cá sấu 2023",Image="~/Images/img7.jpg",Price=50000,SalePrice=35000,Description="Túi thời trang da cá sấu 2023",Status=true,CategoryId=2}
        };
        public IActionResult Index(int? id)
        {
            var data = listProduct.ToList();
            if (id != null)
                data = data.Where(x => x.CategoryId == id.Value).ToList() ;

            ViewBag.Id = id;

            return View(data);
        }
    }
}
