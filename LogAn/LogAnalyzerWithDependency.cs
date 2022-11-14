namespace LogAn
{
    public class LogAnalyzerWithDependency
    {
        public bool WasLastFileNameValid { get; set; }

        // in this version we have a external dependency that reads an external file where the valids extensions are located
        // other external dependency also can be an database or an queue
        // in this case we have an integration test instead of an unit test
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
