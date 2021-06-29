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
         public User User { get; set; }

        [ForeignKey("Location")]
         public int LocationId { get; set; }
         public Location Location { get; set;  }
         // constructor
          public Order(DateTime orderDate, int userId, int locationId)
          {
              this.OrderDate = orderDate;
              this.UserId = userId;
              this.LocationId = locationId;
          }

    }
}
