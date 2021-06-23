using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsLayer
{
    public class Order
    {
        // instance var 
         [Key]
         public int OrderId { get; set; }
        [Required]
         public DateTime OrderDate { get; set; }
        //[Required]
        [ForeignKey("User")]
         public int UserId { get; set; }

        [ForeignKey("Location")]
         public int LocationId { get; set; }
         // constructor
         // public Order(DateTime orderDate, User user, Location location)
         // {
         //    this.OrderDate = orderDate;
         //    this.User = user;
         //    this.Location = location;
         // }

    }
}
