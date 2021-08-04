using CallLogTracker.backend.database.wrappers;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
            Global.Instance.SelectedPageUniqueName = GetParent().UniqueName;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Global.Instance.SelectedPageUniqueName = GetParent().UniqueName;


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
