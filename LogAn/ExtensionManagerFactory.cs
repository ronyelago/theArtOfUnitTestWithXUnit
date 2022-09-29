namespace LogAn
{
    public class ExtensionManagerFactory
    {
        private static IExtensionManager customManager;

        public static IExtensionManager CustomManager { get => customManager; set => customManager = value; }

        public static IExtensionManager Create()
        {
            if (customManager != null)
                return customManager;
            
            return new FileExtensionManager();
        }
    }
}
