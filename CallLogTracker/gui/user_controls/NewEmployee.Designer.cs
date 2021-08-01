
namespace CallLogTracker.gui.user_controls
{
    partial class NewEmployee
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
            this.hdrContainer = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btnAddEmployee = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtEmailAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblUsername = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtEmployeeName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtPhoneNumber = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            ((System.ComponentModel.ISupportInitialize)(this.hdrContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdrContainer.Panel)).BeginInit();
            this.hdrContainer.Panel.SuspendLayout();
            this.hdrContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hdrContainer
            // 
            this.hdrContainer.AutoSize = true;
            this.hdrContainer.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.btnAddEmployee,
            this.btnClose});
            this.hdrContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hdrContainer.Location = new System.Drawing.Point(0, 0);
            this.hdrContainer.Name = "hdrContainer";
            // 
            // hdrContainer.Panel
            // 
            this.hdrContainer.Panel.Controls.Add(this.tableLayoutPanel1);
            this.hdrContainer.Size = new System.Drawing.Size(747, 491);
            this.hdrContainer.TabIndex = 0;
            this.hdrContainer.ValuesPrimary.Description = "Create a new employee in the current company. All fields are required.";
            this.hdrContainer.ValuesPrimary.Heading = "New Employee";
            this.hdrContainer.ValuesPrimary.Image = global::CallLogTracker.Properties.Resources.man_32x32;
            this.hdrContainer.ValuesSecondary.Heading = "Hover over a label for more information.";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Image = global::CallLogTracker.Properties.Resources.save_16x16;
            this.btnAddEmployee.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.btnAddEmployee.Text = "Save";
            this.btnAddEmployee.UniqueName = "B2CE65B2F21044C41B972348A6C29067";
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.24161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.75839F));
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtEmailAddress, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtEmployeeName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPhoneNumber, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(745, 145);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(123, 119);
            this.txtPassword.MaxLength = 24;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(619, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailAddress.Location = new System.Drawing.Point(123, 32);
            this.txtEmailAddress.MaxLength = 255;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(619, 23);
            this.txtEmailAddress.TabIndex = 1;
            this.txtEmailAddress.TextChanged += new System.EventHandler(this.txtEmailAddress_TextChanged);
            this.txtEmailAddress.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtEmailAddress.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 33);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(114, 20);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.TabStop = false;
            this.kryptonLabel1.Values.Text = "Email Address: ";
            this.kryptonLabel1.MouseEnter += new System.EventHandler(this.txtEmail_MouseEnter);
            this.kryptonLabel1.MouseLeave += new System.EventHandler(this.ResetHelpText);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.Location = new System.Drawing.Point(3, 4);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(114, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.TabStop = false;
            this.lblUsername.Values.Text = "Employee Name: ";
            this.lblUsername.MouseEnter += new System.EventHandler(this.txtEmployeeName_MouseEnter);
            this.lblUsername.MouseLeave += new System.EventHandler(this.ResetHelpText);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeName.Location = new System.Drawing.Point(123, 3);
            this.txtEmployeeName.MaxLength = 255;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(619, 23);
            this.txtEmployeeName.TabIndex = 0;
            this.txtEmployeeName.TextChanged += new System.EventHandler(this.txtEmployeeName_TextChanged);
            this.txtEmployeeName.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtEmployeeName.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 62);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(114, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.TabStop = false;
            this.kryptonLabel2.Values.Text = "Phone Number: ";
            this.kryptonLabel2.MouseEnter += new System.EventHandler(this.txtPhoneNumber_MouseEnter);
            this.kryptonLabel2.MouseLeave += new System.EventHandler(this.ResetHelpText);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel3.Location = new System.Drawing.Point(3, 91);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(114, 20);
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.TabStop = false;
            this.kryptonLabel3.Values.Text = "Username: ";
            this.kryptonLabel3.MouseEnter += new System.EventHandler(this.txtUsername_MouseEnter);
            this.kryptonLabel3.MouseLeave += new System.EventHandler(this.ResetHelpText);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(123, 90);
            this.txtUsername.MaxLength = 255;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(619, 23);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel4.Location = new System.Drawing.Point(3, 120);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(114, 20);
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.TabStop = false;
            this.kryptonLabel4.Values.Text = "Password: ";
            this.kryptonLabel4.MouseEnter += new System.EventHandler(this.txtPassword_MouseEnter);
            this.kryptonLabel4.MouseLeave += new System.EventHandler(this.ResetHelpText);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(123, 61);
            this.txtPhoneNumber.Mask = "###-###-####";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(619, 23);
            this.txtPhoneNumber.TabIndex = 2;
            this.txtPhoneNumber.Text = "   -   -";
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.Enter += new System.EventHandler(this.txtPhoneNumber_Enter);
            this.txtPhoneNumber.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::CallLogTracker.Properties.Resources.error_16x16;
            this.btnClose.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.btnClose.Text = "Close";
            this.btnClose.UniqueName = "B79690CC905642A5BEBCD7F1683A26FD";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hdrContainer);
            this.Name = "NewEmployee";
            this.Size = new System.Drawing.Size(747, 491);
            ((System.ComponentModel.ISupportInitialize)(this.hdrContainer.Panel)).EndInit();
            this.hdrContainer.Panel.ResumeLayout(false);
            this.hdrContainer.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hdrContainer)).EndInit();
            this.hdrContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup hdrContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmailAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmployeeName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtPhoneNumber;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnAddEmployee;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnClose;
    }
}
