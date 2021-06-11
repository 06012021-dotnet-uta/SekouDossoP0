using System;

namespace P0
{
    public class OrderBase
    {
        // class var 
        // instance var 
        int orderNumber;
        DateTime orderDate;
        User user;
        // constructor
        public OrderBase(int orderNumber, DateTime orderDate, User user){
            this.orderNumber = orderNumber;
            this.orderDate = orderDate;
            this.user = user;
        }
        // instance methods 
        public DateTime OrderDate{
            get{ return orderDate;}
            set{
                orderDate = value;
            }
        }
        public int OrderNumber {
            get{ return orderNumber;}
            set{
                orderNumber = value;
            }
        }
        // override methods
	    // interface methods
        // class methods
        
    }
}