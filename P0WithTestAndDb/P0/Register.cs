using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P0DbContext;

namespace P0
{
    class Register
    {
        public static void CreateAccount(int x)
        {
            P0DBContext context = new P0DBContext();
            string firstName = "", lastName = "", email = "", userPassWord = "";
            if (x != 1)
            {
                int userCount = -1;
                do
                {
                    do
                    {
                        Console.WriteLine("Please enter your first name: ");
                        firstName = Console.ReadLine();
                        if (firstName.Length < 1) Console.WriteLine(" First name must be atleast 1 character. ");
                        Console.WriteLine("Please enter your last name: ");
                        lastName = Console.ReadLine();
                        if (lastName.Length < 1) Console.WriteLine(" Last name must be atleast 1 character. ");
                        Console.WriteLine("Please enter your email: ");
                        email = Console.ReadLine();
                        if (email.Length < 1) Console.WriteLine(" Email must be atleast 1 character. ");
                        Console.WriteLine("Please enter your userPassWord: ");
                        userPassWord = Console.ReadLine();
                        if (userPassWord.Length < 1) Console.WriteLine(" UserPassWord must be atleast 1 character. ");
                    }
                    while (firstName.Length < 1 || lastName.Length < 1 || email.Length < 1 || userPassWord.Length < 1);
                    userCount = context.Users.ToList().Where(x => x.Email == email).Count();
                    if (userCount > 0) Console.Write("This user already exixts please retry with different email.\n");
                } while (userCount > 0);

                 //   using (var db = new p0dbcontext())
                 //   { var newUser = new User (firstName, lastName, email, userPassWord );
                 //    var newUser = new User(){FirstName = firstName, LastName = lastName, Email = email, UserPassWord = userPassWord};

                 //     db.Add(newUser); db.SaveChanges(); }
            }
            else
            {
                int result = -1;
                do 
                { 
                    Console.WriteLine("Please enter your email: ");
                    email = Console.ReadLine();
                    result = context.Users.ToList().Where(x => x.Email == email).Count();
                    if (result < 1) Console.WriteLine($"Wrong email.");
                } while (result < 1);
                var rightPassWord = context.Users.ToList().Where(x => x.Email == email).FirstOrDefault().UserPassWord;
                do
                {
                    Console.WriteLine("Please enter your userPassWord: ");
                    userPassWord = Console.ReadLine();
                    if (userPassWord != rightPassWord) Console.WriteLine($"Wrong password.");
                    } while (userPassWord != rightPassWord);
                var registeredUser = context.Users.ToList().Where(x => x.Email == email).FirstOrDefault().FisrtName;
                Console.WriteLine($"Heeeeey {registeredUser}  Please select a store.");
            }
        }
    }
}
