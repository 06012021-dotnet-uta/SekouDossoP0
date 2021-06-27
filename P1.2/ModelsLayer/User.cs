using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class User : UserBase
    {
        // class var 
        // instance var 
        // constructor

        public User() : base() { }
        public User(string firstName, string lastName, string email, string userPassWord, string userName) : base(firstName, lastName, email, userPassWord, userName)
        {

        }
    }
}
