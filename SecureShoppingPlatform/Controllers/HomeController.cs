using Microsoft.AspNetCore.Mvc;

namespace SecureShoppingPlatform.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}