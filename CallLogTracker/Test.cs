using CallLogTracker.backend.notifications;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker
{
    class Test
    {
        public void Testing()
        {
            MessageObject obj = new MessageObject
            {
                To = new List<EmailAddress>() { new EmailAddress("ethan.hann@protonmail.com", "Ethan") }
            };
            TemplateData data = new TemplateData()
            {
                Answerer = "Charlie",
                CallBackNumber = "832-599-4248",
                CallerName = "Tony Smith",
                EmailAddress = "tsmith@email.com",
                Message = "User is having problems getting their computer to start. Requests a call back immediately.",
                Subject = "Urgent message from Call Tracker",
                TimeStamp = DateTime.Now
            };

            obj.Data.Add(data);

            Email.SendEmail(obj);

            SMS.Instance.SendSMS(obj.Data.First().ToSMSMessage(), new List<string> { "+18325994248" });
        }
    }
}
