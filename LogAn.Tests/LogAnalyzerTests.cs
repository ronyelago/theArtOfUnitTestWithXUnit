using Xunit;

namespace LogAn.Tests
{
    public class LogAnalyzerTests
    {
        private LogAnalyzer logAn;
        private StubExtensionManager stubManager;

        public LogAnalyzerTests()
        {
            ExtensionManagerFactory.CustomManager = new StubExtensionManager();
            logAn = new LogAnalyzer();
        }

        [Fact]
        public void IsValidLogFileName_ValidFile_ReturnsTrue()
        {
            //arrange
            string fileName = "jozias.SLF";

            //act
            var isValidFileName = logAn.IsValidLogFileName(fileName);

            //assert
            Assert.True(isValidFileName);   
        }

        [Fact]
        public void IsValidFileName_InvalidFile_ReturnsFalse()
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
            ExtensionManagerFactory.CustomManager = new StubExtensionManager();

            //act 
            Action action = () => logAn.IsValidLogFileName(fileName);
            
            //asserts
            var ex = Assert.Throws<ArgumentException>(() => logAn.IsValidLogFileName(fileName));
            Assert.Equal("filename has to be provided", ex.Message);
        }

        [Fact]
         public void IsValidFileName_ValidName_RemembersTrue()
        {
            //arrange
            string fileName = "whatever.slf";

            //act
            logAn.IsValidLogFileName(fileName);
            
            //assert
            Assert.True(logAn.WasLastFileNameValid);
        }

        [Fact]
        public void IsValidFileNameOld_ValidFileUpperCased_ReturnsTrue()
        {
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
            //arrange
            string fileName = "whatever.slf";

            //act
            bool isValidFileName = logAn.IsValidLogFileNameOld(fileName);

            //assert
            Assert.True(isValidFileName, "fileName should be valid!");
        }

        [Fact]
        public void IsValidFileName_EmptyFileName_ThrowsArgumentException()
        {
            //arrange
            string fileName = string.Empty;

            //act
            Action action = () => logAn.IsValidLogFileNameOld(fileName);

            //assert
            var ex = Assert.Throws<ArgumentException>(action);
            Assert.Equal("No file name provided!", ex.Message);
        }
    }
}
