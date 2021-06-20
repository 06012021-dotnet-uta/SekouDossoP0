using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace P1Mvc.Models
{
    public class User
    {
        private string v1;
        private string v2;

        public User()
        {
        }

        public User(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        [Required(ErrorMessage = "First name should be atleast 1 character.")]  // validation
        [MinLength(1)]
        public string FName { get; set; }
        [Required(ErrorMessage = "Last name should be atleast 1 character.")]  // validation
        [MinLength(1)]
        public string LName { get; set; }
    }
}
