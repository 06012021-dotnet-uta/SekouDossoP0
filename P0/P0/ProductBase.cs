using System;
namespace P0
{
    public class ProductBase
    {
        // class var 
        // instance var 
        string productName;
        string productDescription;
        int productPrice;
        bool disponibility;
        // constructor
        public ProductBase(string productName, string productDescription, int productPrice,  bool disponibility){
            this.productName = productName;
            this.productDescription = productDescription;
            this.productPrice = productPrice;
            this.disponibility = true;
        }

        // getter and setter
        public string ProductName{
            get{ return productName;}
            set{
                while(value.Length < 1 ){
                    throw new InvalidOperationException ("ProductName should be atleast 1 character.");
                }
                productName = value;
            }
        }
        public string ProductDescription{
            get{ return productDescription;}
            set{
                while(value.Length < 1 ){
                    throw new InvalidOperationException ("ProductDescription should be atleast 1 character.");
                }
                productDescription = value;
            }
        }
        public int ProductPrice{
            get{ return productPrice;}
            set{
                while(value < 1 ){
                    throw new InvalidOperationException ("productPrice  should be > 0");
                }
                productPrice = value;
            }
        }
        public bool Disponibility{
            get{ return disponibility;}
            set{
                disponibility = value;
            }
        }
    }
}