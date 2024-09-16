using Gun30_MVCFeaturesAndPartials.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gun30_MVCFeaturesAndPartials.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
