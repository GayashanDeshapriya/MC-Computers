using System.ComponentModel.DataAnnotations;

namespace MCComputers.Entities
{
    public class ProductModel
    {
        [Key] public required string ProductId { get; set; }
        public required string ProductName { get; set; }
        public required string ProductDescription { get; set; }
        public required string ProductCategory { get; set; }

    }
}
