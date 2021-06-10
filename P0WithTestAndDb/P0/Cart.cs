using System;
using System.Collections.Generic;
namespace P0
{
    public class Cart
    {
        // class var 
        // public List<Product> products;
        // instance var 
        public List<Product> cart;
        // constructor
        public Cart(){
            this.cart = new List<Product>();
        }
        // instance methods 
        public void AddProduct(Product p){
            if (cart.Count > 5){
                Console.WriteLine("cart is full, Oreder may be rejected");
            }
            cart.Add(p);
        }
        // check cart contents
        public int GetCartSize(){
            int cartCOntent = cart.Count;
            return cartCOntent;
        }

    }
}