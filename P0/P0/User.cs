using System;
namespace P0
{
    public class User : UserBase, IUser
    {
        // class var 
        // instance var 
        // constructor
        public User(string firstName, string lastName, string passWord) : base( firstName,  lastName, passWord){

        }
        // instance methods

            // override interface methods
            public User Register(string firstName, string lastName, string passWord){
                User newUser = new User(firstName, lastName, passWord);
                return newUser;
            }

            public string DeleteAccount(string firstName, string lastName, string passWord){
               return $"{firstName} {lastName} your account have been deleted.";
            }
   
        // class methods 

        
    }
}