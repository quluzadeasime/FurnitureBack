using Microsoft.AspNetCore.Mvc;

namespace FronttoBackMebel.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
