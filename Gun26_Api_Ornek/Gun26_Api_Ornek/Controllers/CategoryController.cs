using Gun26_Api_Ornek.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gun26_Api_Ornek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public List<Category> Get()
        {
            NorthwindContext context = new NorthwindContext();
            var list = context.Categories.ToList();
            return list;
        }

    }
}
