using CallLogTracker.Properties;
using CallLogTracker.utility;
using System;
using System.Collections.Generic;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace CallLogTracker.backend.notifications
{
    public class SMS
    {
        private static SMS instance = null;
        private static object padlock = new object();

        public static SMS Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new SMS();
                    return instance;
                }
            }
        }

        private SMS()
        {
            TwilioClient.Init(ConfigReader.Instance.Twilio_AccountSID, ConfigReader.Instance.Twilio_AuthToken);
        }

        public string SendSMS(string txtBody, PhoneNumber recipient)
        {
            var message = MessageResource.Create(
                body: txtBody,
                from: new PhoneNumber(ConfigReader.Instance.Twilio_PhoneNumber),
                to: recipient
            );
            return $"{DateTime.Now.ToLocalTime()} -> Message to {recipient} has been {message.Status}.";
        }

        public string SendSMS(string txtBody, List<string> recipients)
        {
            StringBuilder bldr = new StringBuilder();

            foreach (string number in recipients)
            {
                bldr.Append(SendSMS(txtBody, new PhoneNumber(number))).Append("\n");
            }
            return bldr.ToString();
        }
    }
}
