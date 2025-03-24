using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shopping_api.Model.product;
using shopping_api.Service.product;

namespace shopping_api.Controller.product
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productService.GetProductById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] Product product)
        {
            var createdProduct = await _productService.AddProduct(product);
            return CreatedAtAction(nameof(GetProductById), new { id = createdProduct.Id }, createdProduct);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] Product product)
        {
            if (id != product.Id) return BadRequest("ID không khớp.");
            var updatedProduct = await _productService.UpdateProduct(product);
            return Ok(updatedProduct);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await _productService.DeleteProduct(id);
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpGet("category/{categoryName}")]
        public async Task<IActionResult> GetProductsByCategory(string categoryName)
        {
            var products = await _productService.GetProductsByCategory(categoryName);

            if (products == null || !products.Any())
            {
                return NotFound(new { message = "Không có sản phẩm nào trong danh mục này" });
            }

            return Ok(products);
        }
    }

}
