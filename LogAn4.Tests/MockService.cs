namespace LogAn4.Tests
{
    public class MockService : IWebService
    {
        public string LastError { get; set; }

        public void LogError(string message)
        {
            LastError = message;
        }
    }
}
