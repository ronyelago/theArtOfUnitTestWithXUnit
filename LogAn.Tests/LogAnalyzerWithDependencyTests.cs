using Xunit;

namespace LogAn.Tests
{
    public class LogAnalyzerWithDependencyTests
    {
        // below tests are integration tests because they have an extarnal dependency
        [Fact]
        public void IsValidFileNameOld_ValidFileUpperCased_ReturnsTrue()
        {
            var logAn = new LogAnalyzerWithDependency();

            //arrange
            string fileName = "whatever.SLF";

            //act
            bool isValidFileName = logAn.IsValidLogFileNameOld(fileName);

            //assert
            Assert.True(isValidFileName, "fileName should be valid!");
        }

        [Fact]
        public void IsValidFileNameOld_ValidFileLowerCased_ReturnsTrue()
        {
            var logAn = new LogAnalyzerWithDependency();

            //arrange
            string fileName = "whatever.slf";

            //act
            bool isValidFileName = logAn.IsValidLogFileNameOld(fileName);

            //assert
            Assert.True(isValidFileName, "fileName should be valid!");
        }

        [Fact]
        public void IsValidFileNameOld_EmptyFileName_ThrowsArgumentException()
        {
            var logAn = new LogAnalyzerWithDependency();

            //arrange
            string fileName = string.Empty;

            //act
            Action action = () => logAn.IsValidLogFileNameOld(fileName);

            //asserts
            var ex = Assert.Throws<ArgumentException>(action);
            Assert.Equal("No file name provided!", ex.Message);
        }

        [Fact]
        public void IsValidFileNameOld_InvalidFileName_ReturnsFalse()
        {
            var logAn = new LogAnalyzerWithDependency();

            //arrange
            string fileName = "wav";

            //act
            bool isValid = logAn.IsValidLogFileNameOld(fileName);

            //assert
            Assert.False(isValid);
        }
    }
}
