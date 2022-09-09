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
            
        }
    }
}
