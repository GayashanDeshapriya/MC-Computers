using System.ComponentModel.DataAnnotations;

namespace MCComputers.Entities
{
    public class Customer
    {
        [Key] public int CustomerID { get; set; }
        public required string CustomerName { get; set; }
        public required string CustomerAddress { get; set; }
        public required string CustomerEmail { get; set; }
    }
}
