using Xunit;

namespace LogAn4.Tests
{
    public class LogAnalyzer4Tests
    {
        [Fact]
        public void Analyze_TooShortFileName_CallWebService()
        {
            //arrange
            var service = new MockService();
            var log = new LogAnalyzer();
            var tooShortFileName = "abc.txt";

            //act
            log.Analyze(tooShortFileName);

            //assert
            Assert.Equal($"Filename too short:{tooShortFileName}", service.LastError);
        }
    }
}
