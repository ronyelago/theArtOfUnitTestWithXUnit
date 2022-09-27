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
            //oi, eu sou o goku e estou comitando isso num dia que não consegui estudar testes unitário. amanhã eu conseguiriei !!! <3
        }
    }
}
