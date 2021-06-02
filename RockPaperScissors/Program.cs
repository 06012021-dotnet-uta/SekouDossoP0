using System;

namespace RockPaperScissors
{
    partial class Program
    {
        //an enum is a custom data type that you decide the types for.
            // public enum RpsChoice
            // {
            //     //without specifying the number equivalent of the enum type, the numbers default to start at 0.
            //     Rock = 1,//equivalent to 1
            //     Paper = 2,//equivalent to 2
            //     Scissors = 3//equivalent to 3
            // }

        static void Main(string[] args)
        {
            // get the players name to print out the winners 
            Console.WriteLine("Please enter your name");
            string playerName = Console.ReadLine();

            // implement the code to play 3 rounds. -- done --  
            int round = 0;
            do {
                Console.WriteLine("\tWelcome to Rock-Paper-Scissors!\n\nPlease make a choice.");
                bool successfulConversion = false;
                int playerChoiceInt;
                do
                {
                    Console.WriteLine("1. Rock\n2. Paper\n3.Scissors");
                    string playerChoice = Console.ReadLine();

                    //create a int variable to catch the converted choice.
                    successfulConversion = Int32.TryParse(playerChoice, out playerChoiceInt);

                    //check if the user inputted a number but the numebr is out of bounds.
                    if (playerChoiceInt > 3 || playerChoiceInt < 1)
                    {
                        Console.WriteLine($"You inputted {playerChoiceInt}. That is not a valid choice.");
                    }
                    else if (!successfulConversion)
                    {
                        Console.WriteLine($"You inputted {playerChoice}. That is not a valid choice.");
                    }

                } //while (!successfulConversion || (playerChoiceInt < 1 || playerChoiceInt > 3));
                while (!successfulConversion || !(playerChoiceInt > 0 && playerChoiceInt < 4));//both of hte above are valid.

                //you can omit the {} if the body of hte statement is only 1 line
                if (successfulConversion == true) Console.WriteLine($"the conversion returned {successfulConversion} and the player chose {playerChoiceInt}");
                else
                    Console.WriteLine($"the conversion returned {successfulConversion} and the player chose {playerChoiceInt}");

                //get a random number generator object
                Random rand = new Random();
                //get a random number 1,2, or 3.
                int computerChoice = rand.Next(1, Enum.GetNames(typeof(RpsChoice)).Length + 1);

                //print the choices.
                Console.WriteLine($"the players choice is {playerChoiceInt}");
                Console.WriteLine($"the computers choice is {computerChoice}");

                //check who won.
                if ((playerChoiceInt == 1 && computerChoice == 2)
                    || (playerChoiceInt == 2 && computerChoice == 3)
                    || (playerChoiceInt == 3 && computerChoice == 1)) Console.WriteLine("Computer Wins");
                else if (playerChoiceInt == computerChoice) Console.WriteLine("Tie Game!!");
                else Console.WriteLine($"{playerName} Wins!!!");

                //you can get typeDef the number to the equivalent RpsChoice Enum.
                Console.WriteLine((RpsChoice)playerChoiceInt);
                Console.WriteLine((RpsChoice)computerChoice);

                round++;
                // Console.WriteLine($"{round} rounds done");
                Console.WriteLine($"{3-round} more rounds");


                // implement a loop to play again if the player chooses to.
                if (round < 3){
                    Console.WriteLine($" {playerName} Would you like to play again?");
                    string playAgain = Console.ReadLine();

                    if(playAgain == "N" || playAgain == "n"  ) break;
                }
                else{
                    Console.WriteLine(" NO MORE ROUND");

                }

            } while (round < 3);


            /*Coding challenge
                1. implement a loop to play again if the player chooses to.
                2. get the players name to print out the winners -- done --
                3. implement the code to play 3 rounds. -- done -- 
            */

        }//end of main
    }
}
