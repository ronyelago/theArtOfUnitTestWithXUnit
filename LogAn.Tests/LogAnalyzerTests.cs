using Xunit;

namespace LogAn.Tests
{
    public class LogAnalyzerTests
    {
        private LogAnalyzer logAn;

        public LogAnalyzerTests()
        {
            logAn = new LogAnalyzer();
        }

        [Fact]
        public void IsValidLogFileName_validFile_returnsTrue()
        {
            //arrange
            string fileName = "jozias.SLF";

            //act
            var isValidFileName = logAn.IsValidLogFileName(fileName);

            //assert
            Assert.True(isValidFileName);   
        }

        [Fact]
        public void IsValidFileName_invalidFile_returnsFalse()
        {
            //arrange
            string fileName = "munhoz.TXT";

            //act
            var invalidFileName = logAn.IsValidLogFileName(fileName);

            //assert
            Assert.False(invalidFileName);
        }

        [Fact]
        public void IsValidFileName_EmptyFileName_ThrowsException()
        {
            //arrange
            string fileName = string.Empty;

            //act 
            Action action = () => logAn.IsValidLogFileName(fileName);
            
            //asserts
            var ex = Assert.Throws<ArgumentException>(() => logAn.IsValidLogFileName(fileName));
            Assert.Equal("filename has to be provided", ex.Message);
        }
    }
}
