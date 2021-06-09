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
                while(value.Length < 1 || value.Length >15){
                    throw new InvalidOperationException ("firstName should be atleast 1 character and less than 15 characters.");
                }
                firstName = value;
            }
        }
        public string LastName{
            get{ return lastName;}
            set{
                while(value.Length < 1 || value.Length >15){
                    throw new InvalidOperationException ("lastName should be atleast 1 character and less than 15 characters.");
                }
                lastName = value;
            }
        }
        public string PassWord{
            get{ return passWord;}
            set{
                while(value.Length < 3){
                    throw new InvalidOperationException ("passWord should be atleast 1 character.");
                }
                passWord = value;
            }
        }
        // class methode

        
    }
}