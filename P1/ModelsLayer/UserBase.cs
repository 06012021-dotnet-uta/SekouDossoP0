using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class UserBase
    {
        // class var
        // instance variables
        [key]
        public int UserId { get; set; }
        string firstName;
        string lastName;
        string email;
        string userPassWord;

        // constructor
        public UserBase()
        {
            FirstName = "firstName";
            LastName = "lastName";
            Email = "email";
            UserPassWord = "userPassWord";
        }
        public UserBase(string firstName, string lastName, string email, string userPassWord)
        {
            //this.UserId = userId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.UserPassWord = userPassWord;
        }

        // instance methods
        [Required(ErrorMessage = "FirstName must be at least 1 character.")]
        [MinLength(1)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName must be at least 1 character.")]
        [MinLength(1)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Password must be at least 3 characters.")]
        [MinLength(3)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Email must be at least 1 character.")]
        [MinLength(1)]
        [Display(Name = "Password")]
        public string UserPassWord { get; set; }
        // class methode


    }
}
