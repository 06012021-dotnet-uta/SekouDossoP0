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
        /// <summary>
        /// After making a decision to Login or Register
        /// Here the User will be prompt to login or register
        /// The UserId will be send down from here for later need
        /// </summary>
        /// <param name="selection"></param>
        public static void CreateAccount(int selection)
        {
            P0DBContext context = new P0DBContext();
            string firstName = "", lastName = "", userPassWord = "", email = "";
            int registeredUserId = 0;
            if (selection == 2)
            {
                Console.WriteLine($"Please {(Choice.RegisterOrLogin)selection} to start your shopping.\n");

                int userCount11 =-1;
                do
                {
                    do
                    {
                        Console.WriteLine("Please enter your first name: ");
                        firstName = Console.ReadLine();
                        if (firstName.Length < 1) Console.WriteLine("First name must be atleast 1 character. ");
                        Console.WriteLine("Please enter your last name: ");
                        lastName = Console.ReadLine();
                        if (lastName.Length < 1) Console.WriteLine("Last name must be atleast 1 character. ");
                        Console.WriteLine("Please enter your email: ");
                        email = Console.ReadLine();
                        if (email.Length < 1) Console.WriteLine("Email must be atleast 1 character. ");
                        Console.WriteLine("Please enter your userPassWord: ");
                        userPassWord = Console.ReadLine();
                        if (userPassWord.Length < 3) Console.WriteLine("UserPassWord must be atleast 1 character. ");
                    }
                    while (firstName.Length < 1 || lastName.Length < 1 || email.Length < 1 || userPassWord.Length < 3);
                    var userCount = context.Users.Where(x => x.Email == email).ToList();
                    if (userCount.Count() > 0) Console.Write("This user already exixts please retry with different email.\n");
                    else userCount11 = 1 ;
                } while (userCount11 < 0);

                var newUser = new P0DbContext.User();
                newUser.FisrtName = firstName;
                newUser.LastName = lastName;
                newUser.Email = email;
                newUser.UserPassWord = userPassWord;
                //newUser = MapperClassAppToDb.AppUserToDbUser(newUser);
                context.Add(newUser); 
                context.SaveChanges();
                Console.WriteLine("\nYour account has been created.");
                var registeredUser = context.Users.ToList().Where(x => x.Email == email).FirstOrDefault().FisrtName;
                registeredUserId = context.Users.ToList().Where(x => x.Email == email).FirstOrDefault().UserId;
                Console.WriteLine($"Heeeeey {registeredUser}  Please select a from the menu.");
            }
            else
            {
                Console.WriteLine($" Please {(Choice.RegisterOrLogin)selection} to start your shopping.\n");
                int result = -1;
                do 
                { 
                    Console.WriteLine("Please enter your email: ");
                    email = Console.ReadLine();
                    string rightEmail = context.Users.ToList().Where(x => x.Email == email).FirstOrDefault().Email;
                    if (email != rightEmail) Console.WriteLine($"Wrong email.");
                    else result++;
                } while (result < 1);
                var rightPassWord = context.Users.ToList().Where(x => x.Email == email).FirstOrDefault().UserPassWord;
                do
                {
                    Console.WriteLine("Please enter your userPassWord: ");
                    userPassWord = Console.ReadLine();
                    if (userPassWord != rightPassWord) Console.WriteLine($"Wrong password.");
                    } while (userPassWord != rightPassWord);
                var registeredUser = context.Users.ToList().Where(x => x.Email == email).FirstOrDefault().FisrtName;
                registeredUserId = context.Users.ToList().Where(x => x.Email == email).FirstOrDefault().UserId;
                Console.WriteLine($"Heeeeey {registeredUser}  Please select a store.");
            }

            Choice.Menu(registeredUserId);
        }
    }
}
