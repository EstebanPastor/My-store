using Microsoft.AspNetCore.Mvc;
using My_Store.Context;

namespace My_Store.Controllers
{
    public class CategoryController(AppDbContext _dbContext) : Controller
    {
        public IActionResult Index()
        {
           var categories = _dbContext.Category.ToList();

            return View(categories);
        }
    }
}
