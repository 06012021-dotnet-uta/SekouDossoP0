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
                IRpsGame welcome = new RockPaperScissors1.RpsGame();
                // "\tWelcome to Rock-Paper-Scissors!";
            // Act 
                string welcomeMessage = welcome.WelcomeMessage();
            // Assert
                Assert.Equal("\tWelcome to Rock-Paper-Scissors!" , welcomeMessage);


        }
    }
}
