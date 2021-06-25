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
        public int CartproductId { get; set; }

        [ForeignKey("CartId")]
        public int CartId { get; set; }

        [ForeignKey("Productid")]
        public int ProductId { get; set; }

        [NotMapped]
        public List<Product> Products { get; set; }

        [NotMapped]
        public List<int> Quantity { get; set; }
    }
}
