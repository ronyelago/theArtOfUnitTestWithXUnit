namespace LogAn
{
    public class FileExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentException("filename has to be provided");

            if (!fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase) || Path.GetFileNameWithoutExtension(fileName).Length > 5)
                return false;

            return true;
        }
    }
}
