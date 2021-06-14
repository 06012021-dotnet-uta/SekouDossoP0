using System;
using System.Linq;
namespace P0
{
    public class User : UserBase, IUser
    {
        // class var 
        // instance var 
        // constructor
        
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

            // selct store 
            public static int  StoreSelection (){
            string storeSeletion;
            int storeSeletionInt = -1;
            bool  successfulConversion = false;
            do
            {
                Console.WriteLine("1. Berluti\n2. Rolex\n3.Dsquared2");
                storeSeletion = Console.ReadLine();
                //create a int variable to catch the converted choice.
                successfulConversion = Int32.TryParse(storeSeletion, out storeSeletionInt);

                //check if the user inputted a number but the numebr is out of bounds.
                if (storeSeletionInt > 3 || storeSeletionInt < 1)
                    Console.WriteLine($"You inputted {storeSeletionInt}. That is not a valid choice.");
                else if (!successfulConversion)
                    Console.WriteLine($"You inputted {storeSeletion}. That is not a valid choice.");

            } //while (!successfulConversion || (playerChoiceInt < 1 || playerChoiceInt > 3));
            while (!successfulConversion || !(storeSeletionInt > 0 && storeSeletionInt < 4));//both of hte above are valid.

            return  storeSeletionInt;
        }
   
        // class methods 

        
    }
}