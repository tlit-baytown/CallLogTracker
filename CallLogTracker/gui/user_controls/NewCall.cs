using CallLogTracker.backend.database.wrappers;
using CallLogTracker.backend.notifications;
using CallLogTracker.gui.dialogs;
using CallLogTracker.Properties;
using CallLogTracker.utility;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static CallLogTracker.utility.Enums;

namespace CallLogTracker.gui.user_controls
{
    public partial class NewCall : UserControl
    {
        private readonly Call newCall;
        private bool isEditing = false;

        public NewCall()
        {
            InitializeComponent();

            newCall = new Call();
            if (Global.Instance.CurrentCompany != null && Global.Instance.CurrentUser != null)
            {
                newCall.CompanyID = Global.Instance.CurrentCompany.ID;
                newCall.UserID = Global.Instance.CurrentUser.ID;
            }

            newCall.Date = DateTime.Now;

            lblLastUpdated.Visible = false;
        }

        public NewCall(Call c)
        {
            InitializeComponent();

            if (c != null)
                newCall = c;

            hdrGroup.ValuesPrimary.Heading = $"Edit Call Record [{newCall.ID}.{newCall.UserID}.{newCall.CompanyID}]";
            hdrGroup.ValuesPrimary.Description = "Edit an existing call record. Fields marked * are required.";
            lblLastUpdated.Visible = true;
            isEditing = true;

            PopulateFields();
        }

        private void PopulateFields()
        {
            if (newCall != null)
            {
                txtCallerName.Text = newCall.CallerName;
                txtPhoneNumber.Text = newCall.CallerPhone;
                txtCallerEmail.Text = newCall.CallerEmail == null ? "" : newCall.CallerEmail;
                rtbMessage.Text = newCall.Message;
                lblLastUpdated.Text = $"Last Updated: {newCall.Timestamp.ToLocalTime()}";
            }
        }

        private KryptonPage GetParent()
        {
            return Parent as KryptonPage;
        }

        private void btnSaveAndNotify_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                Global.Instance.SelectedPageUniqueName = GetParent().UniqueName;

                if (Notifier.Instance.Notify(newCall))
                    Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Recipients notified of call {newCall.ID}.{newCall.UserID}.{newCall.CompanyID}");
                else
                    Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> There was an error while trying to notify recipients of call {newCall.ID}.{newCall.UserID}.{newCall.CompanyID}.");

                if (isEditing)
                    Global.Instance.MainForm.DockingWorkspace.DockingManager.CloseRequest(new string[] { Global.Instance.SelectedPageUniqueName });
                else
                    Global.Instance.MainForm.DockingWorkspace.RemovePage(Global.Instance.SelectedPageUniqueName, true);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                Global.Instance.SelectedPageUniqueName = GetParent().UniqueName;

                if (isEditing)
                    Global.Instance.MainForm.DockingWorkspace.DockingManager.CloseRequest(new string[] { Global.Instance.SelectedPageUniqueName });
                else
                    Global.Instance.MainForm.DockingWorkspace.RemovePage(Global.Instance.SelectedPageUniqueName, true);
            }
        }

        private bool Save()
        {
            List<ValidatorError> errors = newCall.ValidateObject();

            if (errors.Count > 0)
            {
                string richText = Validator.ToRichText(errors);
                CRichMsgBox.Show("The call did not pass validation checks. Check below for issues:", "Invalid Call", richText, MessageBoxButtons.OK, Resources.error_64x64);
                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Call could not be added because of validation checks.");
                return false;
            }

            string callInsert = newCall.Insert();
            if (!callInsert.Contains("error"))
            {
                //If this call is not already in the list, add it. Otherwise, update it.
                if (Global.Instance.CallsToday.ToList().Where(c => c.ID == newCall.ID).Count() <= 0)
                    Global.Instance.CallsToday.Add(newCall);
                else
                {
                    int index = Global.Instance.CallsToday.ToList().FindIndex(c => c.ID == newCall.ID);
                    if (index != -1)
                        Global.Instance.CallsToday[index] = newCall;
                    else
                        Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Could not find call with id {newCall.ID} in the list of calls.");
                }

                Global.Instance.MainForm.UpdateCalls();

                return true;
            }

            Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> {callInsert}");

            return false;
        }

        #region GUI Events
        private void rtbMessage_TextChanged(object sender, EventArgs e)
        {
            lblCharCount.Text = "Char. Count: " + rtbMessage.Text.Count() + " / 65,535";
            newCall.Message = rtbMessage.Text;
        }

        private void chkIsUrgent_CheckedChanged(object sender, EventArgs e)
        {
            newCall.IsUrgent = chkIsUrgent.Checked;
        }

        private void txtCallerName_TextChanged(object sender, EventArgs e)
        {
            newCall.CallerName = txtCallerName.Text;
        }

        private void txtCallerEmail_TextChanged(object sender, EventArgs e)
        {
            newCall.CallerEmail = txtCallerEmail.Text;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            newCall.CallerPhone = txtPhoneNumber.Text;
        }

        private void ResetHelpText(object sender, EventArgs e)
        {
            hdrGroup.ValuesSecondary.Heading = "Hover over a label for more information.";
        }

        private void lblCallerName_MouseEnter(object sender, EventArgs e)
        {
            hdrGroup.ValuesSecondary.Heading = "Enter the caller's full name. (Max: 255 chars)";
        }

        private void lblCallerEmail_MouseEnter(object sender, EventArgs e)
        {
            hdrGroup.ValuesSecondary.Heading = "Enter, if applicable, the caller's email address. (Max: 255 chars)";
        }

        private void lblPhoneNumber_MouseEnter(object sender, EventArgs e)
        {
            hdrGroup.ValuesSecondary.Heading = "Enter the best call-back number for the caller. (Max: 12 chars)";
        }

        private void chkIsUrgent_MouseEnter(object sender, EventArgs e)
        {
            hdrGroup.ValuesSecondary.Heading = "Is this call of an urgent nature?";
        }

        private void kryptonGroupBox1_MouseEnter(object sender, EventArgs e)
        {
            hdrGroup.ValuesSecondary.Heading = "Enter the full message to be passed on to recipients of notifications. (Max: 65,535 chars)";
        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            KryptonTextBox txtBox = sender as KryptonTextBox;
            if (txtBox != null)
                txtBox.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 128);
            else
            {
                KryptonComboBox cmb = sender as KryptonComboBox;
                if (cmb != null)
                    cmb.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(255, 255, 128);
            }

            BeginInvoke((MethodInvoker)delegate ()
            {
                txtPhoneNumber.Select(0, 0);
            });
        }

        private void txtBox_Enter(object sender, EventArgs e)
        {
            KryptonTextBox txtBox = sender as KryptonTextBox;
            if (txtBox != null)
                txtBox.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 128);
            else
            {
                KryptonComboBox cmb = sender as KryptonComboBox;
                if (cmb != null)
                    cmb.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(255, 255, 128);
            }
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
            KryptonTextBox txtBox = sender as KryptonTextBox;
            if (txtBox != null)
                txtBox.StateCommon.Back.Color1 = Color.White;
            else
            {
                KryptonComboBox cmb = sender as KryptonComboBox;
                if (cmb != null)
                    cmb.StateCommon.ComboBox.Back.Color1 = Color.White;
            }
        }

        private void rtbMessage_Enter(object sender, EventArgs e)
        {
            rtbMessage.StateCommon.Border.Color1 = Color.Red;
        }

        private void rtbMessage_Leave(object sender, EventArgs e)
        {
            rtbMessage.StateCommon.Border.Color1 = Color.Black;
        }
        #endregion
    }
}
