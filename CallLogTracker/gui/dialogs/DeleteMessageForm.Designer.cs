﻿
namespace CallLogTracker.gui.dialogs
{
    partial class DeleteMessageForm
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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblText = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.rtbMessage = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.btnYes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.lvObjects = new System.Windows.Forms.ListView();
            this.lblListViewCaption = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.ErrorImage = null;
            this.picImage.InitialImage = null;
            this.picImage.Location = new System.Drawing.Point(12, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(64, 64);
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lblText.Location = new System.Drawing.Point(82, 12);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 15);
            this.lblText.Text = "Text";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMessage.Location = new System.Drawing.Point(0, 0);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.Size = new System.Drawing.Size(359, 207);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.Location = new System.Drawing.Point(376, 295);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 25);
            this.btnYes.TabIndex = 1;
            this.btnYes.Values.Text = "Yes";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNo.Location = new System.Drawing.Point(457, 295);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 25);
            this.btnNo.TabIndex = 2;
            this.btnNo.Values.Text = "No";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(538, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(457, 295);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 8;
            this.btnOK.Values.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(12, 82);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.rtbMessage);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.lvObjects);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(601, 207);
            this.kryptonSplitContainer1.SplitterDistance = 359;
            this.kryptonSplitContainer1.TabIndex = 10;
            // 
            // lvObjects
            // 
            this.lvObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvObjects.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvObjects.HideSelection = false;
            this.lvObjects.Location = new System.Drawing.Point(0, 0);
            this.lvObjects.MultiSelect = false;
            this.lvObjects.Name = "lvObjects";
            this.lvObjects.Size = new System.Drawing.Size(237, 207);
            this.lvObjects.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvObjects.TabIndex = 0;
            this.lvObjects.UseCompatibleStateImageBehavior = false;
            this.lvObjects.View = System.Windows.Forms.View.List;
            // 
            // lblListViewCaption
            // 
            this.lblListViewCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListViewCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lblListViewCaption.Location = new System.Drawing.Point(376, 59);
            this.lblListViewCaption.Name = "lblListViewCaption";
            this.lblListViewCaption.Size = new System.Drawing.Size(145, 17);
            this.lblListViewCaption.StateCommon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListViewCaption.Text = "Objects to be deleted: ";
            this.lblListViewCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeleteMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 332);
            this.Controls.Add(this.lblListViewCaption);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.picImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Title";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox picImage;
        internal ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblText;
        internal ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbMessage;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnYes;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnNo;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnOK;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        internal System.Windows.Forms.ListView lvObjects;
        internal ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblListViewCaption;
    }
}