using Lesson03.Theory.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson03.Theory.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new List<Category>()
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
            //return View(model); Default.cshtml
            return View("_NavBar",model);
        }
    }
}
