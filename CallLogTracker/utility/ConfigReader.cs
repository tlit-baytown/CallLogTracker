using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.utility
{
    public class ConfigReader
    {
        private const string configFile = "../config.cfg";

        private static ConfigReader instance;
        private static object padlock = new object();

        private ConfigReader() { }

        public static ConfigReader Instance
        {
            get
            {
                lock(padlock)
                {
                    if (instance == null)
                        instance = new ConfigReader();
                    return instance;
                }
            }
        }

        public void Initialize()
        {
            if (!File.Exists(configFile))
            {
                File.Create(configFile);
                AddLines();
            }
            else
            {
                ReadConfig();
            }
        }

        public string SendGrid_Sender { get; private set; } = string.Empty;
        public string SendGrid_ApiKey { get; private set; } = string.Empty;
        public string SendGrid_Template_Id { get; private set; } = string.Empty;
        public string Twilio_AccountSID { get; private set; } = string.Empty;
        public string Twilio_AuthToken { get; private set; } = string.Empty;
        public string Twilio_PhoneNumber { get; private set; } = string.Empty;
        public string Twilio_PhoneNumber_SID { get; private set; } = string.Empty;

        public bool ValidConfig { get; private set; } = false;

        private void AddLines()
        {
            try
            {
                StringBuilder bldr = new StringBuilder();
                bldr.AppendLine("sendgrid_sender=none");
                bldr.AppendLine("sendgrid_api_key=none");
                bldr.AppendLine("sendgrid_template_id=none");
                bldr.AppendLine("twilio_accountsid=none");
                bldr.AppendLine("twilio_authtoken=none");
                bldr.AppendLine("twilio_phone_number=none");
                bldr.AppendLine("twilio_phone_number_sid=none");

                File.WriteAllText(configFile, bldr.ToString());

            } catch (Exception e)
            {
                Console.WriteLine($"Could not read/write the config file: {e.Message}");
            }
        }

        /// <summary>
        /// Read the configuration file present at the root of the application hierarchy.
        /// <para>The file should be named <c>config.cfg</c> and should contain populated entries; i.e. no value entry should be <c>none</c></para>
        /// <para>The layout is: <c>key=value</c> where each key-value pair is on a new line.</para>
        /// </summary>
        /// <returns><c>true</c> if the config was successfully read from with valid values. <c>false</c> otherwise.</returns>
        public bool ReadConfig()
        {
            try
            {
                string[] configLines = File.ReadAllLines(configFile);
                if (configLines.Length == 0)
                    AddLines();

                foreach (string line in configLines)
                {
                    string[] parts = line.Split('=');
                    if (parts.Length != 2)
                    {
                        ValidConfig = false;
                        AddLines();
                        return ReadConfig();
                    }

                    switch (parts[0])
                    {
                        case "sendgrid_sender":
                            SendGrid_Sender = parts[1];
                            break;
                        case "sendgrid_api_key":
                            SendGrid_ApiKey = parts[1];
                            break;
                        case "sendgrid_template_id":
                            SendGrid_Template_Id = parts[1];
                            break;
                        case "twilio_accountsid":
                            Twilio_AccountSID = parts[1];
                            break;
                        case "twilio_authtoken":
                            Twilio_AuthToken = parts[1];
                            break;
                        case "twilio_phone_number":
                            Twilio_PhoneNumber = parts[1];
                            break;
                        case "twilio_phone_number_sid":
                            Twilio_PhoneNumber_SID = parts[1];
                            break;
                        default:
                            ValidConfig = false;
                            break;
                    }

                    if (parts[1].ToLower().Equals("none"))
                        ValidConfig = false;
                    else
                        ValidConfig = true;
                }
            }
            catch (Exception e)
            {
                Global.Instance.MainForm.GetConsole().AddEntry($"Could not read config file: {e.Message}");
            }

            return ValidConfig;
        }
    }
}
