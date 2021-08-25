using SendGrid.Helpers.Mail;
using System.Collections.Generic;

namespace CallLogTracker.backend.notifications
{
    public class MessageObject
    {
        public List<EmailAddress> To { get; set; } = new List<EmailAddress>();
        public List<TemplateData> Data { get; set; } = new List<TemplateData>();
    }
}
