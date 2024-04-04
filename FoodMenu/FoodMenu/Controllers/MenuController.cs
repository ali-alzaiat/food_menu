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
        public async Task<IActionResult> Details(int? id)
        {
            var item = await _menuContext.Dishes
                .Include(di => di.DishIngredients)
                .ThenInclude(i => i.Ingredient)
                .FirstOrDefaultAsync(i => i.Id == id);
            return View(item);
        }
    }
}
