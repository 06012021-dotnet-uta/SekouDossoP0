using System;

namespace RockPaperScissors1
{
    public class RpsGame
    {
        public string WelcomeMessage()
        {
            // string welcome = "\tWelcome to Rock-Paper-Scissors!\n\nPlease make a choice.";
            string welcome = "\tWelcome to Rock-Paper-Scissors!";
            return welcome;
        }
        public void getPlayerName(PlayerDerivedClass player)
        {
            Console.WriteLine("Please enter your first name");
            player.Fname = Console.ReadLine();
            if (player.Fname == null)
            {
                Console.WriteLine("\n\nreturned null\n\n");
            }
            Console.WriteLine($"Whatsa haps, {player.Fname}? Please enter your last name");
            player.Lname = Console.ReadLine();
            string fullAddress = player.GetFullAddress();
            Console.WriteLine($"Welcome to the gameZone, {fullAddress} .");

            Console.WriteLine($"Please make a choice.");
            

        }
        

    }
}
