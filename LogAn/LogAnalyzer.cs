using System.Reflection;

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

        // in this version we extract an interface to break the dependency and meke our code more testable
        public bool IsValidLogFileName(string fileName)
        {
            WasLastFileNameValid = _manager.IsValid(fileName);

            return WasLastFileNameValid && Path.GetFileNameWithoutExtension(fileName).Length > 5;
        }

        // in this version we have a external dependency that reads an external file where the valids extensions are located
        // other external dependency also can be an database or an queue
        public bool IsValidLogFileNameOld(string fileName)
        {
            WasLastFileNameValid = false;

            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("No file name provided!");
            }

            string contents = File.ReadAllText(@"C://projects//aout//validExtensions.txt");

            foreach (var extension in contents.Split(','))
            {
                if (fileName.EndsWith(extension))
                {
                    WasLastFileNameValid = true;

                    return true;
                }
            }

            return false;
        }
    }
}
