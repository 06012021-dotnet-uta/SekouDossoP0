using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class OrderProduct
    {
        [key]
        public int OrderProductId { get; set; }


        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        public OrderProduct(int orderId, int productId, int quantity)
        {
            this.OrderId = orderId;
            this.ProductId = productId;
            this.Quantity = quantity;
        }
    }
}
