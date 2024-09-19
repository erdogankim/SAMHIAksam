using Gun30_MVCFeaturesAndPartials.Data;
using Microsoft.AspNetCore.Mvc;

namespace Gun30_MVCFeaturesAndPartials.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindDbContext _context;

        public CategoryController(NorthwindDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();

            return View(categories);
        }
    }
}