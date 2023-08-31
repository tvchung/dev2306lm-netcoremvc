using Lesson02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson02.Controllers
{
    [Route("danh-sach")]
    public class ProductController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            // Chuyển dữ liệu từ controller ra view
            ViewData["messageVD"] = "Dữ liệu lưu trong ViewData";
            ViewBag.messageVB = "Dữ liệu lưu trong ViewBag";
            TempData["messageTD"] = "Dữ liệu lưu trong TempData";
            return View(); // Views/Product/Index.cshtml
        }

        [Route("get-product")]
        public IActionResult GetProduct()
        {
            // Truyền dữ liệu dạng object ra view
            Product product = new Product()
            {
                productId=1, productName="Trek 820-2016",yearRelease= 2016, price=379.99
            };
            ViewBag.product = product;
            ViewData["product"] = product;
            return View("Product");
        }
        [Route("list-product")]
        // Truyền dữ liệu dạng collection ra view
        public IActionResult ListProduct(int? id)
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ productId = 1,productName="Trek 820 - 2016", yearRelease=2016, price=379.99},
                new Product(){ productId = 2,productName="Ritchay Timberwolf Frameset - 2016", yearRelease=2016, price=749.99},
                new Product(){ productId = 3,productName="Surly Wednesday Frameset - 2016", yearRelease=2016, price=999.99},
                new Product(){ productId = 4,productName="Trek Fuel EX 8 29 - 2016", yearRelease=2016, price=2899.99},
                new Product(){ productId = 5,productName="Heller Shagamaw Frame - 2016", yearRelease=2016, price=1320.99},
                new Product(){ productId = 6,productName="Surly Ice Cream Truck Frameset - 2016", yearRelease=2016, price=469.99},
                new Product(){ productId = 7,productName="Trek Slash 8 27.5 - 2016", yearRelease=2016, price=3999.99},
                new Product(){ productId = 8,productName="Trek Remedy 29 Carbon Frameset - 2016", yearRelease=2016, price=1799.99},
                new Product(){ productId = 9,productName="Trek Conduit+ - 2016", yearRelease=2016, price=2999.99},
                new Product(){ productId = 10,productName="Surly Straggler - 2016", yearRelease=2016, price=1549.0},
                new Product(){ productId = 11,productName="Surly Straggler 650b - 2016", yearRelease=2016, price=1680.99},
                new Product(){ productId = 12,productName= "Electra Townie Original 21D - 2016", yearRelease = 2016, price = 549.99},
                new Product(){ productId = 13,productName= "Electra Cruiser 1 (24-Inch) - 2016", yearRelease = 2016, price = 269.99},
                new Product(){ productId = 14,productName= "Electra Girl's Hawaii 1 (16-inch) - 2015/2016", yearRelease = 2016, price = 269.99},
            };
            if(id != null)
            {
                products = products.Where(x => x.productId == id).ToList();
            }
            ViewBag.products = products;
            return View();
        }

        // Json
        [Route("get-list-product")]
        public IActionResult GetListProduct(int? id)
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ productId = 1,productName="Trek 820 - 2016", yearRelease=2016, price=379.99},
                new Product(){ productId = 2,productName="Ritchay Timberwolf Frameset - 2016", yearRelease=2016, price=749.99},
                new Product(){ productId = 3,productName="Surly Wednesday Frameset - 2016", yearRelease=2016, price=999.99},
                new Product(){ productId = 4,productName="Trek Fuel EX 8 29 - 2016", yearRelease=2016, price=2899.99},
                new Product(){ productId = 5,productName="Heller Shagamaw Frame - 2016", yearRelease=2016, price=1320.99},
                new Product(){ productId = 6,productName="Surly Ice Cream Truck Frameset - 2016", yearRelease=2016, price=469.99},
                new Product(){ productId = 7,productName="Trek Slash 8 27.5 - 2016", yearRelease=2016, price=3999.99},
                new Product(){ productId = 8,productName="Trek Remedy 29 Carbon Frameset - 2016", yearRelease=2016, price=1799.99},
                new Product(){ productId = 9,productName="Trek Conduit+ - 2016", yearRelease=2016, price=2999.99},
                new Product(){ productId = 10,productName="Surly Straggler - 2016", yearRelease=2016, price=1549.0},
                new Product(){ productId = 11,productName="Surly Straggler 650b - 2016", yearRelease=2016, price=1680.99},
                new Product(){ productId = 12,productName= "Electra Townie Original 21D - 2016", yearRelease = 2016, price = 549.99},
                new Product(){ productId = 13,productName= "Electra Cruiser 1 (24-Inch) - 2016", yearRelease = 2016, price = 269.99},
                new Product(){ productId = 14,productName= "Electra Girl's Hawaii 1 (16-inch) - 2015/2016", yearRelease = 2016, price = 269.99},
            };
            if(id != null)
            {
                products = products.Where(x => x.productId == id).ToList();
            }
            return Json(products);
        }
    }
}
