using Gun26_Api_Ornek.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gun26_Api_Ornek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public List<Customer> Get()
        {
            NorthwindContext context = new NorthwindContext();
            return context.Customers.ToList();
        }
    }
}
