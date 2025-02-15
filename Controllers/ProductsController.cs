using CraftSite2.Models;
using CraftSite2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace CraftSite2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductsService productsService)
        {
            ProductsService = productsService;
        }
        public JsonFileProductsService ProductsService { get; }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductsService.GetProducts();
        }
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string ProductId,
            [FromQuery] int Rating)
        {
            ProductsService.AddRating(ProductId, Rating);
            return Ok();
        }
    }
}

