using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P1Mvc.Models
{
    public class User
    {
        [Required(ErrorMessage = "FirstName must be at least 1 character.")]
        [MinLength(1)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName must be at least 1 character.")]
        [MinLength(1)]
        public string LastName { get; set; }

      
    }
}
