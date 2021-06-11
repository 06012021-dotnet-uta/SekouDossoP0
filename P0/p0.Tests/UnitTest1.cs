using System;
using Xunit;

namespace p0.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange 
            int x = 2 ;
            int y = 3;

            // act 
            int z = x+y;
            // assert
            Assert.Equal(5,z);

        }
    }
}
