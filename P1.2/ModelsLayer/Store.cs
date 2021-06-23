using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Store
    {
        // instance methods
          [Key]
         public int StoreId { get; set; }
         // instance vars
         [Required(ErrorMessage = "Store must be at least 1 character.")]
         [MinLength(1)]
         [Display(Name = "Store Name")]
         public string StoreName { get; set; }

         [Display(Name = "Location Id")]
         [ForeignKey("LocationId")]
         public int LocationId { get; set;}
         // constructor
        // public Store(string storeName, Location location)
        // {
        //     this.StoreName = storeName;
        //     this.Location = location;
        // }
    }
}
