using Microsoft.AspNetCore.Mvc;

namespace FG_Frontend.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
