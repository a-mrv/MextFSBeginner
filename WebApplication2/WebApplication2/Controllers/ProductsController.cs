using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
        [HttpGet]
        static List<Product> GetAll()
        {
        return Product;
        }
    [HttpPut]
     public void Update (Guid Id, )
    }

}
