
namespace CallLogTracker.gui.user_controls
{
    partial class NewCall
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
            this.hdrGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btnSaveAndNotify = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rtbMessage = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCharCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLastUpdated = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCallerEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblCallerEmail = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCallerName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtCallerName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblPhoneNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtPhoneNumber = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.chkIsUrgent = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.hdrGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdrGroup.Panel)).BeginInit();
            this.hdrGroup.Panel.SuspendLayout();
            this.hdrGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrGroup
            // 
            this.hdrGroup.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btnSaveAndNotify,
            this.btnSave});
            this.hdrGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hdrGroup.Location = new System.Drawing.Point(0, 0);
            this.hdrGroup.Name = "hdrGroup";
            // 
            // hdrGroup.Panel
            // 
            this.hdrGroup.Panel.AutoScroll = true;
            this.hdrGroup.Panel.Controls.Add(this.kryptonGroupBox1);
            this.hdrGroup.Panel.Controls.Add(this.tableLayoutPanel1);
            this.hdrGroup.Size = new System.Drawing.Size(1018, 609);
            this.hdrGroup.TabIndex = 0;
            this.hdrGroup.ValuesPrimary.Description = "Create a new call record. Fields marked * are required.";
            this.hdrGroup.ValuesPrimary.Heading = "New Call Record";
            this.hdrGroup.ValuesPrimary.Image = null;
            this.hdrGroup.ValuesSecondary.Heading = "Hover over a label for more information.";
            // 
            // btnSaveAndNotify
            // 
            this.btnSaveAndNotify.Image = global::CallLogTracker.Properties.Resources.notification_16x16;
            this.btnSaveAndNotify.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.btnSaveAndNotify.Text = "Save and Notify";
            this.btnSaveAndNotify.UniqueName = "6224666C23F84F07CCAA865B3D1EA9E8";
            this.btnSaveAndNotify.Click += new System.EventHandler(this.btnSaveAndNotify_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::CallLogTracker.Properties.Resources.save_16x16;
            this.btnSave.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.btnSave.Text = "Save";
            this.btnSave.UniqueName = "CF0CA85D36204CF706A7F9D97100EE38";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionOverlap = 1D;
            this.kryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 116);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.rtbMessage);
            this.kryptonGroupBox1.Panel.Controls.Add(this.statusStrip1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(1016, 440);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Red;
            this.kryptonGroupBox1.TabIndex = 2;
            this.kryptonGroupBox1.Values.Description = "*";
            this.kryptonGroupBox1.Values.Heading = "Message";
            this.kryptonGroupBox1.MouseEnter += new System.EventHandler(this.kryptonGroupBox1_MouseEnter);
            this.kryptonGroupBox1.MouseLeave += new System.EventHandler(this.ResetHelpText);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMessage.Location = new System.Drawing.Point(0, 0);
            this.rtbMessage.MaxLength = 65535;
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(1012, 387);
            this.rtbMessage.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.rtbMessage.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rtbMessage.TabIndex = 1;
            this.rtbMessage.Text = "";
            this.rtbMessage.TextChanged += new System.EventHandler(this.rtbMessage_TextChanged);
            this.rtbMessage.Enter += new System.EventHandler(this.rtbMessage_Enter);
            this.rtbMessage.Leave += new System.EventHandler(this.rtbMessage_Leave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCharCount,
            this.toolStripStatusLabel1,
            this.lblLastUpdated});
            this.statusStrip1.Location = new System.Drawing.Point(0, 387);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1012, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCharCount
            // 
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(127, 17);
            this.lblCharCount.Text = "Char. Count: 0 / 65,535";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(870, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(104, 17);
            this.lblLastUpdated.Text = "Last Updated: N/A";
            this.lblLastUpdated.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.78752F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.21249F));
            this.tableLayoutPanel1.Controls.Add(this.txtCallerEmail, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCallerEmail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCallerName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCallerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPhoneNumber, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPhoneNumber, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkIsUrgent, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 116);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtCallerEmail
            // 
            this.txtCallerEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCallerEmail.Location = new System.Drawing.Point(204, 32);
            this.txtCallerEmail.MaxLength = 255;
            this.txtCallerEmail.Name = "txtCallerEmail";
            this.txtCallerEmail.Size = new System.Drawing.Size(809, 23);
            this.txtCallerEmail.TabIndex = 1;
            this.txtCallerEmail.TextChanged += new System.EventHandler(this.txtCallerEmail_TextChanged);
            this.txtCallerEmail.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtCallerEmail.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // lblCallerEmail
            // 
            this.lblCallerEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCallerEmail.Location = new System.Drawing.Point(3, 33);
            this.lblCallerEmail.Name = "lblCallerEmail";
            this.lblCallerEmail.Size = new System.Drawing.Size(195, 20);
            this.lblCallerEmail.TabIndex = 2;
            this.lblCallerEmail.TabStop = false;
            this.lblCallerEmail.Values.Text = "Caller Email: ";
            this.lblCallerEmail.MouseEnter += new System.EventHandler(this.lblCallerEmail_MouseEnter);
            this.lblCallerEmail.MouseLeave += new System.EventHandler(this.ResetHelpText);
            // 
            // lblCallerName
            // 
            this.lblCallerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCallerName.Location = new System.Drawing.Point(3, 4);
            this.lblCallerName.Name = "lblCallerName";
            this.lblCallerName.Size = new System.Drawing.Size(195, 20);
            this.lblCallerName.StateCommon.LongText.Color1 = System.Drawing.Color.Red;
            this.lblCallerName.TabIndex = 0;
            this.lblCallerName.TabStop = false;
            this.lblCallerName.Values.ExtraText = "*";
            this.lblCallerName.Values.Text = "Caller Name: ";
            this.lblCallerName.MouseEnter += new System.EventHandler(this.lblCallerName_MouseEnter);
            this.lblCallerName.MouseLeave += new System.EventHandler(this.ResetHelpText);
            // 
            // txtCallerName
            // 
            this.txtCallerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCallerName.Location = new System.Drawing.Point(204, 3);
            this.txtCallerName.MaxLength = 255;
            this.txtCallerName.Name = "txtCallerName";
            this.txtCallerName.Size = new System.Drawing.Size(809, 23);
            this.txtCallerName.TabIndex = 0;
            this.txtCallerName.TextChanged += new System.EventHandler(this.txtCallerName_TextChanged);
            this.txtCallerName.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtCallerName.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 62);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(195, 20);
            this.lblPhoneNumber.StateCommon.LongText.Color1 = System.Drawing.Color.Red;
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.TabStop = false;
            this.lblPhoneNumber.Values.ExtraText = "*";
            this.lblPhoneNumber.Values.Text = "Callback Number:";
            this.lblPhoneNumber.MouseEnter += new System.EventHandler(this.lblPhoneNumber_MouseEnter);
            this.lblPhoneNumber.MouseLeave += new System.EventHandler(this.ResetHelpText);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(204, 61);
            this.txtPhoneNumber.Mask = "###-###-####";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(809, 23);
            this.txtPhoneNumber.TabIndex = 2;
            this.txtPhoneNumber.Text = "   -   -";
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.Enter += new System.EventHandler(this.txtPhoneNumber_Enter);
            this.txtPhoneNumber.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // chkIsUrgent
            // 
            this.chkIsUrgent.Location = new System.Drawing.Point(204, 90);
            this.chkIsUrgent.Name = "chkIsUrgent";
            this.chkIsUrgent.Size = new System.Drawing.Size(149, 20);
            this.chkIsUrgent.StateCommon.LongText.Color1 = System.Drawing.Color.Red;
            this.chkIsUrgent.TabIndex = 5;
            this.chkIsUrgent.Values.ExtraText = "*";
            this.chkIsUrgent.Values.Text = "Is this an urgent call?";
            this.chkIsUrgent.CheckedChanged += new System.EventHandler(this.chkIsUrgent_CheckedChanged);
            this.chkIsUrgent.MouseEnter += new System.EventHandler(this.chkIsUrgent_MouseEnter);
            this.chkIsUrgent.MouseLeave += new System.EventHandler(this.ResetHelpText);
            // 
            // NewCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hdrGroup);
            this.Name = "NewCall";
            this.Size = new System.Drawing.Size(1018, 609);
            ((System.ComponentModel.ISupportInitialize)(this.hdrGroup.Panel)).EndInit();
            this.hdrGroup.Panel.ResumeLayout(false);
            this.hdrGroup.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hdrGroup)).EndInit();
            this.hdrGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup hdrGroup;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnSaveAndNotify;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCallerEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCallerEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCallerName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCallerName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPhoneNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtPhoneNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbMessage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCharCount;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkIsUrgent;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblLastUpdated;
    }
}
