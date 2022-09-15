namespace LogAn
{
    public class LogAnalyzer
    {
        public bool WasLastFileNameValid { get; set; }

        public bool IsValidLogFileName(string fileName)
        {
            var manager = new FileExtensionManager();

            return manager.IsValid(fileName);
        }
    }
}
