using CallLogTracker.backend.database.wrappers;
using CallLogTracker.gui.dialogs;
using CallLogTracker.Properties;
using CallLogTracker.utility;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static CallLogTracker.utility.CEventArgs;
using static CallLogTracker.utility.Enums;

namespace CallLogTracker.gui.user_controls
{
    public partial class NewCompany : UserControl
    {
        private readonly Company newCompany;
        private bool isEditing = false;

        public EventHandler CompanyCreated;

        public NewCompany()
        {
            InitializeComponent();

            newCompany = new Company();
        }

        public NewCompany(Company c)
        {
            InitializeComponent();

            newCompany = c;
            PopulateFields();
            hdrContainer.ValuesPrimary.Heading = "Edit Company";
            isEditing = true;
        }

        private void PopulateFields()
        {
            if (newCompany != null)
            {
                txtCompanyName.Text = newCompany.Name;
                txtSupportEmail.Text = newCompany.SupportEmail;
                txtPhoneNumber.Text = newCompany.Phone;
                txtNumOfEmployees.Text = newCompany.NumOfEmployees.ToString();
            }
        }

        private KryptonPage GetParent()
        {
            return Parent as KryptonPage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (GetParent() != null)
                Global.Instance.SelectedPageUniqueName = GetParent().UniqueName;

            List<ValidatorError> errors = newCompany.ValidateObject();

            if (errors.Count > 0)
            {
                string richText = Validator.ToRichText(errors);
                CRichMsgBox.Show("The company did not pass validation checks. Check below for issues:", "Invalid Company", richText, MessageBoxButtons.OK, Resources.error_64x64);
                Global.Instance.MainForm.GetConsole().AddEntry("Company could not be added because of validation checks.");
                return;
            }
            else
            {
                string companyInsert = newCompany.Insert();
                Console.WriteLine(companyInsert);

                if (!companyInsert.Contains("error"))
                {
                    //If this company is not already in the list, add it. Otherwise, update it.
                    if (Global.Instance.Companies.ToList().Where(c => c.ID == newCompany.ID).Count() <= 0)
                        Global.Instance.Companies.Add(newCompany);
                    else
                    {
                        int index = Global.Instance.Companies.ToList().FindIndex(c => c.ID == newCompany.ID);
                        if (index != -1)
                            Global.Instance.Companies[index] = newCompany;
                        else
                            Global.Instance.MainForm.GetConsole().AddEntry($"Could not find company with id {newCompany.ID} in the list of companies.");
                    }

                    CompanyCreated?.Invoke(this, new CompanyCreatedEventArgs(newCompany));

                    DialogResult result = CMessageBox.Show("Would you like to make the newly added company the current one?\nThis action will log you out.", "Make Current?", MessageBoxButtons.YesNo, Resources.info_64x64);
                    if (result == DialogResult.Yes)
                    {
                        Global.Instance.CurrentCompany = newCompany;
                        Global.Instance.MainForm.LogOut();
                    }
                    else
                    {
                        if (isEditing)
                            Global.Instance.MainForm.DockingWorkspace.DockingManager.CloseRequest(new string[] { Global.Instance.SelectedPageUniqueName });
                        else
                            Global.Instance.MainForm.DockingWorkspace.RemovePage(Global.Instance.SelectedPageUniqueName, true);
                    }
                }
            }
        }

        #region GUI Events
        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            newCompany.Name = txtCompanyName.Text;
        }

        private void txtSupportEmail_TextChanged(object sender, EventArgs e)
        {
            newCompany.SupportEmail = txtSupportEmail.Text;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            newCompany.Phone = txtPhoneNumber.Text;
        }

        private void txtNumOfEmployees_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumOfEmployees.Text, out int numOfEmployees))
                newCompany.NumOfEmployees = numOfEmployees;
        }

        private void lblCompanyName_MouseEnter(object sender, EventArgs e)
        {
            hdrContainer.ValuesSecondary.Heading = "Enter the company's full name. (Max: 255 chars)";
        }

        private void ResetHelpText(object sender, EventArgs e)
        {
            hdrContainer.ValuesSecondary.Heading = "Hover over a label for more information.";
        }

        private void lblEmail_MouseEnter(object sender, EventArgs e)
        {
            hdrContainer.ValuesSecondary.Heading = "Enter the company's primary support email. (Max: 255 chars)";
        }

        private void lblPhoneNumber_MouseEnter(object sender, EventArgs e)
        {
            hdrContainer.ValuesSecondary.Heading = "Enter the company's primary phone number. (Max: 12 chars)";
        }

        private void lblNumOfEmployees_MouseEnter(object sender, EventArgs e)
        {
            hdrContainer.ValuesSecondary.Heading = "Enter the approximate number of employees working at this company. (Max: 11 digits)";
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

        #endregion
    }
}
