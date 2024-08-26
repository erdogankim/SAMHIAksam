using Microsoft.AspNetCore.Mvc;

namespace Gun28_Web_MVC.Controllers
{
    public class StudentController : Controller
    {
        public string Add()
        {
            return "Ekle methodu çalıştı";
        }

        public string Update(int id)
        {
            int carpim = id * id;
            return "Çarpım değeri = " + carpim;
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}