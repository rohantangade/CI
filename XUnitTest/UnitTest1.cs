using CI;
using System;
using Xunit;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange Data
            var number1 = 10;
            var number2 = 15;
            var expectedValue = 25;

            //Acts
            var sum = ArithmeticOperation.Addition(number1, number2);

            //Assert
            Assert.Equal(expectedValue, sum, 1);
        }
    }
}
