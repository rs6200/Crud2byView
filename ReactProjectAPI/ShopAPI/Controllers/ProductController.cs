using Microsoft.AspNetCore.Mvc;

namespace ShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        [HttpGet]
        //[Route,["conrolers"]]
        public string Get() {
            return "Hello World";
                }
    }
}
