using System.Net;
using System.Net.Mail;

namespace SMTPClientLearn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SmtpClient smtpClient = new SmtpClient("host", 221);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("username", "password");

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("sender@gmail.com");
            mailMessage.To.Add("receiver@gmail.com");

            mailMessage.Subject = "This is a subject";
            mailMessage.Body = "This is a body";

            smtpClient.Send(mailMessage);
        }
    }
}
