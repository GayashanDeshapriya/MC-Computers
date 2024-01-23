using System.ComponentModel.DataAnnotations;

namespace MCComputers.Entities
{
    public class Invoices
    {
        [Key] public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ProductID { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal BalanceAmount { get; set; }
    }
}
