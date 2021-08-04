
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.callsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewCall = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditCurrentEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmailNotifications = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSMSNotifications = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewDBConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbUsers = new System.Windows.Forms.ToolStripComboBox();
            this.checkConnectionBGWorker = new System.ComponentModel.BackgroundWorker();
            this.dockingManager = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.dockableWorkspace = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.panContent = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.callBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockableWorkspace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panContent)).BeginInit();
            this.panContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callsToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.userToolStripMenuItem,
            this.notificationsToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.cmbUsers});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1584, 28);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // callsToolStripMenuItem
            // 
            this.callsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewCall});
            this.callsToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources.phone;
            this.callsToolStripMenuItem.Name = "callsToolStripMenuItem";
            this.callsToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.callsToolStripMenuItem.Text = "Calls";
            // 
            // btnNewCall
            // 
            this.btnNewCall.Image = global::CallLogTracker.Properties.Resources.add_16x16;
            this.btnNewCall.Name = "btnNewCall";
            this.btnNewCall.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNewCall.Size = new System.Drawing.Size(154, 26);
            this.btnNewCall.Text = "New...";
            this.btnNewCall.Click += new System.EventHandler(this.btnNewCall_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewCompany,
            this.btnEditCompany});
            this.companyToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._346_home;
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.companyToolStripMenuItem.Text = "Companies";
            // 
            // btnNewCompany
            // 
            this.btnNewCompany.Image = global::CallLogTracker.Properties.Resources.add_16x16;
            this.btnNewCompany.Name = "btnNewCompany";
            this.btnNewCompany.Size = new System.Drawing.Size(224, 26);
            this.btnNewCompany.Text = "New...";
            this.btnNewCompany.Click += new System.EventHandler(this.btnNewCompany_Click);
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.Image = global::CallLogTracker.Properties.Resources._218_edit;
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.btnEditCompany.Size = new System.Drawing.Size(224, 26);
            this.btnEditCompany.Text = "Edit Current...";
            this.btnEditCompany.Click += new System.EventHandler(this.btnEditCompany_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewEmployee,
            this.btnEditCurrentEmployee});
            this.userToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._051_man;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.userToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.userToolStripMenuItem.Text = "Employees";
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Image = global::CallLogTracker.Properties.Resources._041_man;
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.btnNewEmployee.Size = new System.Drawing.Size(192, 26);
            this.btnNewEmployee.Text = "New...";
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnEditCurrentEmployee
            // 
            this.btnEditCurrentEmployee.Image = global::CallLogTracker.Properties.Resources._043_man;
            this.btnEditCurrentEmployee.Name = "btnEditCurrentEmployee";
            this.btnEditCurrentEmployee.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.btnEditCurrentEmployee.Size = new System.Drawing.Size(192, 26);
            this.btnEditCurrentEmployee.Text = "Edit Current...";
            this.btnEditCurrentEmployee.Click += new System.EventHandler(this.btnEditCurrentEmployee_Click);
            // 
            // notificationsToolStripMenuItem
            // 
            this.notificationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEmailNotifications,
            this.btnSMSNotifications});
            this.notificationsToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._312_notification;
            this.notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            this.notificationsToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.notificationsToolStripMenuItem.Text = "Notifications";
            // 
            // btnEmailNotifications
            // 
            this.btnEmailNotifications.Image = global::CallLogTracker.Properties.Resources.mailbox;
            this.btnEmailNotifications.Name = "btnEmailNotifications";
            this.btnEmailNotifications.Size = new System.Drawing.Size(187, 26);
            this.btnEmailNotifications.Text = "Email Notifications...";
            // 
            // btnSMSNotifications
            // 
            this.btnSMSNotifications.Image = global::CallLogTracker.Properties.Resources._299_smartphone;
            this.btnSMSNotifications.Name = "btnSMSNotifications";
            this.btnSMSNotifications.Size = new System.Drawing.Size(187, 26);
            this.btnSMSNotifications.Text = "SMS Notifications...";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewDBConnection});
            this.databaseToolStripMenuItem.Image = global::CallLogTracker.Properties.Resources._117_database;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // btnNewDBConnection
            // 
            this.btnNewDBConnection.Image = global::CallLogTracker.Properties.Resources.db_connection;
            this.btnNewDBConnection.Name = "btnNewDBConnection";
            this.btnNewDBConnection.Size = new System.Drawing.Size(172, 26);
            this.btnNewDBConnection.Text = "Edit Connection...";
            this.btnNewDBConnection.Click += new System.EventHandler(this.btnNewDBConnection_Click);
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(121, 24);
            this.cmbUsers.ToolTipText = "Select a user to switch to their account.";
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // checkConnectionBGWorker
            // 
            this.checkConnectionBGWorker.WorkerReportsProgress = true;
            this.checkConnectionBGWorker.WorkerSupportsCancellation = true;
            this.checkConnectionBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkConnectionBGWorker_DoWork);
            this.checkConnectionBGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.checkConnectionBGWorker_ProgressChanged);
            this.checkConnectionBGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.checkConnectionBGWorker_RunWorkerCompleted);
            // 
            // dockableWorkspace
            // 
            this.dockableWorkspace.AutoHiddenHost = false;
            this.dockableWorkspace.CompactFlags = ((ComponentFactory.Krypton.Workspace.CompactFlags)(((ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptyCells | ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | ComponentFactory.Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.dockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockableWorkspace.Location = new System.Drawing.Point(0, 0);
            this.dockableWorkspace.Name = "dockableWorkspace";
            // 
            // 
            // 
            this.dockableWorkspace.Root.UniqueName = "F9D3478C0F5B4730B0B77B1B0E4D103A";
            this.dockableWorkspace.Root.WorkspaceControl = this.dockableWorkspace;
            this.dockableWorkspace.ShowMaximizeButton = false;
            this.dockableWorkspace.Size = new System.Drawing.Size(1584, 733);
            this.dockableWorkspace.TabIndex = 3;
            this.dockableWorkspace.TabStop = true;
            // 
            // panContent
            // 
            this.panContent.Controls.Add(this.dockableWorkspace);
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(0, 28);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(1584, 733);
            this.panContent.TabIndex = 4;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(CallLogTracker.backend.database.wrappers.User);
            // 
            // callBindingSource
            // 
            this.callBindingSource.DataSource = typeof(CallLogTracker.backend.database.wrappers.Call);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1584, 761);
            this.Controls.Add(this.panContent);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call Log Tracker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockableWorkspace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panContent)).EndInit();
            this.panContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem callsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNewCall;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEditCompany;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNewEmployee;
        private System.Windows.Forms.ToolStripMenuItem btnEditCurrentEmployee;
        private System.Windows.Forms.ToolStripMenuItem notificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEmailNotifications;
        private System.Windows.Forms.ToolStripMenuItem btnSMSNotifications;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNewDBConnection;
        private System.Windows.Forms.ToolStripMenuItem btnNewCompany;
        private System.Windows.Forms.BindingSource userBindingSource;
        public System.ComponentModel.BackgroundWorker checkConnectionBGWorker;
        private System.Windows.Forms.BindingSource callBindingSource;
        private System.Windows.Forms.ToolStripComboBox cmbUsers;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager dockingManager;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace dockableWorkspace;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panContent;
    }
}

