﻿using CallLogTracker.backend.database.wrappers;
using CallLogTracker.gui.dialogs;
using CallLogTracker.Properties;
using CallLogTracker.security;
using CallLogTracker.utility;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CallLogTracker.utility.Enums;

namespace CallLogTracker.gui.user_controls
{
    public partial class NewEmployee : UserControl
    {
        private readonly User newUser;
        private bool passwordChanged = false;
        private bool isEditing = false;

        public NewEmployee()
        {
            InitializeComponent();

            newUser = new User();
            if (Global.Instance.CurrentCompany != null)
                newUser.AssociatedCompany = Global.Instance.CurrentCompany.ID;
        }

        public NewEmployee(User currentUser)
        {
            InitializeComponent();

            newUser = currentUser;
            PopulateFields();
            hdrContainer.ValuesPrimary.Heading = "Edit Employee";
            isEditing = true;
        }

        private void PopulateFields()
        {
            if (newUser != null)
            {
                txtEmployeeName.Text = newUser.Name;
                txtEmailAddress.Text = newUser.Email;
                txtPhoneNumber.Text = newUser.PhoneNumber;
                txtUsername.Text = newUser.Username;
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            List<ValidatorError> errors = newUser.ValidateObject();

            //If we are editing an employee, remove the validation for existing user and password length if txtPassword is empty (we assume no password change).
            if (isEditing)
            {
                if (errors.Contains(ValidatorError.UserExists))
                    errors.Remove(ValidatorError.UserExists);
                if (txtPassword.Text.Equals(""))
                    errors.Remove(ValidatorError.User_InvalidPassword);
            }

            if (errors.Count > 0)
            {
                string richText = Validator.ToRichText(errors);
                CRichMsgBox.Show("The employee did not pass validation checks. Check below for issues:", "Invalid Employee", richText, MessageBoxButtons.OK, Resources.error_64x64);
                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Employee could not be added because of validation checks.");
                return;
            }
            else
            {
                if (passwordChanged)
                {
                    newUser.Password = Hasher.HashPassword(txtPassword.Text);
                }

                string userInsert = newUser.Insert();
                Console.WriteLine(userInsert);

                if (!userInsert.Contains("error"))
                {
                    //If this company is not already in the list, add it. Otherwise, update it.
                    if (Global.Instance.Users.ToList().Where(c => c.ID == newUser.ID).Count() <= 0)
                        Global.Instance.Users.Add(newUser);
                    else
                    {
                        int index = Global.Instance.Users.ToList().FindIndex(c => c.ID == newUser.ID);
                        if (index != -1)
                            Global.Instance.Users[index] = newUser;
                        else
                            Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Could not find user with id {newUser.ID} in the list of users.");
                    }

                    Global.Instance.MainForm.UpdateUsers();

                    Global.Instance.MainForm.panContent.Controls.Clear();
                }
            }
        }

        #region GUI Events
        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {
            newUser.Name = txtEmployeeName.Text;
        }

        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {
            newUser.Email = txtEmailAddress.Text;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            newUser.PhoneNumber = txtPhoneNumber.Text;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            newUser.Username = txtUsername.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            newUser.Password = txtPassword.Text;
            passwordChanged = true;
        }

        private void txtEmployeeName_MouseEnter(object sender, EventArgs e)
        {
            hdrContainer.ValuesSecondary.Heading = "Enter the employee's full name. (Max: 255 chars)";
        }

        private void ResetHelpText(object sender, EventArgs e)
        {
            hdrContainer.ValuesSecondary.Heading = "Hover over a label for more information.";
        }

        private void txtEmail_MouseEnter(object sender, EventArgs e)
        {
            hdrContainer.ValuesSecondary.Heading = "Enter the employee's email address. This is used to send notifications about calls via email. (Max: 255 chars)";
        }

        private void txtPhoneNumber_MouseEnter(object sender, EventArgs e)
        {
            hdrContainer.ValuesSecondary.Heading = "Enter the employee's cell phone number. This is used to send notifications about calls via SMS.";
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            hdrContainer.ValuesSecondary.Heading = "Enter the employee's username. This is used to log in. (Max: 255 chars)";
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            hdrContainer.ValuesSecondary.Heading = "Enter a password for the employee. This is used to log in. (Between 6 and 24 chars; must include at least 1 special character and 1 number.)";
        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            KryptonTextBox txtBox = sender as KryptonTextBox;
            if (txtBox != null)
                txtBox.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 128);
            else
            {
                KryptonComboBox cmb = sender as KryptonComboBox;
                if (cmb != null)
                    cmb.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(255, 255, 128);
            }

            BeginInvoke((MethodInvoker)delegate ()
            {
                txtPhoneNumber.Select(0, 0);
            });
        }

        private void txtBox_Enter(object sender, EventArgs e)
        {
            KryptonTextBox txtBox = sender as KryptonTextBox;
            if (txtBox != null)
                txtBox.StateCommon.Back.Color1 = Color.FromArgb(255, 255, 128);
            else
            {
                KryptonComboBox cmb = sender as KryptonComboBox;
                if (cmb != null)
                    cmb.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(255, 255, 128);
            }
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
            KryptonTextBox txtBox = sender as KryptonTextBox;
            if (txtBox != null)
                txtBox.StateCommon.Back.Color1 = Color.White;
            else
            {
                KryptonComboBox cmb = sender as KryptonComboBox;
                if (cmb != null)
                    cmb.StateCommon.ComboBox.Back.Color1 = Color.White;
            }
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Global.Instance.MainForm.panContent.Controls.Clear();
        }
    }
}