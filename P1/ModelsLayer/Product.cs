using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name must be at least 1 character.")]
        [MinLength(1)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Product Description must be at least 1 character.")]
        [MinLength(1)]
        [Display(Name = "Product Description ")]
        public string ProductDescription { get; set; }

        [Required(ErrorMessage = "Product Price must be at least great than 0.")]
        [MinLength(1)]
        [Display(Name = "Product Price")]
        public int ProductPrice { get; set; }
        // constructor
        public Product(string productName, string productDescription, int productPrice, bool disponibility)
        {
            this.ProductName = productName;
            this.ProductDescription = productDescription;
            this.ProductPrice = productPrice;
        }
    }
}
