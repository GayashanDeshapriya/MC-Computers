using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCComputers.Entities
{
    public class InvoiceModel
    {
        [Key] public required string InvoiceNumber { get; set; }
        public required string CustomerName { get; set; }
        public required string ProductName { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal BalanceAmount { get; set; }


    }
}

