﻿namespace LogAn
{
    public class LogAnalyzer
    {
        private readonly IExtensionManager _manager;

        public bool WasLastFileNameValid { get; set; }

        public LogAnalyzer()
        {
            _manager = ExtensionManagerFactory.Create();
        }

        public bool IsValidLogFileName(string fileName)
        {
            WasLastFileNameValid = _manager.IsValid(fileName);

            return WasLastFileNameValid && Path.GetFileNameWithoutExtension(fileName).Length > 5;
        }

        public bool IsValidLogFileNameOld(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentException("No file name provided!");

            if (!fileName.ToLower().EndsWith(".slf"))
                return false;

            return true;
        }
    }
}
