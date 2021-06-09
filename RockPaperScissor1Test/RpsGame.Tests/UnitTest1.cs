using System;
using Xunit;
using RockPaperScissors1;

namespace RpsGame.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange
                int a = 3; 
                int b = 4;  
            // Act 
                int z = a + b ;
            // Assert
                Assert.Equal(7 , z);
        }
        // testing welcome message
        [Fact]
        public void TestingWelcomeMessageReturnCorrectMessage()
        {
            // arrange
<<<<<<< HEAD
                IRpsGame welcome = new RockPaperScissors1.RpsGame.WelcomeMessage();
=======
                IRpsGame welcome = new RockPaperScissors1.RpsGame();
>>>>>>> main
                // "\tWelcome to Rock-Paper-Scissors!";
            // Act 
                string welcomeMessage = welcome.WelcomeMessage();
            // Assert
                Assert.Equal("\tWelcome to Rock-Paper-Scissors!" , welcomeMessage);

<<<<<<< HEAD
            // just a commit test case
            // just a commit test case


        }

        // testing welcome message
        [Fact]
        public void NewTest()
        {
            // arrange
               
            // Act 
                
            // Assert
                
        }

=======

        }
>>>>>>> main
    }
}
