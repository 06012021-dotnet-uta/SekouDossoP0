using System ;

namespace P0
{
    public class UserBase
    {
        // class var
        // instance variables
        string firstName;
        string lastName;
        string email;
        string userPassWord;

        // constructor
        public UserBase(string firstName, string lastName, string email, string userPassWord){
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email; 
            this.userPassWord = userPassWord;
        }

        // instance methods
        public string FirstName{
            get{ return firstName;}
            set{
                if(value.Length < 1 || value.Length >15){
                    Console.WriteLine("firstName should be atleast 1 character and less than 15 characters.");
                    firstName = Console.ReadLine();
                }else{
                    firstName = value;
                }
            }
        }
        public string LastName{
            get{ return lastName;}
            set{
                if(value.Length < 1 || value.Length >15){
                    Console.WriteLine("lastName should be atleast 1 character and less than 15 characters.");
                    lastName = Console.ReadLine();
                }else{
                lastName = value;
                }
            }
        }
        public string Email{
            get{ return email;}
            set{
                if(value.Length < 1 ){
                    Console.WriteLine("email should be atleast 1 character.");
                    lastName = Console.ReadLine();
                }else{
                email = value;
                }
            }
        }
        public string UserPassWord{
            get{ return userPassWord;}
            set{
                if(value.Length < 3){
                    Console.WriteLine("userPassWord should be atleast 3 characters.");
                    userPassWord = Console.ReadLine();
                }else{
                    userPassWord = value;
                }
            }
        }
        // class methode

        
    }
}