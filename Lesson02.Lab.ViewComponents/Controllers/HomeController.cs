using Lesson02.Lab.ViewComponents.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson02.Lab.ViewComponents.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext db;
        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            this.db = context;
            db.Database.EnsureCreated();
        }

        public IActionResult Index()
        {
            var model = db.Category.ToList();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}