using Microsoft.AspNetCore.Mvc;

namespace FG_Frontend.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
