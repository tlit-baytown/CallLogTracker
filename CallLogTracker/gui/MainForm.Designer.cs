
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
            JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.OutlookGridGroupCollection outlookGridGroupCollection1 = new JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.OutlookGridGroupCollection();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.hdrCallsToday = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btnSendNotifications = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.dgCallsToday = new JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.KryptonOutlookGrid();
            this.urgentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callerPhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callerMessageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panContent = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.txtConsole = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbUsers = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSelectUser = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.callsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewCall = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditCall = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteCall = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewCompany = new System.Windows.Forms.ToolStripMenuItem();
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
            this.getCallsBGWorker = new System.ComponentModel.BackgroundWorker();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgCallsToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 28);
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
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1254, 564);
            this.kryptonSplitContainer1.SplitterDistance = 247;
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
            this.hdrCallsToday.Panel.Controls.Add(this.dgCallsToday);
            this.hdrCallsToday.Size = new System.Drawing.Size(247, 564);
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
            // dgCallsToday
            // 
            this.dgCallsToday.AllowUserToAddRows = false;
            this.dgCallsToday.AllowUserToDeleteRows = false;
            this.dgCallsToday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCallsToday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urgentColumn,
            this.callerNameColumn,
            this.callerPhoneColumn,
            this.callerMessageColumn});
            this.dgCallsToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCallsToday.FillMode = JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.FillMode.GROUPSONLY;
            this.dgCallsToday.GroupCollection = outlookGridGroupCollection1;
            this.dgCallsToday.Location = new System.Drawing.Point(0, 0);
            this.dgCallsToday.Name = "dgCallsToday";
            this.dgCallsToday.PreviousSelectedGroupRow = -1;
            this.dgCallsToday.ReadOnly = true;
            this.dgCallsToday.Size = new System.Drawing.Size(245, 511);
            this.dgCallsToday.TabIndex = 0;
            // 
            // urgentColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urgentColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.urgentColumn.HeaderText = "Urgent";
            this.urgentColumn.Name = "urgentColumn";
            this.urgentColumn.ReadOnly = true;
            // 
            // callerNameColumn
            // 
            this.callerNameColumn.HeaderText = "Name";
            this.callerNameColumn.Name = "callerNameColumn";
            this.callerNameColumn.ReadOnly = true;
            // 
            // callerPhoneColumn
            // 
            this.callerPhoneColumn.HeaderText = "Phone";
            this.callerPhoneColumn.Name = "callerPhoneColumn";
            this.callerPhoneColumn.ReadOnly = true;
            // 
            // callerMessageColumn
            // 
            this.callerMessageColumn.HeaderText = "Msg";
            this.callerMessageColumn.Name = "callerMessageColumn";
            this.callerMessageColumn.ReadOnly = true;
            // 
            // panContent
            // 
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(0, 27);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(1002, 411);
            this.panContent.TabIndex = 1;
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 438);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.txtConsole);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(1002, 126);
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
            this.txtConsole.Size = new System.Drawing.Size(1000, 94);
            this.txtConsole.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.cmbUsers);
            this.flowLayoutPanel1.Controls.Add(this.lblSelectUser);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1002, 27);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cmbUsers
            // 
            this.cmbUsers.DataSource = this.userBindingSource;
            this.cmbUsers.DisplayMember = "Name";
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.DropDownWidth = 153;
            this.cmbUsers.Location = new System.Drawing.Point(846, 3);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(153, 21);
            this.cmbUsers.TabIndex = 0;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(CallLogTracker.backend.database.wrappers.User);
            // 
            // lblSelectUser
            // 
            this.lblSelectUser.Location = new System.Drawing.Point(802, 3);
            this.lblSelectUser.Name = "lblSelectUser";
            this.lblSelectUser.Size = new System.Drawing.Size(38, 20);
            this.lblSelectUser.TabIndex = 2;
            this.lblSelectUser.Values.Text = "User: ";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CallerName";
            this.dataGridViewTextBoxColumn8.HeaderText = "CallerName";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 102;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CallerPhone";
            this.dataGridViewTextBoxColumn9.HeaderText = "CallerPhone";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 153;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CallerEmail";
            this.dataGridViewTextBoxColumn10.HeaderText = "CallerEmail";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 306;
            // 
            // callBindingSource
            // 
            this.callBindingSource.DataSource = typeof(CallLogTracker.backend.database.wrappers.Call);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CallerName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 102;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CallerPhone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 153;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Message";
            this.dataGridViewTextBoxColumn7.HeaderText = "Msg";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 306;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CallerName";
            this.dataGridViewTextBoxColumn1.HeaderText = "CallerName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 77;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CallerPhone";
            this.dataGridViewTextBoxColumn2.HeaderText = "CallerPhone";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 102;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CallerEmail";
            this.dataGridViewTextBoxColumn3.HeaderText = "CallerEmail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 153;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Message";
            this.dataGridViewTextBoxColumn4.HeaderText = "Message";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 306;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(CallLogTracker.backend.database.wrappers.Company);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callsToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.userToolStripMenuItem,
            this.notificationsToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1254, 28);
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
            this.callsToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.callsToolStripMenuItem.Text = "Calls";
            // 
            // btnNewCall
            // 
            this.btnNewCall.Image = global::CallLogTracker.Properties.Resources.add_16x16;
            this.btnNewCall.Name = "btnNewCall";
            this.btnNewCall.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNewCall.Size = new System.Drawing.Size(216, 26);
            this.btnNewCall.Text = "New...";
            this.btnNewCall.Click += new System.EventHandler(this.btnNewCall_Click);
            // 
            // btnEditCall
            // 
            this.btnEditCall.Image = global::CallLogTracker.Properties.Resources._218_edit;
            this.btnEditCall.Name = "btnEditCall";
            this.btnEditCall.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.btnEditCall.Size = new System.Drawing.Size(216, 26);
            this.btnEditCall.Text = "Edit...";
            // 
            // btnDeleteCall
            // 
            this.btnDeleteCall.Image = global::CallLogTracker.Properties.Resources.delete_16x16;
            this.btnDeleteCall.Name = "btnDeleteCall";
            this.btnDeleteCall.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.btnDeleteCall.Size = new System.Drawing.Size(216, 26);
            this.btnDeleteCall.Text = "Delete Records...";
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
            this.btnEditCurrentEmployee,
            this.btnDeleteEmployee});
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
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Image = global::CallLogTracker.Properties.Resources._045_man;
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(192, 26);
            this.btnDeleteEmployee.Text = "Delete...";
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
            // checkConnectionBGWorker
            // 
            this.checkConnectionBGWorker.WorkerReportsProgress = true;
            this.checkConnectionBGWorker.WorkerSupportsCancellation = true;
            this.checkConnectionBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkConnectionBGWorker_DoWork);
            this.checkConnectionBGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.checkConnectionBGWorker_ProgressChanged);
            this.checkConnectionBGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.checkConnectionBGWorker_RunWorkerCompleted);
            // 
            // getCallsBGWorker
            // 
            this.getCallsBGWorker.WorkerReportsProgress = true;
            this.getCallsBGWorker.WorkerSupportsCancellation = true;
            this.getCallsBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.getCallsBGWorker_DoWork);
            this.getCallsBGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.getCallsBGWorker_ProgressChanged);
            this.getCallsBGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.getCallsBGWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1254, 592);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call Log Tracker";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgCallsToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
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
        private JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.KryptonOutlookGrid dgCallsToday;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtConsole;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbUsers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel panContent;
        private System.Windows.Forms.ToolStripMenuItem btnNewCompany;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSelectUser;
        public System.ComponentModel.BackgroundWorker checkConnectionBGWorker;
        private System.Windows.Forms.BindingSource callBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.ComponentModel.BackgroundWorker getCallsBGWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn urgentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn callerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn callerPhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn callerMessageColumn;
    }
}

