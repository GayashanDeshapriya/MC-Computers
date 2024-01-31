using MCComputers.Data;
using MCComputers.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;




namespace MCComputers.InvoicesController

{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InvoicesController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/Invoices
        [HttpPost]
        public async Task<ActionResult<InvoiceModel>> PostInvoice(InvoiceModel invoice)
        {
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvoice", new { id = invoice.InvoiceNumber }, invoice);
        }

        // GET: api/Invoices
        [HttpGet]
        public async Task<ActionResult<List<InvoiceModel>>> GetInvoice()
        {
            var invoice = await _context.Invoices.ToListAsync();

            if (invoice == null)
            {
                return NotFound();
            }

            return Ok(invoice);
        }
        // GET: api/Invoices/id
        [HttpGet("{InvoiceNumber}")]
        public async Task<ActionResult<InvoiceModel>> GetInvoice(string InvoiceNumber)
        {
            var invoice = await _context.Invoices.FindAsync(InvoiceNumber);

            if (invoice == null)
            {
                return NotFound();
            }

            return Ok(invoice);
        }


    }
}
