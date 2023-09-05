using Lesson02.Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;





namespace Lesson02.Assignment.ViewComponents
{
    public class MenuViewComponent: ViewComponent
    {
        private readonly DataContext db;
        public MenuViewComponent(DataContext context)
        {
            db = context;
        }
        private  Task<List<Category>> GetItemsAsync()
        {
            return db.Category.ToListAsync();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listMenu = await GetItemsAsync();
            return View("_Index",listMenu);
        }
    }
}
