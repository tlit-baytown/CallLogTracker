
namespace CallLogTracker
{
    partial class MainForm
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
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.hdrCallsToday = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btnSendNotifications = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.callsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCallRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCompanyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbCurrentUser = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurrentEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailNotificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMSNotificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvCallsToday = new System.Windows.Forms.ListView();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.txtConsole = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.panContent = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hdrCallsToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdrCallsToday.Panel)).BeginInit();
            this.hdrCallsToday.Panel.SuspendLayout();
            this.hdrCallsToday.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panContent)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 24);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.hdrCallsToday);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.panContent);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonHeaderGroup1);
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1254, 568);
            this.kryptonSplitContainer1.SplitterDistance = 217;
            this.kryptonSplitContainer1.TabIndex = 1;
            // 
            // hdrCallsToday
            // 
            this.hdrCallsToday.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btnSendNotifications});
            this.hdrCallsToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hdrCallsToday.Location = new System.Drawing.Point(0, 0);
            this.hdrCallsToday.Name = "hdrCallsToday";
            // 
            // hdrCallsToday.Panel
            // 
            this.hdrCallsToday.Panel.Controls.Add(this.lvCallsToday);
            this.hdrCallsToday.Size = new System.Drawing.Size(217, 568);
            this.hdrCallsToday.TabIndex = 0;
            this.hdrCallsToday.ValuesPrimary.Heading = "Calls Today";
            this.hdrCallsToday.ValuesPrimary.Image = null;
            this.hdrCallsToday.ValuesSecondary.Heading = "View all of the calls from today.";
            // 
            // btnSendNotifications
            // 
            this.btnSendNotifications.Image = global::CallLogTracker.Properties.Resources.notification_16x16;
            this.btnSendNotifications.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.btnSendNotifications.Text = "Notify";
            this.btnSendNotifications.UniqueName = "D232F314EB744CBDF6B1ACC8A8DDEB58";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callsToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.userToolStripMenuItem,
            this.notificationsToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // callsToolStripMenuItem
            // 
            this.callsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCallToolStripMenuItem,
            this.editCallToolStripMenuItem,
            this.deleteCallRecordsToolStripMenuItem});
            this.callsToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources.phone;
            this.callsToolStripMenuItem.Name = "callsToolStripMenuItem";
            this.callsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.callsToolStripMenuItem.Text = "Calls";
            // 
            // newCallToolStripMenuItem
            // 
            this.newCallToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources.add_16x16;
            this.newCallToolStripMenuItem.Name = "newCallToolStripMenuItem";
            this.newCallToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newCallToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.newCallToolStripMenuItem.Text = "New...";
            // 
            // editCallToolStripMenuItem
            // 
            this.editCallToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._218_edit;
            this.editCallToolStripMenuItem.Name = "editCallToolStripMenuItem";
            this.editCallToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.editCallToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.editCallToolStripMenuItem.Text = "Edit...";
            // 
            // deleteCallRecordsToolStripMenuItem
            // 
            this.deleteCallRecordsToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources.delete_16x16;
            this.deleteCallRecordsToolStripMenuItem.Name = "deleteCallRecordsToolStripMenuItem";
            this.deleteCallRecordsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.deleteCallRecordsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.deleteCallRecordsToolStripMenuItem.Text = "Delete Records...";
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCompanyInformationToolStripMenuItem});
            this.companyToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._346_home;
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.companyToolStripMenuItem.Text = "Companies";
            // 
            // editCompanyInformationToolStripMenuItem
            // 
            this.editCompanyInformationToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._218_edit;
            this.editCompanyInformationToolStripMenuItem.Name = "editCompanyInformationToolStripMenuItem";
            this.editCompanyInformationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.editCompanyInformationToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.editCompanyInformationToolStripMenuItem.Text = "Edit Company Information...";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbCurrentUser,
            this.toolStripSeparator1,
            this.newEmployeeToolStripMenuItem,
            this.editCurrentEmployeeToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem});
            this.userToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._051_man;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.userToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.userToolStripMenuItem.Text = "Employees";
            // 
            // cmbCurrentUser
            // 
            this.cmbCurrentUser.Name = "cmbCurrentUser";
            this.cmbCurrentUser.Size = new System.Drawing.Size(121, 23);
            this.cmbCurrentUser.Text = "Select Employee";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // newEmployeeToolStripMenuItem
            // 
            this.newEmployeeToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._041_man;
            this.newEmployeeToolStripMenuItem.Name = "newEmployeeToolStripMenuItem";
            this.newEmployeeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.newEmployeeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.newEmployeeToolStripMenuItem.Text = "New...";
            // 
            // editCurrentEmployeeToolStripMenuItem
            // 
            this.editCurrentEmployeeToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._043_man;
            this.editCurrentEmployeeToolStripMenuItem.Name = "editCurrentEmployeeToolStripMenuItem";
            this.editCurrentEmployeeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.editCurrentEmployeeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.editCurrentEmployeeToolStripMenuItem.Text = "Edit Current...";
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._045_man;
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.deleteEmployeeToolStripMenuItem.Text = "Delete...";
            // 
            // notificationsToolStripMenuItem
            // 
            this.notificationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailNotificationsToolStripMenuItem,
            this.sMSNotificationsToolStripMenuItem});
            this.notificationsToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._312_notification;
            this.notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            this.notificationsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.notificationsToolStripMenuItem.Text = "Notifications";
            // 
            // emailNotificationsToolStripMenuItem
            // 
            this.emailNotificationsToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources.mailbox;
            this.emailNotificationsToolStripMenuItem.Name = "emailNotificationsToolStripMenuItem";
            this.emailNotificationsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.emailNotificationsToolStripMenuItem.Text = "Email Notifications...";
            // 
            // sMSNotificationsToolStripMenuItem
            // 
            this.sMSNotificationsToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._299_smartphone;
            this.sMSNotificationsToolStripMenuItem.Name = "sMSNotificationsToolStripMenuItem";
            this.sMSNotificationsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sMSNotificationsToolStripMenuItem.Text = "SMS Notifications...";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newConnectionToolStripMenuItem,
            this.editConnectionToolStripMenuItem});
            this.databaseToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._117_database;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // newConnectionToolStripMenuItem
            // 
            this.newConnectionToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._035_database;
            this.newConnectionToolStripMenuItem.Name = "newConnectionToolStripMenuItem";
            this.newConnectionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newConnectionToolStripMenuItem.Text = "New Connection...";
            // 
            // editConnectionToolStripMenuItem
            // 
            this.editConnectionToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources.db_connection;
            this.editConnectionToolStripMenuItem.Name = "editConnectionToolStripMenuItem";
            this.editConnectionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.editConnectionToolStripMenuItem.Text = "Edit Connection...";
            // 
            // lvCallsToday
            // 
            this.lvCallsToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCallsToday.HideSelection = false;
            this.lvCallsToday.Location = new System.Drawing.Point(0, 0);
            this.lvCallsToday.MultiSelect = false;
            this.lvCallsToday.Name = "lvCallsToday";
            this.lvCallsToday.Size = new System.Drawing.Size(215, 515);
            this.lvCallsToday.TabIndex = 0;
            this.lvCallsToday.UseCompatibleStateImageBehavior = false;
            this.lvCallsToday.View = System.Windows.Forms.View.Details;
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 442);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.txtConsole);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(1032, 126);
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.TabIndex = 0;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Console";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = null;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "";
            // 
            // txtConsole
            // 
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Location = new System.Drawing.Point(0, 0);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(1030, 94);
            this.txtConsole.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "";
            // 
            // panContent
            // 
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(0, 0);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(1032, 442);
            this.panContent.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1254, 592);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "callLogger";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hdrCallsToday.Panel)).EndInit();
            this.hdrCallsToday.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hdrCallsToday)).EndInit();
            this.hdrCallsToday.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem callsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCallRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCompanyInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cmbCurrentUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem newEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCurrentEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailNotificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMSNotificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editConnectionToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup hdrCallsToday;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnSendNotifications;
        private System.Windows.Forms.ListView lvCallsToday;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtConsole;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panContent;
    }
}

