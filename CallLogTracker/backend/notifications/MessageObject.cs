using CallLogTracker.Properties;
using Newtonsoft.Json;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.backend.notifications
{
    public class MessageObject
    {
        public List<EmailAddress> To { get; set; } = new List<EmailAddress>();
        public List<TemplateData> Data { get; set; } = new List<TemplateData>();
    }
}
