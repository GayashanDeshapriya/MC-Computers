using System.ComponentModel.DataAnnotations;

namespace MCComputers.Entities
{
    public class CustomerModel
    {
        [Key] public required string CustomerId { get; set; }
        public required string CustomerName { get; set; }
        public required string CustomerEmail { get; set; }
        public required string CustomerPhone { get; set; }

    }
}
