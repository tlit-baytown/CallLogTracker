﻿using CallLogTracker.backend.database;
using CallLogTracker.backend.database.wrappers;
using CallLogTracker.backend.notifications;
using CallLogTracker.gui.dialogs;
using CallLogTracker.gui.user_controls;
using CallLogTracker.Properties;
using CallLogTracker.security;
using CallLogTracker.utility;
using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid;
using MySql.Data.MySqlClient;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CallLogTracker.utility.CEventArgs;

namespace CallLogTracker
{
    public partial class MainForm : KryptonForm
    {
        private bool loggedIn = false;

        public KryptonDockingWorkspace DockingWorkspace { get; private set; } = null;
        private ConsolePage ConsolePg = new ConsolePage();

        public MainForm()
        {
            InitializeComponent();

            UpdateTitleText();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //TODO: hook into console user control
            //TextBoxWriter writer = new TextBoxWriter(txtConsole);
            //Console.SetOut(writer);
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Call Logger Loaded!");

            InitializeSettings();

            DockingWorkspace = dockingManager.ManageWorkspace("MainWorkspace", dockableWorkspace);
            dockingManager.ManageControl("Control", panContent, DockingWorkspace);
            dockingManager.ManageFloating("Floating", this);

            dockingManager.AddAutoHiddenGroup("Control", DockingEdge.Bottom, new KryptonPage[] { ConsolePg, new ViewCallsPage() });

            //Set main form
            Global.Instance.MainForm = this;

            cmbUsers.ComboBox.DisplayMember = "Name";
        }

        private void InitializeSettings()
        {
            if (Settings.Default.UpgradeRequired)
            {
                Settings.Default.Upgrade();
                Settings.Default.UpgradeRequired = false;
                Settings.Default.Save();
            }
        }

