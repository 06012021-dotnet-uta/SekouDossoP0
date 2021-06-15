using System;
using System.Collections.Generic;

namespace P0
{
    public class Order
    {
        // class var 
        // List<Order> orderList;
        // instance var 
        DateTime orderDate; 
        User user;
        Location location;
        // constructor
        public Order(DateTime orderDate, User user, Location location){
            this.orderDate = orderDate;
            this.user = user;
            this.location = location;
            // orderList.Add(this);
        }
        // instance methods
        // getter and setters 
        public DateTime OrderDate {
            get{ return orderDate;} 
            set{ orderDate = value;}
        }
        public User User{
            get { return user;}
            set { user = value;}
        }
        public Location Location{
            get { return location;}
            set { location = value;}
        } 
        // override methods
	  // interface methods
        // class methods

    }
}