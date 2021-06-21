using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Product
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }     
        public int ProductPrice { get; set; }
        public bool Disponibility { get; set; }
        // constructor
        public Product(string productName)
        {
            this.ProductName = productName;
            // this.store = store;
        }
        public Product(string productName, string productDescription, int productPrice, bool disponibility)
        {
            this.ProductName = productName;
            this.ProductDescription = productDescription;
            this.ProductPrice = productPrice;
            this.Disponibility = true;
        }
    }
}