        private void btnNewDBConnection_Click(object sender, EventArgs e)
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
                            Global.Instance.MainForm.checkConnectionBGWorker.RunWorkerAsync();
                        Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Database connected: {Database.Server}\\{Database.DB}");
                        break;
                    }
                    default: //unknown error; display error code for debugging
                    CMessageBox.Show($"An error occured with DB connection. Error code: {args.ExceptionCode}\nCheck your settings and try again.", "Could not connect", MessageBoxButtons.OK, Resources.error);
                    break;
                }
            }
        }

        public void UpdateTitleText()
        {
            Text = $"{Resources.AppName} \t Database: {Database.Server}\\{Database.DB} \t" +
                            $" Current User: {(Global.Instance.CurrentUser == null ? "No User" : $"{Global.Instance.CurrentUser.Name}")} \t" +
                            $" Current Company: {(Global.Instance.CurrentCompany == null ? "No Company" : $"{Global.Instance.CurrentCompany.Name}")}";
        }

        MySqlException code;
        private void checkConnectionBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            checkConnectionBGWorker.ReportProgress(33);

            Database.Initialize();

            checkConnectionBGWorker.ReportProgress(66);

            code = Database.CheckConnection();

            checkConnectionBGWorker.ReportProgress(100);
        }

        private void checkConnectionBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Checking database connection. Please wait... {e.ProgressPercentage}%");
        }

        private void checkConnectionBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!Database.GetErrorMessage(code).Equals("NO ERROR"))
                Text = $"{Resources.AppName} - No Database Connection - No User - No Company";
            else
                UpdateTitleText();

            //If database is not connected, show form again.
            if (!Global.Instance.DatabaseConnected)
            {
                DatabaseConnection dbform = new DatabaseConnection();
                dbform.DatabaseConnectFinished += OnDBConnectDone;
                dbform.ShowDialog();
            }

            if (Database.GetNumberOfRows("User") == 0)
            {
                FirstRunUser firstRunUser = new FirstRunUser();
                firstRunUser.UserCreated += ProcessLogin;
                firstRunUser.ShowDialog();
            }
            else
            {
                if (Global.Instance.NumberOfLoginFormsOpen == 0)
                {
                    LogIn();
                }
            }
        }

        private void ProcessLogin(object sender, EventArgs e)
        {
            if (e is LoginDoneEventArgs args)
            {
                Global.Instance.CurrentUser = args.LoggedInUser;
                cmbUsers.ComboBox.DataSource = Global.Instance.Users;

                if (cmbUsers.Items.Count > 0)
                {
                    int index = cmbUsers.Items.IndexOf(cmbUsers.Items.Cast<User>().Where(u => u.ID == Global.Instance.CurrentUser.ID).First());
                    cmbUsers.SelectedIndex = index == -1 ? 0 : index;

                    loggedIn = true;
                    UpdateTitleText();

                    RefreshWorkspace();
                }
            }
            else if (e is UserCreatedEventArgs a)
            {
                Global.Instance.CurrentUser = a.CreatedUser;
                cmbUsers.ComboBox.DataSource = Global.Instance.Users;

                if (cmbUsers.Items.Count > 0)
                {
                    int index = cmbUsers.Items.IndexOf(cmbUsers.Items.Cast<User>().Where(u => u.ID == Global.Instance.CurrentUser.ID).First());
                    cmbUsers.SelectedIndex = index == -1 ? 0 : index;

                    loggedIn = true;
                    UpdateTitleText();

                    RefreshWorkspace();
                }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            checkConnectionBGWorker.RunWorkerAsync();
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Checking database connection. Please wait...");
        }

        

        public void LogOut()
        {
            if (Global.Instance.CurrentUser != null)
            {
                Global.Instance.CurrentUser = null;
                LogIn();
            }
        }

        public void LogIn()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.LoginDone += ProcessLogin;
            Global.Instance.NumberOfLoginFormsOpen++;
            loginForm.ShowDialog();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            if (Global.Instance.CurrentUser == null)
            {
                CMessageBox.Show("No employee is currently logged in!", "No Employee", MessageBoxButtons.OK, Resources.error_64x64);
                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Attempt to create a new call denied.");
                return;
            }

            KryptonPage page = new NewEmployeePage();
            dockingManager.AddToWorkspace("MainWorkspace", new KryptonPage[] { page });
            dockingManager.FindDockingWorkspace("MainWorkspace").SelectPage(page.UniqueName);
        }

        private void btnNewCompany_Click(object sender, EventArgs e)
        {
            if (Global.Instance.CurrentUser == null)
            {
                CMessageBox.Show("No employee is currently logged in!", "No Employee", MessageBoxButtons.OK, Resources.error_64x64);
                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Attempt to create a new call denied.");
                return;
            }

            KryptonPage page = new NewCompanyPage();
            dockingManager.AddToWorkspace("MainWorkspace", new KryptonPage[] { page });
            dockingManager.FindDockingWorkspace("MainWorkspace").SelectPage(page.UniqueName);
        }

        private void btnNewCall_Click(object sender, EventArgs e)
        {
            if (Global.Instance.CurrentUser == null)
            {
                CMessageBox.Show("No employee is currently logged in!", "No Employee", MessageBoxButtons.OK, Resources.error_64x64);
                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Attempt to create a new call denied.");
                return;
            }

            KryptonPage page = new NewCallPage();
            dockingManager.AddToWorkspace("MainWorkspace", new KryptonPage[] { page });
            dockingManager.FindDockingWorkspace("MainWorkspace").SelectPage(page.UniqueName);
        }

        private void btnEditCurrentEmployee_Click(object sender, EventArgs e)
        {
            if (Global.Instance.CurrentUser == null)
            {
                CMessageBox.Show("There is no employee selected to edit!", "No Employee", MessageBoxButtons.OK, Resources.error_64x64);
                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Attempt to edit a non-existent employee denied.");
                return;
            }

            KryptonPage page = new NewEmployeePage(Global.Instance.CurrentUser);
            dockingManager.AddToWorkspace("MainWorkspace", new KryptonPage[] { page });
            dockingManager.FindDockingWorkspace("MainWorkspace").SelectPage(page.UniqueName);
        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            if (Global.Instance.CurrentCompany == null)
            {
                CMessageBox.Show("There is no company selected to edit!", "No Company", MessageBoxButtons.OK, Resources.error_64x64);
                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Attempt to edit a non-existent company denied.");
                return;
            }

            KryptonPage page = new NewCompanyPage(Global.Instance.CurrentCompany);
            dockingManager.AddToWorkspace("MainWorkspace", new KryptonPage[] { page });
            dockingManager.FindDockingWorkspace("MainWorkspace").SelectPage(page.UniqueName);
        }

        public void UpdateUsers()
        {
            cmbUsers.ComboBox.DataSource = Global.Instance.Users;
            if (Global.Instance.CurrentUser != null)
            {
                int index = cmbUsers.Items.IndexOf(cmbUsers.Items.Cast<User>().Where(c => c.ID == Global.Instance.CurrentUser.ID));
                cmbUsers.SelectedIndex = index == -1 ? 0 : index;
            }
            if (Global.Instance.CurrentUser == null)
                LogOut();
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Global.Instance.DatabaseConnected)
            {
                if (Global.Instance.CurrentUser != null)
                {
                    User selectedUser = cmbUsers.Items[cmbUsers.SelectedIndex] as User;
                    if (selectedUser.ID != Global.Instance.CurrentUser.ID)
                    {
                        string passwordInput = KryptonInputBox.Show(this, "Please enter the user's password: ", "Password Needed");
                        if (Hasher.AuthenticatePassword(passwordInput, selectedUser.Password))
                        {
                            Global.Instance.CurrentUser = selectedUser;
                            RefreshWorkspace();
                        }
                        else
                        {
                            CMessageBox.Show("Invalid password!", "Not Authenticated", MessageBoxButtons.OK, Resources.error_64x64);
                            Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> {Global.Instance.CurrentUser.Name} attempted to sign into {selectedUser.Name}'s account.");
                            
                            int index = cmbUsers.Items.IndexOf(cmbUsers.Items.Cast<User>().Where(u => u.ID == Global.Instance.CurrentUser.ID).First());
                            cmbUsers.SelectedIndex = index == -1 ? 0 : index;
                        }
                    }
                }
                else
                {
                    Global.Instance.CurrentUser = cmbUsers.Items[cmbUsers.SelectedIndex] as User;
                }
            }

            UpdateTitleText();
        }

        private void RefreshWorkspace()
        {
            List<KryptonPage> pages = new List<KryptonPage>();
            foreach (KryptonPage page in dockingManager.Pages)
            {
                if (!page.UniqueName.Equals("Console") || !page.UniqueName.Equals("CallsPage"))
                    pages.Add(page);
            }

            DockingWorkspace.RemovePages(pages.ToArray(), true);

            //Update employee's calls in the grid
            (dockingManager.PageForUniqueName("CallsPage") as ViewCallsPage).UpdateCalls();
        }
    }
}
