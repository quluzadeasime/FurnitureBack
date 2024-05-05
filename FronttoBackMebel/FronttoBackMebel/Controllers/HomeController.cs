using Microsoft.AspNetCore.Mvc;

namespace FronttoBackMebel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
