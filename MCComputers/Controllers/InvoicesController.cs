using MCComputers.Data;
using MCComputers.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

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
        public async Task<ActionResult<Invoices>> PostInvoice(Invoices invoice)
        {
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvoice", new { id = invoice.InvoiceID }, invoice);
        }

        // GET: api/Invoices/id
        [HttpGet]
        public async Task<ActionResult<List<Invoices>>> GetInvoice()
        {
            var invoice = await _context.Invoices.ToListAsync();

            if (invoice == null)
            {
                return NotFound();
            }

            return Ok(invoice);
        }
    }
}
