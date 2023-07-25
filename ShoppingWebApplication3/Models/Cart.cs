using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingWebApplication3.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public string CartItem { get; set; }

        [Display(Name = "Product")]
        public virtual int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product products { get; set; }

    }
}
