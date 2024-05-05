using FronttoBackMebel.Models;
using Microsoft.AspNetCore.Mvc;

namespace FronttoBackMebel.Controllers
{
    public class OurDesignController : Controller
    {
        public IActionResult Index()
        {
            var furnitureList = new List<Furniture>
            {
            new Furniture { Name = "Chair 1", ImageUrl = "~/images/img-3.png", Price = 100 },
            new Furniture { Name = "Chair 2", ImageUrl = "~/images/img-1.png", Price = 200 },
            new Furniture { Name = "Chair 3", ImageUrl = "~/images/img-2.png", Price = 300 },
            new Furniture { Name = "Chair 4", ImageUrl = "~/images/img-3.png", Price = 400 },
            new Furniture { Name = "Chair 5", ImageUrl = "~/images/img-1.png", Price = 500 },
            new Furniture { Name = "Chair 6", ImageUrl = "~/images/img-2.png", Price = 600 },
            new Furniture { Name = "Chair 7", ImageUrl = "~/images/img-2.png", Price = 700 },
            new Furniture { Name = "Chair 8", ImageUrl = "~/images/img-1.png", Price = 800 },
            new Furniture { Name = "Chair 9", ImageUrl = "~/images/img-3.png", Price = 900 }
            };

            ViewBag.FurnitureList = furnitureList;
            return View();
        }
    }
}
