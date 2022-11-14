using Xunit;

namespace LogAn.Tests
{
    public class LogAnalyzerTests
    {
        private LogAnalyzer logAn;
        private StubExtensionManager stubExtensionManager;

        public LogAnalyzerTests()
        {
            stubExtensionManager = new StubExtensionManager();
            stubExtensionManager.ShouldExtensionBeValid = true;
            ExtensionManagerFactory.CustomManager = stubExtensionManager;
            
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
        public void IsValidFileName_NameShorterThan6CharsButSupportedExtension_ReturnsFalse()
        {
            // arrange
            var stub = new StubExtensionManager();
            stub.ShouldExtensionBeValid = true;

            //act
            bool isValid = logAn.IsValidLogFileName("short.wsx");

            // assert
            Assert.False(isValid, "File name with less than 5 chars should have failed the method, even if the extension is supported");
        }
    }
}
