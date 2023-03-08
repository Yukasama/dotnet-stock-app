using System.Net.Mail;
using System.Net;


namespace Obliviate.Services.Essentials
{
    public class EmailSender
    {
        SmtpClient client;
        string host;
        MailMessage message;

        public EmailSender(string to)
        {
            SmtpClient client = new SmtpClient();
            client.Host = "daszehntefragezeichen@gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("username", "password");
            message = new MailMessage();
            message.From = new MailAddress("daszehntefragezeichen@gmail.com");
            message.To.Add(to);
            message.Subject = "Account Confirmation";
            message.Body = "This is a test email.";
        }

        public void Send()
        {
            client.Send(message);
        }
    }
}
