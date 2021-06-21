using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Order
    {
        // instance var 
        public DateTime OrderDate { get; set; }
        public User User { get; set; }
        public Location Location { get; set; }
        // constructor
        public Order(DateTime orderDate, User user, Location location)
        {
            this.OrderDate = orderDate;
            this.User = user;
            this.Location = location;
            // orderList.Add(this);
        }
        // instance methods
        // getter and setters 
    }
}
