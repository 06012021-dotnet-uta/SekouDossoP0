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
        [key]
        public int CartProductId { get; set; }

        [ForeignKey("CartId")]
        public int CartId { get; set; }
        public Cart Cart { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [NotMapped]
        public List<Product> Products { get; set; }

        [NotMapped]
        public int Quantity { get; set; }

        public CartProduct()
        {
            CartId = 1;
            ProductId = 1;
        }
        public CartProduct(int cartId , int productId)
        {
            this.CartId = cartId;
            this.ProductId = productId;
        }
    }
}
