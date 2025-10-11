using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BILL.Utilities
{
    public class EmailHelper
    {
        public static bool SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                var fromAddress = new MailAddress("animmaeed@gmail.com", "Fitness Tracker");
                var toAddress = new MailAddress(toEmail);
                const string fromPassword = "xcri ghax fbve lyvs"; 

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                    Timeout = 20000
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Email sending failed: " + ex.Message);
                return false;
            }
        }
    }
}
