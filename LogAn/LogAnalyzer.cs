namespace LogAn
{
    public class LogAnalyzer
    {
        private readonly IExtensionManager _manager;

        public bool WasLastFileNameValid { get; set; }

        public LogAnalyzer()
        {
            _manager = ExtensionManagerFactory.Create();
        }

        // in this new refactored version we extract an interface to break the dependency and meke our code more testable
        public bool IsValidLogFileName(string fileName)
        {
            WasLastFileNameValid = _manager.IsValid(fileName);

            return WasLastFileNameValid && Path.GetFileNameWithoutExtension(fileName).Length > 5;
        }
    }
}
