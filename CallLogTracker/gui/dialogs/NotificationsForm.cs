using CallLogTracker.backend;
using CallLogTracker.backend.database.wrappers;
using CallLogTracker.backend.notifications;
using CallLogTracker.Properties;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallLogTracker.gui.dialogs
{
    public partial class NotificationsForm : KryptonForm
    {
        private bool isSMS = true;

        public NotificationsForm(bool smsSettings = true)
        {
            InitializeComponent();

            isSMS = smsSettings;

            btnSave.Click += SaveSettings;
        }

        private void NotificationsForm_Load(object sender, EventArgs e)
        {
            if (isSMS)
                Text = "Notifications [SMS]";
            else
                Text = "Notifications [Email]";

            SetupRecipients();
        }

        private void SaveSettings(object sender, EventArgs e)
        {
            if (isSMS)
            {
                Notifier.Instance.SMSRecipients.Clear();
                foreach (SMSRecipient u in chkLbRecipients.CheckedItems.Cast<SMSRecipient>())
                    Notifier.Instance.SMSRecipients.Add(u);

                Notifier.Instance.SaveSMSRecipients(Notifier.Instance.SMSRecipients.ToList());
            }
            else
            {
                Notifier.Instance.EmailRecipients.Clear();
                foreach (EmailRecipient u in chkLbRecipients.CheckedItems.Cast<EmailRecipient>())
                    Notifier.Instance.EmailRecipients.Add(u);

                Notifier.Instance.SaveEmailRecipients(Notifier.Instance.EmailRecipients.ToList());
            }

            CMessageBox.Show("Notificiation Settings Saved!", "Success", MessageBoxButtons.OK, Resources.success_64x64);
            Close();
        }

        private void SetupRecipients()
        {
            chkLbRecipients.Items.Clear();
            if (isSMS)
            {
                foreach (User u in Global.Instance.Users)
                    chkLbRecipients.Items.Add(new SMSRecipient() { User = u });

                foreach (SMSRecipient u in Notifier.Instance.SMSRecipients)
                {
                    int index = chkLbRecipients.Items.IndexOf(
                        chkLbRecipients.Items.Cast<SMSRecipient>().Where(
                        e => e.User.ID == u.User.ID).First());

                    if (index != -1)
                        chkLbRecipients.SetItemChecked(index, true);
                }
            }
            else
            {
                chkLbRecipients.Items.Clear();

                foreach (User u in Global.Instance.Users)
                    chkLbRecipients.Items.Add(new EmailRecipient() { User = u });

                foreach (EmailRecipient u in Notifier.Instance.EmailRecipients)
                {
                    int index = chkLbRecipients.Items.IndexOf(
                        chkLbRecipients.Items.Cast<EmailRecipient>().Where(
                        e => e.User.ID == u.User.ID).First());

                    if (index != -1)
                        chkLbRecipients.SetItemChecked(index, true);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkLbRecipients.Items.Count; i++)
                chkLbRecipients.SetItemChecked(i, true);
        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkLbRecipients.Items.Count; i++)
                chkLbRecipients.SetItemChecked(i, false);
        }

        private void btnUnselectCurrentUser_Click(object sender, EventArgs e)
        {
            int currentUserIndex = -1;

            if (isSMS)
                currentUserIndex = chkLbRecipients.Items
                    .IndexOf(chkLbRecipients.Items.Cast<SMSRecipient>()
                    .Where(c => c.User.ID == Global.Instance.CurrentUser.ID)
                    .First());
            else
                currentUserIndex = chkLbRecipients.Items
                    .IndexOf(chkLbRecipients.Items.Cast<EmailRecipient>()
                    .Where(c => c.User.ID == Global.Instance.CurrentUser.ID)
                    .First());

            if (currentUserIndex != -1)
                chkLbRecipients.SetItemChecked(currentUserIndex, false);
        }
    }
}
