using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCComputers.Entities
{
    public class Invoices
    {
        [Key] public int Id { get; set; }
        public int CustomerID { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ProductID { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal BalanceAmount { get; set; }


        // Navigation properties
        [ForeignKey("CustomerID")]
        public virtual required Customer Customer { get; set; }

        [ForeignKey("ProductID")]
        public virtual required Products Products { get; set; }
    }
}

