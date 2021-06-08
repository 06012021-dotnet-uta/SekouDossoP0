using System;
namespace RockPaperScissors1
{
    public class Score
    {
        public static void GetScore(int playerChoiceInt, int computerChoice, PlayerDerivedClass player1){
            int computerRoundWins = 0;
            int playerRoundWins = 0;
            int tieRounds = 0;
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
                        Console.WriteLine($"{player1.GetFullAddress()} wins this round!!!");
                        playerRoundWins++;
                    }
        }

        public static string PlayAgain(PlayerDerivedClass player1){
            string quitter = "n";
            do
                {
                    Console.WriteLine($"Hey, {player1.GetFullAddress()} Would you like to play again?\n I'll keep asking till you answer me!!\n enter Y or N");
                    quitter = Console.ReadLine();
                    quitter = quitter.Trim().ToLower();
                } //while (quitter.CompareTo("y") != 0 && quitter.CompareTo("n") != 0);
                while (quitter != "y" && quitter != "n");

            return quitter;
        }
        public static void GameResult(int computerRoundWins , int playerRoundWins){
            if (computerRoundWins == 2)
                {
                    Console.WriteLine($"\n\tIt looks like the computer won this game. Better luck next time!\n");
                }
                else if (playerRoundWins == 2)
                {
                    Console.WriteLine($"\n\tYou did it! You won against the computer!\n");
                }
        }

        public static int ComputerWin(int playerChoiceInt, int computerChoice, int computerRoundWins){
                    if ((playerChoiceInt == 1 && computerChoice == 2) ||
                        (playerChoiceInt == 2 && computerChoice == 3) ||
                        (playerChoiceInt == 3 && computerChoice == 1)){
                        
                        Console.WriteLine("Computer Wins this round");
                        // computerRoundWins++;
                        computerRoundWins = computerRoundWins + 1;


                    }
                        return computerRoundWins;
                    
        }
    
        public static int TieScore(int playerChoiceInt, int computerChoice, int tieRounds){

                        if (playerChoiceInt == computerChoice)
                        {
                            Console.WriteLine("Tie Round!!");
                            tieRounds++;
                        }
                        return tieRounds;
        }
        public static int PlayerWin(int playerChoiceInt, int computerChoice, PlayerDerivedClass player1, int playerRoundWins){
                        if ((playerChoiceInt == 2 && computerChoice == 1) ||
                         (playerChoiceInt == 3 && computerChoice == 2) ||
                         (playerChoiceInt == 1 && computerChoice == 3)){

                            Console.WriteLine($"{player1.GetFullAddress()} wins this round!!!");
                            playerRoundWins++;
                         }

                         return playerRoundWins;
                    

        }
  
    }
}