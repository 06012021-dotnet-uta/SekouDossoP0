using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class CartProduct
    {
        [Required]
        public int CartProductId { get; set; }

        [ForeignKey("CartId")]
        public int CartId { get; set; }

        [ForeignKey("Productid")]
        public int ProductId { get; set; }

        [NotMapped]
        public List<Product> Products { get; set; }

        [NotMapped]
        public int Quantity { get; set; }

        public CartProduct()
        {
            this.ProductId = 1;
            this.Quantity = 1;
        }
        public CartProduct(int productId, int quantity)
        {
            this.ProductId = productId;
            this.Quantity = quantity;
        }
    }
}
