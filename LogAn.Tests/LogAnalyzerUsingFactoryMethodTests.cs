using Xunit;

namespace LogAn.Tests
{
    public class LogAnalyzerUsingFactoryMethodTests
    {

        [Fact]
        public void OverrideTest()
        {
            //arrange
            var stub = new StubExtensionManager();
            stub.ShouldExtensionBeValid = true;

            var logAn = new TestableLogAnalyzer();
            logAn.Manager = stub;
            
            //act
            bool result = logAn.IsValidLogFileName("file.ext");

            //assert
            Assert.False(result, "File name should be too short to be considered valid.");
        }
    }
}
