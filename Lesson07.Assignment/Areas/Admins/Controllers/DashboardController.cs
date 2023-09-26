using Microsoft.AspNetCore.Mvc;

namespace Lesson07.Assignment.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
