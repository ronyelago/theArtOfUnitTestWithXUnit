namespace LogAn
{
    public class TestableLogAnalyzer : LogAnalyzerFactoryMethod
    {
        public IExtensionManager Manager;

        protected override IExtensionManager GetManager()
        {
            return Manager;
        }
    }
}
