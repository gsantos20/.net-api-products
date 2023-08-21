using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Models;
using ProductsAPI.Services;

namespace ProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Product>), 200)]
        public async Task<IActionResult> Get()
        {

            var result = await _productService.List();

            return Ok(new { Success = true, Data = result });
        }


        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Product), 200)]
        public async Task<IActionResult> Post([FromBody] ProductCreation product)
        {
            var result = await _productService.Create(product);

            return Ok(new { Success = true, Data = result });
        }

        [HttpPut("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Product), 200)]
        public async Task<IActionResult> Put(int id, [FromBody] ProductCreation product)
        {
            var result = await _productService.Update(id, product);

            return Ok(new { Success = true, Data = result });
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), 200)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _productService.Delete(id);

            return Ok(new { Success = true, Data = result });
        }


    }
}
















