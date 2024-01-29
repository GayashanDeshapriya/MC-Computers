using MCComputers.Data;
using MCComputers.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MCComputers.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/Product (Add a new Product)
        [HttpPost]
        public async Task<ActionResult<ProductModel>> PostProduct(ProductModel product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

           return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
        }

        // GET: api/Products/id
        [HttpGet("{ProductId}")]
        public async Task<ActionResult<ProductModel>> GetProduct(string ProductId)
        {
            var product = await _context.Products.FindAsync(ProductId);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
