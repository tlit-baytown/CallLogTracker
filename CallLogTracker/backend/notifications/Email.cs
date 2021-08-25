using CallLogTracker.Properties;
using CallLogTracker.utility;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallLogTracker.backend.notifications
{
    public class Email
    {
        public static void SendEmail(MessageObject obj)
        {
            Execute(obj);
        }

        static async Task Execute(MessageObject obj)
        {
            SendGridClient client = new SendGridClient(ConfigReader.Instance.SendGrid_ApiKey);
            EmailAddress from = new EmailAddress(ConfigReader.Instance.SendGrid_Sender);
            if (obj.To.Count == 1)
            {
                var msg = MailHelper.CreateSingleTemplateEmail(from, obj.To.First(), ConfigReader.Instance.SendGrid_Template_Id, obj.Data.First());
                var response = await client.SendEmailAsync(msg);
            }
            else
            {
                var msg = MailHelper.CreateMultipleTemplateEmailsToMultipleRecipients(from, obj.To, ConfigReader.Instance.SendGrid_Template_Id, (List<object>)obj.Data.Cast<object>());
                var response = await client.SendEmailAsync(msg);
            }
        }
    }
}