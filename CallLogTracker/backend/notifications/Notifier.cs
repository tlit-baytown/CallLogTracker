using CallLogTracker.backend.database;
using CallLogTracker.backend.database.wrappers;
using CallLogTracker.Properties;
using CallLogTracker.utility;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.backend.notifications
{
    public class Notifier
    {
        private static Notifier instance = null;
        private static readonly object padlock = new object();
        public SortableBindingList<SMSRecipient> SMSRecipients { get; set; } = new SortableBindingList<SMSRecipient>();
        public SortableBindingList<EmailRecipient> EmailRecipients { get; set; } = new SortableBindingList<EmailRecipient>();

        private Notifier() { }

        public static Notifier Instance
        {
            get
            {
                lock(padlock)
                {
                    if (instance == null)
                        instance = new Notifier();
                    return instance;
                }
            }
        }

        //Initialize the recipients with those from settings.
        public void Initialize()
        {
            SMSRecipients = new SortableBindingList<SMSRecipient>();
            EmailRecipients = new SortableBindingList<EmailRecipient>();

            if (!Settings.Default.SMSRecipients.Equals("None"))
            {
                string[] ids = Settings.Default.SMSRecipients.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                foreach (string id in ids)
                {
                    int intID = int.Parse(id);
                    SMSRecipient usr = new SMSRecipient() { User = Global.Instance.Users.Where(u => u.ID == intID).FirstOrDefault() };
                    if (usr != null)
                        SMSRecipients.Add(usr);
                }
            }
            else
            {
                List<SMSRecipient> temp = new List<SMSRecipient>();
                foreach (User u in Global.Instance.Users)
                    temp.Add(new SMSRecipient() { User = u });

                SaveSMSRecipients(temp);
            }

            if (!Settings.Default.EmailRecipients.Equals("None"))
            {
                string[] ids = Settings.Default.EmailRecipients.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string id in ids)
                {
                    int intID = int.Parse(id);
                    EmailRecipient usr = new EmailRecipient() { User = Global.Instance.Users.Where(u => u.ID == intID).FirstOrDefault() };
                    if (usr != null)
                        EmailRecipients.Add(usr);
                }
            }
            else
            {
                List<EmailRecipient> temp = new List<EmailRecipient>();
                foreach (User u in Global.Instance.Users)
                    temp.Add(new EmailRecipient() { User = u });

                SaveEmailRecipients(temp);
            }
        }

        //Save the SMS recipients to the settings.
        public void SaveSMSRecipients(List<SMSRecipient> employees)
        {
            if (employees == null)
                return;

            Settings.Default.SMSRecipients = "";
            StringBuilder bldr = new StringBuilder();

            foreach (SMSRecipient u in employees)
                bldr.Append($"{u.User.ID};");

            Settings.Default.SMSRecipients = bldr.ToString();
            Settings.Default.Save();

            Initialize();
        }

        //Save the Email recipients to the settings.
        public void SaveEmailRecipients(List<EmailRecipient> employees)
        {
            if (employees == null)
                return;

            Settings.Default.EmailRecipients = "";
            StringBuilder bldr = new StringBuilder();

            foreach (EmailRecipient u in employees)
                bldr.Append($"{u.User.ID};");

            Settings.Default.EmailRecipients = bldr.ToString();
            Settings.Default.Save();

            Initialize();
        }

        //Notify all recipients of the call.
        public bool Notify(Call c)
        {
            if (c == null)
                return false;

            if (Settings.Default.SMSRecipients.Equals("None"))
            {
                Global.Instance.MainForm.GetConsole().AddEntry("No employees in list to notify!");
                return false;
            }

            TemplateData data = new TemplateData()
            {
                Answerer = Global.Instance.CurrentUser.Name,
                CallBackNumber = c.CallerPhone,
                CallerName = c.CallerName,
                EmailAddress = c.CallerEmail == null ? "" : c.CallerEmail,
                Message = c.Message.Length > 255 ? c.Message.Substring(0, 255) : c.Message,
                Subject = c.IsUrgent ? "Urgent message from Call Tracker" : "New message from Call Tracker",
                TimeStamp = c.Date,
                CallID = c.ID
            };

            //SMS Notifications
            List<string> phoneNumbers = new List<string>();
            foreach (SMSRecipient s in SMSRecipients)
                phoneNumbers.Add($"+1{s.User.PhoneNumber.Replace("-", "")}");

            SMS.Instance.SendSMS(data.ToSMSMessage(), phoneNumbers);

            //Email Notifications
            MessageObject obj = new MessageObject();
            foreach (EmailRecipient e in EmailRecipients)
                obj.To.Add(new EmailAddress(e.User.Email, e.User.Name));
            obj.Data.Add(data);

            Email.SendEmail(obj);
            return true;

        }
    }
}
