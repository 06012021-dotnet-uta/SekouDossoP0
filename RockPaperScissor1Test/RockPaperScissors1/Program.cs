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
            // bool successfulConversion = false;
            int playerChoiceInt;
            int computerChoice;
            string quitter;


            //get players info
            rpsGame.getPlayerName(player1);
            
            //play the game
            do
            {
                int computerRoundWins = 0;
                int playerRoundWins = 0;
                int tieRounds = 0;
                //start first to 2 wins game here
                while (computerRoundWins < 2 && playerRoundWins < 2)
                {

                    // get  player choice 
                    playerChoiceInt = PlayerChoice.getPlayerChoice();
                    
                    // get computer choice
                    computerChoice = PlayerChoice.getComputerChoice();

                    //print the choices.
                    Console.WriteLine($"{player1.GetFullAddress()}'s choice is {(RpsChoice)playerChoiceInt}");
                    Console.WriteLine($"the computers choice is {(RpsChoice)computerChoice}");

                    //check who won.
                    computerRoundWins = Score.ComputerWin(playerChoiceInt, computerChoice, computerRoundWins);
                    tieRounds = Score.TieScore(playerChoiceInt, computerChoice, tieRounds);
                    playerRoundWins = Score.PlayerWin(playerChoiceInt, computerChoice, player1, playerRoundWins);

                }//end of rounds

                Score.GameResult( computerRoundWins ,  playerRoundWins);

                //see if the player wants to play again
                quitter = Score.PlayAgain(player1);

            } while (quitter == "y");

        }//end of main
    }//end of class
}//end of namespace