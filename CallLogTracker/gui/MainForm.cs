using CallLogTracker.backend.notifications;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallLogTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmailObject obj = new EmailObject
            {
                To = new List<EmailAddress>() { new EmailAddress("ehann@teamlogicit.com", "Ethan (Work)") },
                Sender = new EmailAddress("supportbayareatx@teamlogicit.com", "TeamLogicIT Support"),
                Subject = "Hello, this is a test email.",
                TextBody = "This should be the text body.",
                HTMLBody = "<h1>This should be the html body.</h1>"
            };

            richTextBox1.Text = "Sending email...";
            Email.SendEmail(obj);
            //richTextBox1.Text = Email.Instance.SendEmail(obj);

            //richTextBox1.Text = SMS.Instance.SendSMS("This message was sent from C#.net!", new List<string> { "+1713 899 1837", "+18325994248" });
        }
    }
}
