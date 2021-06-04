using System;

namespace RockPaperScissors1
{
    partial class Program
    {

        static void Main(string[] args)
        {

            RpsGame rpsGame = new RpsGame();
            PlayerDerivedClass player1 = new PlayerDerivedClass();
            PlayerDerivedClass computer = new PlayerDerivedClass("Max", "HeadRoom", 38);
            Console.WriteLine(rpsGame.WelcomeMessage());
            bool successfulConversion = false;
            int playerChoiceInt;
            string quitter = "n";

            //get players info
            rpsGame.getPlayerName(player1);
            
            //play the game
            do
            {
                //start first to 2 wins game here
                int computerRoundWins = 0;
                int playerRoundWins = 0;
                int tieRounds = 0;
                while (computerRoundWins < 2 && playerRoundWins < 2)
                {
                    //a do/while loop runs at least once, while a while loop may not ever run.
                    //gets the players choice
                    // get  player choice 
                        playerChoiceInt = PlayerChoice.getPlayerChoice();
                    
                    //you can omit the {} if the body of hte statement is only 1 line or even put it all on one line.
                    // if (successfulConversion == true) Console.WriteLine($"the conversion returned {successfulConversion} and the player chose {playerChoiceInt}");
                    // else
                    //     Console.WriteLine($"the conversion returned {successfulConversion} and the player chose {playerChoiceInt}");

                    //get a random number generator object from the Random Class
                    Random rand = new Random();
                    //get a random number 1,2, or 3.
                    int computerChoice = rand.Next(1, Enum.GetNames(typeof(RpsChoice)).Length + 1);

                    //print the choices.
                    Console.WriteLine($"{player1}'s choice is {(RpsChoice)playerChoiceInt}");
                    Console.WriteLine($"the computers choice is {(RpsChoice)computerChoice}");

                    //check who won.
                    if ((playerChoiceInt == 1 && computerChoice == 2) ||
                         (playerChoiceInt == 2 && computerChoice == 3) ||
                         (playerChoiceInt == 3 && computerChoice == 1))
                    {
                        Console.WriteLine("Computer Wins this round");
                        // computerRoundWins++;
                        computerRoundWins = computerRoundWins + 1;
                    }
                    else if (playerChoiceInt == computerChoice)
                    {
                        Console.WriteLine("Tie Round!!");
                        tieRounds++;
                    }
                    else
                    {
                        Console.WriteLine($"{player1} wins this round!!!");
                        playerRoundWins++;
                    }

                    //you can get typeDef the number to the equivalent RpsChoice Enum.
                    // Console.WriteLine((RpsChoice)playerChoiceInt);
                    // Console.WriteLine((RpsChoice)computerChoice);

                }//end of rounds

                if (computerRoundWins == 2)
                {
                    Console.WriteLine($"\n\tIt looks like the computer won this game. Better luck next time!\n");
                }
                else if (playerRoundWins == 2)
                {
                    Console.WriteLine($"\n\tYou did it! You won against the computer!\n");
                }

                //see if the player wants to play again
                do
                {
                    Console.WriteLine($"Hey, {player1}. Would you like to play again?\n I'll keep asking till you answer me!!\n enter Y or N");
                    quitter = Console.ReadLine();
                    quitter = quitter.Trim().ToLower();
                    //Console.WriteLine($"The choice to play or not is => {quitter}");
                } //while (quitter.CompareTo("y") != 0 && quitter.CompareTo("n") != 0);
                while (quitter != "y" && quitter != "n");

            } while (quitter == "y");

        }//end of main
    }//end of class
}//end of namespace