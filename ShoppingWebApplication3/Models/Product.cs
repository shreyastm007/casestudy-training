using System.ComponentModel.DataAnnotations;

namespace ShoppingWebApplication3.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDetails { get; set; }

        public int ProductPrice { get; set; }
    }
}
