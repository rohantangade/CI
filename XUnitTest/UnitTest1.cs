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

        [Trait("Category","CategoryA")]
        [Theory]
        [InlineData(1,"Dhruvv")]
        [InlineData(2,"Abhir")]
        [InlineData(3,"Aayush")]
        public void TDDTestCase(int empID, string name)
        {
            var result = ArithmeticOperation.GetEmployeeName(empID);
            Assert.Equal(name, result);
        }
    }
}
