namespace LogAn4
{
    public class LogAnalyzer
    {
        private IWebService _webService;
        private IEmailService _emailService;

        public IWebService WebService { get => _webService; set => _webService = value; }
        public IEmailService EmailService { get => _emailService; set => _emailService = value; }

        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
            {
                try
                {
                    _webService.LogError($"Filename too short: {fileName}");
                }
                catch (Exception ex)
                {
                    _emailService.SendEmail("a", "subject", ex.Message);
                }
            }
        }
    }
}
