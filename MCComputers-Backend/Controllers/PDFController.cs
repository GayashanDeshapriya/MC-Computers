using MCComputers.Data;
using MCComputers.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace MCComputers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PDFController : ControllerBase
    {
        private readonly PDFgenerator _pdfGenerator;
        

        public PDFController(PDFgenerator pdfGenerator)
        {
            this._pdfGenerator = pdfGenerator;
          
        }

        [HttpPost("{InvoiceNumber}")]
        public IActionResult GeneratePdf(string InvoiceNumber)
        {
            byte[] pdfBytes = _pdfGenerator.GeneratorPdf(InvoiceNumber);

            return File(pdfBytes, "application/pdf", "generated.pdf");
        }

    }
}
