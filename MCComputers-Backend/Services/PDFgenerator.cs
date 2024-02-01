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
                PaperSize = PaperKind.A6Rotated,
                Margins = new MarginSettings { Top = 10, Bottom = 5, Left = 10, Right = 10 },
                DocumentTitle = "Generated PDF"
            };

            //Fetch the data from the database
            var InvoiceRawData = _context.Invoices.Find(InvoiceNumber);

            if (InvoiceRawData == null)
            {
                throw new Exception($"Row with primary key {InvoiceNumber} not found.");
            }

            var invoiceTable = "<table><tr><th>Invoice Number</th><th>Customer Name</th><th>Product Name</th><th>Transaction Date</th><th>Discount</th><th>Quantity</th><th>Total Amount</th><th>Balance Amount</th></tr>";

            // Add the specific row to the HTML table
            invoiceTable += $"<tr><td>{InvoiceRawData.InvoiceNumber}</td>" +
                            $"<td>{InvoiceRawData.CustomerName}</td>" +
                            $"<td>{InvoiceRawData.ProductName}</td>" +
                            $"<td>{InvoiceRawData.TransactionDate}</td>" +
                            $"<td>{InvoiceRawData.Discount}</td>" +
                            $"<td>{InvoiceRawData.Quantity}</td>" +
                            $"<td>{InvoiceRawData.TotalAmount}</td>" +
                            $"<td>{InvoiceRawData.BalanceAmount}</td></tr>" ;

            // Add more columns as needed

            invoiceTable += "</table>";

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,

                HtmlContent = $@"<!DOCTYPE html>
                    <html lang='en'>
                    <head>
                        <meta charset='UTF-8'>
                        <meta http-equiv='X-UA-Compatible' content='IE=edge'>
                        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                        <title>Invoice</title>
                        <style>
                            body {{
                                font-family: 'Arial', sans-serif;
                                margin: 0;
                                padding: 20px;
                            }}
                            header {{
                                text-align: center;
                                margin-bottom: 20px;
                            }}
                            h1, h2 {{
                                margin: 5px 0;
                                color: #333;
                            }}
                            p {{
                                color: #555;
                            }}
                            table {{
                                width: 100%;
                                border-collapse: collapse;
                                margin-top: 20px;
                            }}
                            th, td {{
                                border: 1px solid #ddd;
                                padding: 8px;
                                text-align: left;
                            }}
                            th {{
                                background-color: #f2f2f2;
                            }}
                            tfoot {{
                                font-weight: bold;
                            }}
                        </style>
                    </head>
                    <body>
                        <header>
                            <h1>MC Computers Pvt (Ltd)</h1>
                            <p>Empowering Your Digital World</p>
                        </header>
                        
                        <div>
                            <p>Thank you for choosing MC Computers for your technology needs. We appreciate your business!</p>
                        </div>
                        
                        {invoiceTable}
                        
                        <footer>
                            <p>For any inquiries, please contact us at support@mccomputers.com</p>
                        </footer>
                    </body>
                    </html>",
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
