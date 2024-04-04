using FoodMenu.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodMenu.Controllers
{
    public class MenuController : Controller
    {
        private readonly MenuContext _menuContext;
        public MenuController(MenuContext menuContext)
        {
            _menuContext = menuContext;  
        }
        public async Task<IActionResult> Index()
        {
            return View(await _menuContext.Dishes.ToListAsync());
        }
    }
}
