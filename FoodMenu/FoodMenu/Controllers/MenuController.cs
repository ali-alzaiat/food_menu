using Microsoft.AspNetCore.Mvc;

namespace FoodMenu.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
