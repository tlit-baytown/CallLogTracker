
namespace CallLogTracker.gui.user_controls
{
    partial class ViewCallsCtl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.OutlookGridGroupCollection outlookGridGroupCollection1 = new JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.OutlookGridGroupCollection();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.chkOnlyCallsToday = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.dgCalls = new JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.KryptonOutlookGrid();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgentColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.nameColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.phoneColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.messageColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.groupBox = new JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.KryptonOutlookGridGroupBox();
            this.getCallsBGWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCalls)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.chkOnlyCallsToday,
            this.btnEdit,
            this.btnRefresh});
            this.kryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.dgCalls);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.groupBox);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(1113, 443);
            this.kryptonHeaderGroup1.TabIndex = 0;
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "Calls";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = null;
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "This grid displays all phone calls in the system for the current user.";
            // 
            // chkOnlyCallsToday
            // 
            this.chkOnlyCallsToday.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked;
            this.chkOnlyCallsToday.Text = "Show Only Calls from Today";
            this.chkOnlyCallsToday.ToolTipBody = "Show only those calls that are from today.";
            this.chkOnlyCallsToday.ToolTipTitle = "Quick Filter";
            this.chkOnlyCallsToday.UniqueName = "CE7C2F9E30E146FF59AA0DFA225F48B0";
            this.chkOnlyCallsToday.Click += new System.EventHandler(this.chkOnlyCallsToday_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader;
            this.btnEdit.Image = global::CallLogTracker.Properties.Resources.edit_16x16;
            this.btnEdit.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Alternate;
            this.btnEdit.Text = "Edit Selected Call...";
            this.btnEdit.ToolTipBody = "Edit the selected row in a pop-up editor.";
            this.btnEdit.ToolTipTitle = "Edit";
            this.btnEdit.UniqueName = "3268AC0DC2FA46F4288D7174626EC889";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::CallLogTracker.Properties.Resources.reload_16x16;
            this.btnRefresh.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Alternate;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ToolTipBody = "Reload the data from the database.";
            this.btnRefresh.ToolTipTitle = "Refresh";
            this.btnRefresh.UniqueName = "9D2E1379314E4F2E709C491B008A90F0";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgCalls
            // 
            this.dgCalls.AllowDrop = true;
            this.dgCalls.AllowUserToAddRows = false;
            this.dgCalls.AllowUserToDeleteRows = false;
            this.dgCalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateColumn,
            this.urgentColumn,
            this.nameColumn,
            this.phoneColumn,
            this.messageColumn});
            this.dgCalls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCalls.FillMode = JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.FillMode.GROUPSANDNODES;
            this.dgCalls.GroupBox = this.groupBox;
            this.dgCalls.GroupCollection = outlookGridGroupCollection1;
            this.dgCalls.Location = new System.Drawing.Point(0, 32);
            this.dgCalls.Name = "dgCalls";
            this.dgCalls.PreviousSelectedGroupRow = -1;
            this.dgCalls.ReadOnly = true;
            this.dgCalls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCalls.ShowEditingIcon = false;
            this.dgCalls.Size = new System.Drawing.Size(1111, 350);
            this.dgCalls.TabIndex = 1;
            // 
            // dateColumn
            // 
            this.dateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateColumn.HeaderText = "Date Taken";
            this.dateColumn.MaxInputLength = 20;
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.ToolTipText = "The date this call was recorded to the database.";
            // 
            // urgentColumn
            // 
            this.urgentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.urgentColumn.HeaderText = "Is Urgent?";
            this.urgentColumn.MaxInputLength = 1;
            this.urgentColumn.Name = "urgentColumn";
            this.urgentColumn.ReadOnly = true;
            this.urgentColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.urgentColumn.ToolTipText = "Indicates if the call was urgent (high priority) or not.";
            this.urgentColumn.Width = 88;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.ToolTipText = "The name of the person who called.";
            this.nameColumn.Width = 150;
            // 
            // phoneColumn
            // 
            this.phoneColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.phoneColumn.HeaderText = "Phone #";
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            this.phoneColumn.ToolTipText = "The call-back phone number for the customer.";
            this.phoneColumn.Width = 100;
            // 
            // messageColumn
            // 
            this.messageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.messageColumn.HeaderText = "Message";
            this.messageColumn.Name = "messageColumn";
            this.messageColumn.ReadOnly = true;
            this.messageColumn.ToolTipText = "The message pertaining to the phone call.";
            this.messageColumn.Width = 632;
            // 
            // groupBox
            // 
            this.groupBox.AllowDrop = true;
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1111, 32);
            this.groupBox.TabIndex = 0;
            // 
            // getCallsBGWorker
            // 
            this.getCallsBGWorker.WorkerReportsProgress = true;
            this.getCallsBGWorker.WorkerSupportsCancellation = true;
            this.getCallsBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.getCallsBGWorker_DoWork);
            this.getCallsBGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.getCallsBGWorker_ProgressChanged);
            this.getCallsBGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.getCallsBGWorker_RunWorkerCompleted);
            // 
            // ViewCallsCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Name = "ViewCallsCtl";
            this.Size = new System.Drawing.Size(1113, 443);
            this.Load += new System.EventHandler(this.ViewCallsCtl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.KryptonOutlookGrid dgCalls;
        private JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.KryptonOutlookGridGroupBox groupBox;
        private System.ComponentModel.BackgroundWorker getCallsBGWorker;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup chkOnlyCallsToday;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnEdit;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn urgentColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn nameColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn phoneColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn messageColumn;
    }
}
