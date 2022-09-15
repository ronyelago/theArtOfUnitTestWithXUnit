namespace LogAn
{
    public class LogAnalyzer
    {
        private readonly IExtensionManager _manager;

        public bool WasLastFileNameValid { get; set; }

        public LogAnalyzer( IExtensionManager manager)
        {
            _manager = manager;
        }

        public bool IsValidLogFileName(string fileName)
        {
            

            WasLastFileNameValid = _manager.IsValid(fileName);

            return WasLastFileNameValid;
        }
    }
}
