using System;
namespace P0
{
    public class Order : OrderBase
    {
        // class var 
        static  int totalOrderNumber;
        Location storeLocation;
        Product product; 
    
        // instance var 
        // constructor
        public Order(int orderNumber, DateTime orderDate, User user, Product product, Location storeLocation) : base(orderNumber, orderDate, user){
            this.product = product;
            this.storeLocation = storeLocation;
           totalOrderNumber++;
        }
        // instance methods 
        // override methods
	    // interface methods
        // class methods 
    }
}