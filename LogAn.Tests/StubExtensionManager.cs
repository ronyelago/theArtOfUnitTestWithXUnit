namespace LogAn.Tests
{
    public class StubExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName) => true;
    }
}
