namespace LogAn
{
    public class LogAnalyzer
    {
        public bool WasLastFileNameValid { get; set; }

        public bool IsValidLogFileName(string fileName)
        {
            var manager = new FileExtensionManager();

            WasLastFileNameValid = manager.IsValid(fileName);

            return WasLastFileNameValid;
        }
    }
}
