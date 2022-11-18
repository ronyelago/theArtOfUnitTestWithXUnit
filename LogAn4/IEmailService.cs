namespace LogAn4
{
    public interface IEmailService
    {
        public void SendEmail(string to, string subject, string body);
    }
}
