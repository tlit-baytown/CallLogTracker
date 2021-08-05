
namespace CallLogTracker.gui.dialogs
{
    partial class NotificationsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHelpText = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.chkLbRecipients = new ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox();
            this.btnSelect = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDeselect = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUnselectCurrentUser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // lblHelpText
            // 
            this.lblHelpText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lblHelpText.Location = new System.Drawing.Point(12, 9);
            this.lblHelpText.Name = "lblHelpText";
            this.lblHelpText.Size = new System.Drawing.Size(625, 20);
            this.lblHelpText.StateCommon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpText.Text = "Select the recipients below that should be notified of calls when clicking the \"N" +
    "otify\" buttons.";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::CallLogTracker.Properties.Resources.save_16x16;
            this.btnSave.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UniqueName = "D5393BFA424D4D2FD99413E9E9150C4C";
            // 
            // chkLbRecipients
            // 
            this.chkLbRecipients.CheckOnClick = true;
            this.chkLbRecipients.Location = new System.Drawing.Point(13, 33);
            this.chkLbRecipients.Name = "chkLbRecipients";
            this.chkLbRecipients.Size = new System.Drawing.Size(624, 229);
            this.chkLbRecipients.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(13, 268);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(110, 25);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Values.Text = "Select All";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDeselect
            // 
            this.btnDeselect.Location = new System.Drawing.Point(129, 268);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(110, 25);
            this.btnDeselect.TabIndex = 3;
            this.btnDeselect.Values.Text = "Unselect All";
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // btnUnselectCurrentUser
            // 
            this.btnUnselectCurrentUser.Location = new System.Drawing.Point(482, 268);
            this.btnUnselectCurrentUser.Name = "btnUnselectCurrentUser";
            this.btnUnselectCurrentUser.Size = new System.Drawing.Size(155, 25);
            this.btnUnselectCurrentUser.TabIndex = 4;
            this.btnUnselectCurrentUser.Values.Text = "Unselect Yourself";
            this.btnUnselectCurrentUser.Click += new System.EventHandler(this.btnUnselectCurrentUser_Click);
            // 
            // NotificationsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnSave});
            this.ClientSize = new System.Drawing.Size(650, 304);
            this.Controls.Add(this.btnUnselectCurrentUser);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.chkLbRecipients);
            this.Controls.Add(this.lblHelpText);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NotificationsForm";
            this.Text = "Notifications [SMS]";
            this.Load += new System.EventHandler(this.NotificationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblHelpText;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox chkLbRecipients;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSelect;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeselect;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUnselectCurrentUser;
    }
}