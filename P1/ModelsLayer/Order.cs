using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Order
    {
        // instance var 
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public User User { get; set; }
        public Location Location { get; set; }
        // constructor
        public Order(DateTime orderDate, User user, Location location)
        {
            this.OrderDate = orderDate;
            this.User = user;
            this.Location = location;
        }

    }
}
