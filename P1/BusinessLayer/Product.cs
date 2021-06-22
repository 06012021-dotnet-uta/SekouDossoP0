using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Product
    {
        // instance var 
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
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
