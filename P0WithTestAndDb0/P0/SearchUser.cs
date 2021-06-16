using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P0DbContext;
namespace P0
{
    public class SearchUser
    {

        public static void FoundUsers(string userFName, string userLName)
        {
            P0DBContext context = new P0DBContext();
            var users = context.Users.Where(x => x.FirstName == userFName && x.LastName == userLName).ToList();
            if (users.Count < 1) Console.WriteLine(" ZERO USER WITH THIS FIRST NAME AND LAST NAME.");
            else
            {
                Console.WriteLine($" {users.Count} USER(S) WITH THIS FIRST NAME AND LAST NAME.");
                foreach (var user in users)
                {
                    Console.WriteLine($"\nUser FirstName   : {user.FirstName}");
                    Console.WriteLine($"User LastName    : {user.LastName}");
                    Console.WriteLine($"User Email       : {user.Email}");
                }
            }
        }// end 


        public static void SearchUserByLastAndFirstName()
        {
            Console.WriteLine("Search User.\n");

            string userFName = "";
            string userLName = "";
                do
                {
                    Console.WriteLine("Please enter user first name.");
                    userFName = Console.ReadLine();
                    if (userFName.Length < 1) Console.WriteLine(" User first name must be atleast 1 character.\n ");
                }
                while (userFName.Length < 1);
                 do
                {
                    Console.WriteLine("Please enter user last name.");
                    userLName = Console.ReadLine();
                    if (userLName.Length < 1) Console.WriteLine(" User last name must be atleast 1 character.\n ");
                }
                while (userLName.Length < 1);

            FoundUsers (userFName, userLName);
        }     
        
    }
}