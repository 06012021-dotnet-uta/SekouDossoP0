using System ;

namespace P0
{
    public class UserBase
    {
        // class var
        // instance variables
        string firstName;
        string lastName;
        string passWord;

        // constructor
        public UserBase(string firstName, string lastName, string passWord){
            this.firstName = firstName;
            this.lastName = lastName; 
            this.passWord = passWord;
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
        public string PassWord{
            get{ return passWord;}
            set{
                if(value.Length < 3){
                    Console.WriteLine("passWord should be atleast 3 characters.");
                    passWord = Console.ReadLine();
                }else{
                    passWord = value;
                }
            }
        }
        // class methode

        
    }
}