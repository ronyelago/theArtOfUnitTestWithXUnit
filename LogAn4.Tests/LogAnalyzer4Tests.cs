using System;
using Xunit;

namespace LogAn4.Tests
{
    public class LogAnalyzer4Tests
    {
        [Fact]
        public void Analyze_TooShortFileName_CallWebService()
        {
            //arrange
            var mockWebService = new MockService();
            var log = new LogAnalyzer();
            log.WebService = mockWebService;
            log.EmailService = new MockEmailService();

            var tooShortFileName = "abc.txt";

            //act
            log.Analyze(tooShortFileName);

            //assert
            Assert.Equal($"Filename too short: {tooShortFileName}", mockWebService.LastError);
        }

        [Fact]
        public void Analyze_WebServiceThrows_SendsEmail()
        {
            //arrange
            var stubWebService = new StubService();
            stubWebService.ToThrow = new Exception("fake exception");

            var mockEmailService = new MockEmailService();
            
            var logAn = new LogAnalyzer();
            logAn.WebService = stubWebService;
            logAn.EmailService = mockEmailService;

            var tooShortFileName = "abc.txt";
            
            //act
            logAn.Analyze(tooShortFileName);

            //assert
            Assert.Equal("a", mockEmailService.To);
            Assert.Equal("subject", mockEmailService.Subject);
            Assert.Equal("fake exception", mockEmailService.Body);
        }
    }
}
