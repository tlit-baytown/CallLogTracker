
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
            this.lvCallsToday = new System.Windows.Forms.ListView();
            this.panContent = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.txtConsole = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbCompanies = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbUsers = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.callsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewCall = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditCall = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteCall = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditCurrentEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmailNotifications = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSMSNotifications = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewDBConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.checkConnectionBGWorker = new System.ComponentModel.BackgroundWorker();
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
            ((System.ComponentModel.ISupportInitialize)(this.panContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
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
            // panContent
            // 
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(0, 27);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(1032, 415);
            this.panContent.TabIndex = 1;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.cmbCompanies);
            this.flowLayoutPanel1.Controls.Add(this.cmbUsers);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1032, 27);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cmbCompanies
            // 
            this.cmbCompanies.DropDownWidth = 153;
            this.cmbCompanies.Location = new System.Drawing.Point(833, 3);
            this.cmbCompanies.Name = "cmbCompanies";
            this.cmbCompanies.Size = new System.Drawing.Size(196, 21);
            this.cmbCompanies.TabIndex = 1;
            this.cmbCompanies.Text = "Select Company";
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownWidth = 153;
            this.cmbUsers.Location = new System.Drawing.Point(674, 3);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(153, 21);
            this.cmbUsers.TabIndex = 0;
            this.cmbUsers.Text = "Select Employee";
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
            this.btnNewCall,
            this.btnEditCall,
            this.btnDeleteCall});
            this.callsToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources.phone;
            this.callsToolStripMenuItem.Name = "callsToolStripMenuItem";
            this.callsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.callsToolStripMenuItem.Text = "Calls";
            // 
            // btnNewCall
            // 
            this.btnNewCall.Image = global::CallLogTracker.Properties.Resources.add_16x16;
            this.btnNewCall.Name = "btnNewCall";
            this.btnNewCall.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNewCall.Size = new System.Drawing.Size(212, 22);
            this.btnNewCall.Text = "New...";
            // 
            // btnEditCall
            // 
            this.btnEditCall.Image = global::CallLogTracker.Properties.Resources._218_edit;
            this.btnEditCall.Name = "btnEditCall";
            this.btnEditCall.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.btnEditCall.Size = new System.Drawing.Size(212, 22);
            this.btnEditCall.Text = "Edit...";
            // 
            // btnDeleteCall
            // 
            this.btnDeleteCall.Image = global::CallLogTracker.Properties.Resources.delete_16x16;
            this.btnDeleteCall.Name = "btnDeleteCall";
            this.btnDeleteCall.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.btnDeleteCall.Size = new System.Drawing.Size(212, 22);
            this.btnDeleteCall.Text = "Delete Records...";
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditCompany});
            this.companyToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._346_home;
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.companyToolStripMenuItem.Text = "Companies";
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.Image = global::CallLogTracker.Properties.Resources._218_edit;
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.btnEditCompany.Size = new System.Drawing.Size(298, 22);
            this.btnEditCompany.Text = "Edit Company Information...";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewEmployee,
            this.btnEditCurrentEmployee,
            this.btnDeleteEmployee});
            this.userToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._051_man;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.userToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.userToolStripMenuItem.Text = "Employees";
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Image = global::CallLogTracker.Properties.Resources._041_man;
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.btnNewEmployee.Size = new System.Drawing.Size(188, 22);
            this.btnNewEmployee.Text = "New...";
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnEditCurrentEmployee
            // 
            this.btnEditCurrentEmployee.Image = global::CallLogTracker.Properties.Resources._043_man;
            this.btnEditCurrentEmployee.Name = "btnEditCurrentEmployee";
            this.btnEditCurrentEmployee.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.btnEditCurrentEmployee.Size = new System.Drawing.Size(188, 22);
            this.btnEditCurrentEmployee.Text = "Edit Current...";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Image = global::CallLogTracker.Properties.Resources._045_man;
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(188, 22);
            this.btnDeleteEmployee.Text = "Delete...";
            // 
            // notificationsToolStripMenuItem
            // 
            this.notificationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEmailNotifications,
            this.btnSMSNotifications});
            this.notificationsToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._312_notification;
            this.notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            this.notificationsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.notificationsToolStripMenuItem.Text = "Notifications";
            // 
            // btnEmailNotifications
            // 
            this.btnEmailNotifications.Image = global::CallLogTracker.Properties.Resources.mailbox;
            this.btnEmailNotifications.Name = "btnEmailNotifications";
            this.btnEmailNotifications.Size = new System.Drawing.Size(183, 22);
            this.btnEmailNotifications.Text = "Email Notifications...";
            // 
            // btnSMSNotifications
            // 
            this.btnSMSNotifications.Image = global::CallLogTracker.Properties.Resources._299_smartphone;
            this.btnSMSNotifications.Name = "btnSMSNotifications";
            this.btnSMSNotifications.Size = new System.Drawing.Size(183, 22);
            this.btnSMSNotifications.Text = "SMS Notifications...";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewDBConnection});
            this.databaseToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._117_database;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // btnNewDBConnection
            // 
            this.btnNewDBConnection.Image = global::CallLogTracker.Properties.Resources.db_connection;
            this.btnNewDBConnection.Name = "btnNewDBConnection";
            this.btnNewDBConnection.Size = new System.Drawing.Size(168, 22);
            this.btnNewDBConnection.Text = "Edit Connection...";
            this.btnNewDBConnection.Click += new System.EventHandler(this.btnNewDBConnection_Click);
            // 
            // checkConnectionBGWorker
            // 
            this.checkConnectionBGWorker.WorkerReportsProgress = true;
            this.checkConnectionBGWorker.WorkerSupportsCancellation = true;
            this.checkConnectionBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkConnectionBGWorker_DoWork);
            this.checkConnectionBGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.checkConnectionBGWorker_ProgressChanged);
            this.checkConnectionBGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.checkConnectionBGWorker_RunWorkerCompleted);
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
            this.Shown += new System.EventHandler(this.MainForm_Shown);
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
            ((System.ComponentModel.ISupportInitialize)(this.panContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem callsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNewCall;
        private System.Windows.Forms.ToolStripMenuItem btnEditCall;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteCall;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEditCompany;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNewEmployee;
        private System.Windows.Forms.ToolStripMenuItem btnEditCurrentEmployee;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteEmployee;
        private System.Windows.Forms.ToolStripMenuItem notificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEmailNotifications;
        private System.Windows.Forms.ToolStripMenuItem btnSMSNotifications;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNewDBConnection;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup hdrCallsToday;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnSendNotifications;
        private System.Windows.Forms.ListView lvCallsToday;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtConsole;
        private System.ComponentModel.BackgroundWorker checkConnectionBGWorker;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbUsers;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCompanies;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel panContent;
    }
}

