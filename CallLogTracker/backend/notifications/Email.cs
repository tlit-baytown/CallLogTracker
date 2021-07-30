using CallLogTracker.Properties;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.backend.notifications
{
    public class Email
    {
        public static void SendEmail(EmailObject obj)
        {
            Console.WriteLine(Execute(obj).Status);
        }

        static async Task Execute(EmailObject obj)
        {
            SendGridClient client = new SendGridClient(Resources.Twilio_SendGridAPIKey);
            EmailAddress from = obj.Sender;
            if (obj.To.Count == 1)
            {
                var msg = MailHelper.CreateSingleTemplateEmail(from, obj.To.First(), obj.Subject, obj.TextBody, obj.HTMLBody);
                var response = await client.SendEmailAsync(msg);
                Console.WriteLine(response.Body);
            }
            else
            {
                var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, obj.To, obj.Subject, obj.TextBody, obj.HTMLBody);
                var response = await client.SendEmailAsync(msg);
                Console.WriteLine(response.Body);
            }
        }
    }
}

/*
 * {
  "caller_name": "Tira",
  "subject": "Important Call",
  "answerer": "Charlie",
  "call_back": "281-839-2829",
  "email": "recipient@example.com",
  "message": "User is having issues with her computer.",
  "timestamp": "7/30/2021 2:01 PM CST"
}
SendGrid (for email notifications): https://app.sendgrid.com
Twilio (for SMS notifications): https://console.twilio.com
Both logins are in KeePass
 */