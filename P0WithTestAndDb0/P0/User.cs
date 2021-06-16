using System;
using System.Linq;
namespace P0
{
    public class User : UserBase, IUser
    {
        // class var 
        // instance var 
        // constructor
        public User() : base(){}
        public User(string firstName, string lastName, string email, string userPassWord) : base( firstName,  lastName, email, userPassWord){

        }
        // instance methods
            // override interface methods
            public User Register(){
           
                User newUser = new User(FirstName, LastName, Email, UserPassWord);
                return newUser;
            }

            public string DeleteAccount(string firstName, string lastName, string userPassWord){
               return $"{firstName} {lastName} your account have been deleted.";
            }

        // class methods 

        
    }
}