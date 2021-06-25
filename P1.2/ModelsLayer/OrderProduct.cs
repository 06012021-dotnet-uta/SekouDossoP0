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
        [Required]
        public int OrderProductId { get; set; }


        [ForeignKey("Order")]
        public int OrderId { get; set; }
        // public Order Order { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        // public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
