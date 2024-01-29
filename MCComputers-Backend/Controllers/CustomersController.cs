using MCComputers.Data;
using MCComputers.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MCComputers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomersController(AppDbContext context)
        {
            _context = context;
        }

        // POST: Customer (Add a new customer)
        [HttpPost]
        public async Task<ActionResult<CustomerModel>> PostCustomer(CustomerModel customer)
        {
            try
            {
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetCustomer", new { id = customer.CustomerId }, customer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        // GET: Customers (get all customers)
        [HttpGet]
        public async Task<ActionResult<List<CustomerModel>>> GetCustomers()
        {
            var customer = await _context.Invoices.ToListAsync();

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }


    }
    
}
