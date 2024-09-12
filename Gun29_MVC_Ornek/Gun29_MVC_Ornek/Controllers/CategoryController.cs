using Gun29_MVC_Ornek.Data;
using Microsoft.AspNetCore.Mvc;

namespace Gun29_MVC_Ornek.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            NorthwindDbContext context = new NorthwindDbContext();
            var list = context.Categories.ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            NorthwindDbContext context = new NorthwindDbContext();
            var item = context.Categories.FirstOrDefault(x=>x.CategoryID == id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            NorthwindDbContext context = new NorthwindDbContext();
            var item = context.Categories.FirstOrDefault(x => x.CategoryID == category.CategoryID);
            item.CategoryName = category.CategoryName;
            item.Description = category.Description;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
