
namespace CallLogTracker.gui.user_controls
{
    partial class NewCompany
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
            this.btnSave = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSupportEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblSupportEmail = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCompanyName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtCompanyName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblPhoneNumber = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblNumOfEmployees = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtNumOfEmployees = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
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
            this.btnSave,
            this.btnClose});
            this.hdrContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hdrContainer.Location = new System.Drawing.Point(0, 0);
            this.hdrContainer.Name = "hdrContainer";
            // 
            // hdrContainer.Panel
            // 
            this.hdrContainer.Panel.Controls.Add(this.tableLayoutPanel1);
            this.hdrContainer.Size = new System.Drawing.Size(755, 499);
            this.hdrContainer.TabIndex = 1;
            this.hdrContainer.ValuesPrimary.Description = "Create a new company. All fields are required.";
            this.hdrContainer.ValuesPrimary.Heading = "New Company";
            this.hdrContainer.ValuesPrimary.Image = global::CallLogTracker.Properties.Resources.home_32x32;
            this.hdrContainer.ValuesSecondary.Heading = "Hover over a label for more information.";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::CallLogTracker.Properties.Resources.save_16x16;
            this.btnSave.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.btnSave.Text = "Save";
            this.btnSave.UniqueName = "B2CE65B2F21044C41B972348A6C29067";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.txtSupportEmail, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSupportEmail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCompanyName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCompanyName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPhoneNumber, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNumOfEmployees, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNumOfEmployees, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPhoneNumber, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 116);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtSupportEmail
            // 
            this.txtSupportEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupportEmail.Location = new System.Drawing.Point(152, 32);
            this.txtSupportEmail.MaxLength = 255;
            this.txtSupportEmail.Name = "txtSupportEmail";
            this.txtSupportEmail.Size = new System.Drawing.Size(598, 23);
            this.txtSupportEmail.TabIndex = 1;
            this.txtSupportEmail.TextChanged += new System.EventHandler(this.txtSupportEmail_TextChanged);
            this.txtSupportEmail.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtSupportEmail.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // lblSupportEmail
            // 
            this.lblSupportEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupportEmail.Location = new System.Drawing.Point(3, 33);
            this.lblSupportEmail.Name = "lblSupportEmail";
            this.lblSupportEmail.Size = new System.Drawing.Size(143, 20);
            this.lblSupportEmail.TabIndex = 2;
            this.lblSupportEmail.TabStop = false;
            this.lblSupportEmail.Values.Text = "Support Email: ";
            this.lblSupportEmail.MouseEnter += new System.EventHandler(this.lblEmail_MouseEnter);
            this.lblSupportEmail.MouseLeave += new System.EventHandler(this.ResetHelpText);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompanyName.Location = new System.Drawing.Point(3, 4);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(143, 20);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.TabStop = false;
            this.lblCompanyName.Values.Text = "Company Name: ";
            this.lblCompanyName.MouseEnter += new System.EventHandler(this.lblCompanyName_MouseEnter);
            this.lblCompanyName.MouseLeave += new System.EventHandler(this.ResetHelpText);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyName.Location = new System.Drawing.Point(152, 3);
            this.txtCompanyName.MaxLength = 255;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(598, 23);
            this.txtCompanyName.TabIndex = 0;
            this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
            this.txtCompanyName.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtCompanyName.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 62);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(143, 20);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.TabStop = false;
            this.lblPhoneNumber.Values.Text = "Phone Number: ";
            this.lblPhoneNumber.MouseEnter += new System.EventHandler(this.lblPhoneNumber_MouseEnter);
            this.lblPhoneNumber.MouseLeave += new System.EventHandler(this.ResetHelpText);
            // 
            // lblNumOfEmployees
            // 
            this.lblNumOfEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumOfEmployees.Location = new System.Drawing.Point(3, 91);
            this.lblNumOfEmployees.Name = "lblNumOfEmployees";
            this.lblNumOfEmployees.Size = new System.Drawing.Size(143, 20);
            this.lblNumOfEmployees.TabIndex = 6;
            this.lblNumOfEmployees.TabStop = false;
            this.lblNumOfEmployees.Values.Text = "Number of Employees: ";
            this.lblNumOfEmployees.MouseEnter += new System.EventHandler(this.lblNumOfEmployees_MouseEnter);
            this.lblNumOfEmployees.MouseLeave += new System.EventHandler(this.ResetHelpText);
            // 
            // txtNumOfEmployees
            // 
            this.txtNumOfEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumOfEmployees.Location = new System.Drawing.Point(152, 90);
            this.txtNumOfEmployees.MaxLength = 11;
            this.txtNumOfEmployees.Name = "txtNumOfEmployees";
            this.txtNumOfEmployees.Size = new System.Drawing.Size(598, 23);
            this.txtNumOfEmployees.TabIndex = 3;
            this.txtNumOfEmployees.TextChanged += new System.EventHandler(this.txtNumOfEmployees_TextChanged);
            this.txtNumOfEmployees.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtNumOfEmployees.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(152, 61);
            this.txtPhoneNumber.Mask = "###-###-####";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(598, 23);
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
            this.btnClose.UniqueName = "933BFFA9AC74458EFFA9AD74D42A303F";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NewCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hdrContainer);
            this.Name = "NewCompany";
            this.Size = new System.Drawing.Size(755, 499);
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
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSupportEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSupportEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCompanyName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCompanyName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPhoneNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNumOfEmployees;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNumOfEmployees;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtPhoneNumber;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup btnClose;
    }
}
