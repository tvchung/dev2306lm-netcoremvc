using Lesson02.Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lesson02.Assignment1.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {

        public async  Task<IViewComponentResult> InvokeAsync()
        {
            var data = new List<Category>() { 
                    new Category() { Id = 1, Name = "Quần Áo" },
                   new Category() { Id = 2, Name = "Túi xách" },
                   new Category() { Id = 3, Name = "Đồng hồ" },
                   new Category() { Id = 4, Name = "Ti vi" },
                   new Category() { Id = 5, Name = "Tủ lạnh" },
                   new Category() { Id = 6, Name = "Máy bơm" },
                   new Category() { Id = 7, Name = "Quạt điện" },
                   new Category() { Id = 8, Name = "Lò sưởi" }
            };
            return View("_Menu",data);
        }
    }
}
