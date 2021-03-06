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

        [Key]
        public int UserId { get; set; }

        // instance methods
        [Required(ErrorMessage = "FirstName must be at least 1 character.")]
        [MinLength(1)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName must be at least 1 character.")]
        [MinLength(1)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email must be valid.")]
        //[MinLength(3)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Email must be at least 1 character.")]
        [MinLength(3)]
        [Display(Name = "Password")]
        public string UserPassWord { get; set; }

        [Display(Name = "UserName")]
        public string UserName { get; set; }
        // constructor
        public UserBase()
        {
            FirstName = "firstName";
            LastName = "lastName";
            Email = "email";
            UserPassWord = "userPassWord";
            UserName = "userName";
        }
        public UserBase(string firstName, string lastName, string email, string userPassWord, string userName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.UserPassWord = userPassWord;
            this.UserName = userName;
        }
        // class methode


    }
}
