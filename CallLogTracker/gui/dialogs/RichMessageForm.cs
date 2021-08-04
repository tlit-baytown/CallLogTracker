﻿using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace CallLogTracker.gui.dialogs
{
    public partial class RichMessageForm : KryptonForm
    {
        internal RichMessageForm() => InitializeComponent();

        private void btnYes_Click(object sender, EventArgs e) =>
            DialogResult = DialogResult.Yes;

        private void btnNo_Click(object sender, EventArgs e) =>
            DialogResult = DialogResult.No;

        private void btnCancel_Click(object sender, EventArgs e) =>
            DialogResult = DialogResult.Cancel;

        private void btnOK_Click(object sender, EventArgs e) =>
            DialogResult = DialogResult.OK;
    }
}
