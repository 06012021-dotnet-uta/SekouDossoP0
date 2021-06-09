using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Clone your P0 repo.
            // 2. create a new feature branch
            // 3. create the template hello world program in a file.
            // 4. In that hello world program, add code to....
            // 5. 1. prompt the user for their age
            Console.WriteLine("Please enter your age: ");
            string userAge = Console.ReadLine();
            // 6. prompt the user for their name
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            // 7. print the users name and age to the console using string interpolation.
            Console.WriteLine($"User name is -- {userName} -- and the user is ** {userAge} ** old");  
        }
    }
}
