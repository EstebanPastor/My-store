using Microsoft.AspNetCore.Mvc;
using My_Store.Services;

namespace My_Store.Controllers
{
    public class CategoryController(CategoryService _categoryService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();

            return View(categories);
        }
    }
}
