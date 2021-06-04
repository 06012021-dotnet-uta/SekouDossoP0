using System;
namespace RockPaperScissors1
{
    public class PlayerChoice
    {
        public static int  getPlayerChoice (){
            string playerChoice;
            int playerChoiceInt = -1;
            bool  successfulConversion = false;
            do
            {
                Console.WriteLine("1. Rock\n2. Paper\n3.Scissors");
                playerChoice = Console.ReadLine();
                //create a int variable to catch the converted choice.
                successfulConversion = Int32.TryParse(playerChoice, out playerChoiceInt);

                //check if the user inputted a number but the numebr is out of bounds.
                if (playerChoiceInt > 3 || playerChoiceInt < 1)
                    Console.WriteLine($"You inputted {playerChoiceInt}. That is not a valid choice.");
                else if (!successfulConversion)
                    Console.WriteLine($"You inputted {playerChoice}. That is not a valid choice.");

            } //while (!successfulConversion || (playerChoiceInt < 1 || playerChoiceInt > 3));
            while (!successfulConversion || !(playerChoiceInt > 0 && playerChoiceInt < 4));//both of hte above are valid.

            return  playerChoiceInt;
        }
    }
}