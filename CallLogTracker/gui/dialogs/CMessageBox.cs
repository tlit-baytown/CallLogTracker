﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallLogTracker.gui.dialogs
{
    public static class CMessageBox
    {
        /// <summary>
        /// Creates a custom MessageBox popup
        /// </summary>
        /// <param name="text">The body text of the popup</param>
        /// <param name="caption">The caption (title) of the popup</param>
        /// <param name="buttons">The <see cref="MessageBoxButtons"/> this popup should contain </param>
        /// <param name="image">An image to display left of the body text; Valid sizes for the image are from 0 to 64</param>
        /// <returns></returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, Image image)
        {
            MessageForm message = new MessageForm
            {
                Text = caption,
                ForeColor = Color.Black
            };

            if (image.Height < 0 || image.Height > 64)
                throw new Exception("Invalid image height. Valid height ranges from 0 to 64.");
            else if (image.Width < 0 || image.Width > 64)
                throw new Exception("Invalid image width. Valid width ranges from 0 to 64.");
            else
            {
                message.picImage.Image = image;
                message.lblText.Text = text;

                switch (buttons)
                {
                    case MessageBoxButtons.OK:
                    message.btnYes.Visible = false;
                    message.btnNo.Visible = false;
                    message.btnCancel.Visible = false;
                    message.btnOK.Location = message.btnCancel.Location;
                    message.btnOK.Text = "OK";
                    break;
                    case MessageBoxButtons.OKCancel:
                    message.btnYes.Visible = false;
                    message.btnNo.Visible = false;
                    message.btnOK.Text = "OK";
                    message.btnCancel.Text = "Cancel";
                    break;
                    case MessageBoxButtons.YesNo:
                    message.btnOK.Visible = false;
                    message.btnCancel.Visible = false;
                    message.btnYes.Location = message.btnOK.Location;
                    message.btnNo.Location = message.btnCancel.Location;
                    message.btnYes.Text = "Yes";
                    message.btnNo.Text = "No";
                    break;
                    case MessageBoxButtons.YesNoCancel:
                    message.btnOK.Visible = false;
                    message.btnYes.Text = "Yes";
                    message.btnNo.Text = "No";
                    message.btnCancel.Text = "Cancel";
                    break;
                    case MessageBoxButtons.RetryCancel:
                    message.btnYes.Visible = false;
                    message.btnNo.Visible = false;
                    message.btnOK.Text = "Cancel";
                    message.btnCancel.Text = "Retry";
                    break;
                }

                if (message.lblText.Height > 64)
                    message.Height = (message.lblText.Top + message.lblText.Height) + 78;

                return (message.ShowDialog());
            }
        }
    }
}
