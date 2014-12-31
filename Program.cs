using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMailViaSmtpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.Mail.MailMessage mailMsg = new System.Net.Mail.MailMessage();
            mailMsg.To.Add("username@servername.com");
            mailMsg.From = new System.Net.Mail.MailAddress("username@163.com");
            mailMsg.Subject = "test mail";
            mailMsg.Body = "just a test";

            try
            {
                System.Net.Mail.SmtpClient sc = new System.Net.Mail.SmtpClient("smtp.163.com");
                sc.Credentials = new System.Net.NetworkCredential("username", "password");
                sc.Send(mailMsg);
                Console.WriteLine("success");
            }
            catch
            {
                Console.WriteLine("fail");
            }
        }
    }
}
