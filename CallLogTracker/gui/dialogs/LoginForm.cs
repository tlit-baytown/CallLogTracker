using CallLogTracker.backend.database;
using CallLogTracker.backend.database.wrappers;
using CallLogTracker.Properties;
using CallLogTracker.security;
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
using static CallLogTracker.utility.CEventArgs;

namespace CallLogTracker.gui.dialogs
{
    public partial class LoginForm : KryptonForm
    {
        private User u;
        private bool forciblyClosed = true;

        public EventHandler LoginDone;

        public LoginForm()
        {
            InitializeComponent();

            btnForgotPassword.Click += btnForgotPassword_Click;
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDatabaseConnection_Click(object sender, EventArgs e)
        {
            if (Global.Instance.NumberOfDBConnectionFormsOpen == 0)
            {
                DatabaseConnection dbForm = new DatabaseConnection();
                Global.Instance.NumberOfDBConnectionFormsOpen++;
                dbForm.DatabaseConnectFinished += OnDBConnectDone;
                dbForm.Show();
            }
            else
            {
                CMessageBox.Show("Only 1 connection window can be opened at a time!", "Error", MessageBoxButtons.OK, Resources.error_64x64);
                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Attempt to open multiple database connections denied.");
            }
        }

        private void OnDBConnectDone(object sender, EventArgs e)
        {
            if (e is DBArgs args)
            {
                switch (args.ExceptionCode)
                {
                    case 0: //the user specified did not exist or did not have the correct permissions
                    CMessageBox.Show("The database user did not exist or does not have the appropiate permissions.\nCheck your settings and try again.", "Could not connect", MessageBoxButtons.OK, Resources.error);
                    break;
                    case 1042: //could not reach the hostname
                    CMessageBox.Show("The specified host could not be reached.\nCheck your settings and try again.", "Could not connect", MessageBoxButtons.OK, Resources.error);
                    Text = "Survey Manager - " + $"Database: <Not Connected>";
                    break;
                    case -1: //all good, begin loading database data
                    {
                        if (Global.Instance.DatabaseConnected)
                        {
                            if (!Global.Instance.MainForm.checkConnectionBGWorker.IsBusy)
                            {
                                Global.Instance.MainForm.checkConnectionBGWorker.RunWorkerAsync();
                                Global.Instance.MainForm.UpdateTitleText();
                            }
                        }
                            
                        Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Database connected: {Database.Server}\\{Database.DB}");
                        break;
                    }
                    default: //unknown error; display error code for debugging
                    CMessageBox.Show($"An error occured with DB connection. Error code: {args.ExceptionCode}\nCheck your settings and try again.", "Could not connect", MessageBoxButtons.OK, Resources.error);
                    break;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Global.Instance.DatabaseConnected)
            {
                CMessageBox.Show("There is no database connection. Please create one before attempting to login.", "No Connection", MessageBoxButtons.OK, Resources.error_64x64);
                return;
            }

            u = UserConnector.GetUser(txtUsername.Text);
            if (u != null)
            {
                if (u.AssociatedCompany != (cmbCompanies.SelectedItem as Company).ID)
                {
                    CMessageBox.Show("That employee is not part of the selected company!", "No Employee", MessageBoxButtons.OK, Resources.error_64x64);
                    return;
                }

                bool passwordCorrect = Hasher.AuthenticatePassword(txtPassword.Text, u.Password);
                if (passwordCorrect)
                {
                    LoginDone?.Invoke(this, new LoginDoneEventArgs(u));
                    Global.Instance.NumberOfLoginFormsOpen--;
                    forciblyClosed = false;
                    Global.Instance.MainForm.UpdateTitleText();

                    Close();
                }
                else
                {
                    CMessageBox.Show("The password you entered was incorrect.", "Invalid Login", MessageBoxButtons.OK, Resources.warning_64x64);
                }
            }
            else
            {
                CMessageBox.Show("The username you entered does not exist.", "Invalid Login", MessageBoxButtons.OK, Resources.warning_64x64);
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason == CloseReason.FormOwnerClosing)
            {
                Application.Exit();
            }

            if (forciblyClosed)
                Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Global.Instance.DatabaseConnected)
            {
                Global.Instance.Companies = CompanyConnector.GetCompanies();
                cmbCompanies.DataSource = Global.Instance.Companies;
                if (cmbCompanies.Items.Count > 0)
                {
                    cmbCompanies.Enabled = true;
                    cmbCompanies.SelectedIndex = 0;
                }
            }
            else
            {
                cmbCompanies.DataSource = null;
                cmbCompanies.Enabled = false;
            }
        }

        private void cmbCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.Instance.CurrentCompany = cmbCompanies.SelectedItem as Company;

            if (Global.Instance.CurrentCompany != null)
            {
                Global.Instance.Users = UserConnector.GetUsers(Global.Instance.CurrentCompany.ID);
            }
        }

        private void SelectCompany()
        {
            if (Global.Instance.CurrentCompany != null)
            {
                if (Global.Instance.Companies.ToList().Find(c => c.ID == Global.Instance.CurrentCompany.ID) != null)
                {
                    cmbCompanies.SelectedItem = Global.Instance.CurrentCompany;
                    Global.Instance.MainForm.UpdateTitleText();
                }
            }
        }

        private void UpdateCompanies()
        {
            cmbCompanies.DataSource = Global.Instance.Companies;
            if (Global.Instance.CurrentCompany != null)
            {
                int index = cmbCompanies.Items.IndexOf(cmbCompanies.Items.Cast<Company>().Where(c => c.ID == Global.Instance.CurrentCompany.ID));
                cmbCompanies.SelectedIndex = index == -1 ? 0 : index;
            }
        }

        private void cmbCompanies_DataSourceChanged(object sender, EventArgs e)
        {
            if (Global.Instance.DatabaseConnected)
            {
                if (Global.Instance.CurrentCompany != null)
                {
                    Global.Instance.Users = UserConnector.GetUsers(Global.Instance.CurrentCompany.ID);
                }
                else
                {
                    if (cmbCompanies.Items.Count > 0)
                    {
                        Global.Instance.CurrentCompany = cmbCompanies.Items[0] as Company;
                        Global.Instance.Users = UserConnector.GetUsers(Global.Instance.CurrentCompany.ID);
                    }
                }
            }

            Global.Instance.MainForm.UpdateTitleText();
        }
    }
}
