using System.ComponentModel.DataAnnotations;

namespace MCComputers.Entities
{
    public class Products
    {
        [Key] public int ProductID { get; set; }
        public required string ProductName { get; set; }
        public required string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
