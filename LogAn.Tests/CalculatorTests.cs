using Xunit;

namespace LogAn.Tests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Sum_NoAddCalls_DefautsToZero()
        {
            //arrange && act
            var result = _calculator.Sum();

            //assert
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 2)]
        [InlineData(2, 4)]
        public void Add_AddTwoNumbers_ReturnsExpectedResult(int firstNumber, int secondNumber)
        {
            //arrange && act

            var twoNumbersSumResult = firstNumber + secondNumber;

            _calculator.Add(firstNumber);
            _calculator.Add(secondNumber);

            //assert
            
            Assert.Equal(twoNumbersSumResult, _calculator.Sum());   
        }

        [Theory]
        [InlineData(3, 6, 9)]
        [InlineData(5, 7, 4)]
        [InlineData(6, 8, 3)]
        public void Add_AddThreeNumbers_ReturnsExpectedResult(int firstNumber, int secondNumber, int thirdNumber)
        {

        }
    }
}
