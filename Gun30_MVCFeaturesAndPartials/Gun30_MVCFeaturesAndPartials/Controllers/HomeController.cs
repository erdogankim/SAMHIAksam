using Gun30_MVCFeaturesAndPartials.Data;
using Gun30_MVCFeaturesAndPartials.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gun30_MVCFeaturesAndPartials.Controllers
{
    public class HomeController : Controller
    {
        NorthwindDbContext _context;
        public HomeController(NorthwindDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            
            return View();
        }
    }
}
