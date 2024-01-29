using MCComputers.Data;
using MCComputers.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MCComputers.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/Product (Add a new Product)
        [HttpPost]
        public async Task<ActionResult<ProductModel>> PostCustomer(ProductModel product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

           return CreatedAtAction("Add a new Product", new { id = product.ProductId }, product);
        }
    }
}
