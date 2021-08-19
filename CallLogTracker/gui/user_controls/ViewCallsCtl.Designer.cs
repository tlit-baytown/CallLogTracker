
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
            this.hdrGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.chkOnlyCallsToday = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.chkOnlyCurrentUserCalls = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btnNotify = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.dgCalls = new JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.KryptonOutlookGrid();
            this.groupBox = new JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.KryptonOutlookGridGroupBox();
            this.getCallsBGWorker = new System.ComponentModel.BackgroundWorker();
            this.chkOnlyUnresolved = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btnDeleteCall = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btnNotifyAllUnresolved = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.deleteBGWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.hdrGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdrGroup.Panel)).BeginInit();
            this.hdrGroup.Panel.SuspendLayout();
            this.hdrGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCalls)).BeginInit();
            this.SuspendLayout();
            // 
            // hdrGroup
            // 
            this.hdrGroup.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.chkOnlyCallsToday,
            this.chkOnlyCurrentUserCalls,
            this.chkOnlyUnresolved,
            this.btnNotify,
            this.btnNotifyAllUnresolved,
            this.btnEdit,
            this.btnDeleteCall,
            this.btnRefresh});
            this.hdrGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hdrGroup.Location = new System.Drawing.Point(0, 0);
            this.hdrGroup.Name = "hdrGroup";
            // 
            // hdrGroup.Panel
            // 
            this.hdrGroup.Panel.Controls.Add(this.dgCalls);
            this.hdrGroup.Panel.Controls.Add(this.groupBox);
            this.hdrGroup.Size = new System.Drawing.Size(1113, 443);
            this.hdrGroup.TabIndex = 0;
            this.hdrGroup.ValuesPrimary.Heading = "";
            this.hdrGroup.ValuesPrimary.Image = null;
            this.hdrGroup.ValuesSecondary.Heading = "Total Calls: 0";
            // 
            // chkOnlyCallsToday
            // 
            this.chkOnlyCallsToday.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked;
            this.chkOnlyCallsToday.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader;
            this.chkOnlyCallsToday.Text = "Show Only Calls from Today";
            this.chkOnlyCallsToday.ToolTipBody = "Show only those calls that are from today.";
            this.chkOnlyCallsToday.ToolTipTitle = "Quick Filter";
            this.chkOnlyCallsToday.UniqueName = "CE7C2F9E30E146FF59AA0DFA225F48B0";
            this.chkOnlyCallsToday.Click += new System.EventHandler(this.chkOnlyCallsToday_Click);
            // 
            // chkOnlyCurrentUserCalls
            // 
            this.chkOnlyCurrentUserCalls.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked;
            this.chkOnlyCurrentUserCalls.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader;
            this.chkOnlyCurrentUserCalls.Text = "Show Only Your Calls";
            this.chkOnlyCurrentUserCalls.UniqueName = "36F699B1ACC5488C2DA2CC95C7F189B8";
            this.chkOnlyCurrentUserCalls.Click += new System.EventHandler(this.chkOnlyCurrentUserCalls_Click);
            // 
            // btnNotify
            // 
            this.btnNotify.Image = global::CallLogTracker.Properties.Resources.notification_16x16;
            this.btnNotify.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.btnNotify.Text = "Notify";
            this.btnNotify.UniqueName = "02F4C5D7D27E44EEFC8DC905C3AAB7F6";
            this.btnNotify.Click += new System.EventHandler(this.btnNotify_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::CallLogTracker.Properties.Resources.edit_16x16;
            this.btnEdit.Text = "Edit Selected Call...";
            this.btnEdit.ToolTipBody = "Edit the selected row in a pop-up editor.";
            this.btnEdit.ToolTipTitle = "Edit";
            this.btnEdit.UniqueName = "3268AC0DC2FA46F4288D7174626EC889";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::CallLogTracker.Properties.Resources.reload_16x16;
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
            this.dgCalls.AllowUserToResizeRows = false;
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
            this.dgCalls.Size = new System.Drawing.Size(1111, 353);
            this.dgCalls.TabIndex = 1;
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
            // chkOnlyUnresolved
            // 
            this.chkOnlyUnresolved.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Checked;
            this.chkOnlyUnresolved.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader;
            this.chkOnlyUnresolved.Text = "Show Only Un-Resolved Calls";
            this.chkOnlyUnresolved.UniqueName = "3C55906A99F04276BAA6C3D40D502510";
            this.chkOnlyUnresolved.Click += new System.EventHandler(this.chkOnlyUnresolved_Click);
            // 
            // btnDeleteCall
            // 
            this.btnDeleteCall.Image = global::CallLogTracker.Properties.Resources.delete_16x16;
            this.btnDeleteCall.Text = "Delete Selected Call";
            this.btnDeleteCall.UniqueName = "0CDB89DF2CFF4A9DCD9644050492EAC7";
            this.btnDeleteCall.Click += new System.EventHandler(this.btnDeleteCall_Click);
            // 
            // btnNotifyAllUnresolved
            // 
            this.btnNotifyAllUnresolved.Image = global::CallLogTracker.Properties.Resources.notification_16x16;
            this.btnNotifyAllUnresolved.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.btnNotifyAllUnresolved.Text = "Notify About Unresolved";
            this.btnNotifyAllUnresolved.UniqueName = "0E64527BE35C46C5DEA2302D73AFF12D";
            this.btnNotifyAllUnresolved.Click += new System.EventHandler(this.btnNotifyAllUnresolved_Click);
            // 
            // deleteBGWorker
            // 
            this.deleteBGWorker.WorkerReportsProgress = true;
            this.deleteBGWorker.WorkerSupportsCancellation = true;
            this.deleteBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.deleteBGWorker_DoWork);
            this.deleteBGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.deleteBGWorker_ProgressChanged);
            this.deleteBGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.deleteBGWorker_RunWorkerCompleted);
            // 
            // ViewCallsCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hdrGroup);
            this.Name = "ViewCallsCtl";
            this.Size = new System.Drawing.Size(1113, 443);
            this.Load += new System.EventHandler(this.ViewCallsCtl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hdrGroup.Panel)).EndInit();
            this.hdrGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hdrGroup)).EndInit();
            this.hdrGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup hdrGroup;
        private JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.KryptonOutlookGrid dgCalls;
        private JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid.KryptonOutlookGridGroupBox groupBox;
        private System.ComponentModel.BackgroundWorker getCallsBGWorker;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup chkOnlyCallsToday;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnEdit;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnRefresh;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnNotify;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup chkOnlyCurrentUserCalls;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup chkOnlyUnresolved;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnNotifyAllUnresolved;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnDeleteCall;
        private System.ComponentModel.BackgroundWorker deleteBGWorker;
    }
}
