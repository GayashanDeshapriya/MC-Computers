using DinkToPdf;
using DinkToPdf.Contracts;
using MCComputers.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace MCComputers.Services
{
    public class PDFgenerator
    {
        private readonly IConverter _converter;
        private readonly AppDbContext _context;

        public PDFgenerator(IConverter converter , AppDbContext context)
        {
            this._converter = converter;
            _context = context;
        }

        // generate pdf html 
        public byte[] GeneratorPdf(string InvoiceNumber)
        {

            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10, Bottom = 10, Left = 10, Right = 10 },
                DocumentTitle = "Generated PDF"
            };

            //Fetch the data from the database
            var InvoiceRawData = _context.Invoices.Find(InvoiceNumber);

            if(InvoiceRawData == null )
            {
                throw new Exception($"Row with primary key {InvoiceNumber} not found.");
            }

            var invoiceTable = "<table border='1'><tr><th>Invoice Number</th><th>Customer Name</th></tr>";

            // Add the specific row to the HTML table
            invoiceTable += $"<tr><td>{InvoiceRawData.InvoiceNumber}</td><td>{InvoiceRawData.CustomerName}</td></tr>";
            // Add more columns as needed

            invoiceTable += "</table>";

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = $@"<html><body>{invoiceTable}</body></html>", // Include the table data in the HTML content
                // ... (rest of your existing code)
            };

            var document = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            return _converter.Convert(document);
        }

    }
}
