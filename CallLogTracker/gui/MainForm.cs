using CallLogTracker.backend.database;
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
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Linq;
using System.Reflection;
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
            InitializeSettings();

            DockingWorkspace = dockingManager.ManageWorkspace("MainWorkspace", dockableWorkspace);
            dockingManager.ManageControl("Control", panContent, DockingWorkspace);
            dockingManager.ManageFloating("Floating", this);

            dockingManager.AddAutoHiddenGroup("Control", DockingEdge.Bottom, new KryptonPage[] { ConsolePg, new ViewCallsPage() });

            //Set main form
            Global.Instance.MainForm = this;

            cmbUsers.ComboBox.DisplayMember = "Name";

            GetConsole().AddEntry("Call Logger Loaded!");

            ConfigReader.Instance.Initialize();

            if (!ConfigReader.Instance.ValidConfig)
            {
                CMessageBox.Show("The configuration file was either not present, could not be read, or contained invalid entries.\nPlease correct the config.cfg file.\nThe application will now exit!", "Error Reading Config", MessageBoxButtons.OK, Resources.error_64x64);
                Application.Exit();
            }
        }

        /// <summary>
        /// Get the global log console.
        /// </summary>
        /// <returns>The log console where log entries are added.</returns>
        public ConsoleCtl GetConsole()
        {
            return ConsolePg.GetConsole();
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
                GetConsole().AddEntry("Attempt to open multiple database connections denied.");
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
                        GetConsole().AddEntry("Database connected: {Database.Server}\\{Database.DB}");
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
            GetConsole().AddEntry($"Checking database connection. Please wait... {e.ProgressPercentage}%");
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

            if (Database.GetNumberOfRows("Company") == 0)
            {
                FirstRunCompany firstRunCompany = new FirstRunCompany();
                firstRunCompany.CompanyCreated += ProcessCompany;
                firstRunCompany.ShowDialog();
            }
            else
            {
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

            Notifier.Instance.Initialize();
        }

        private void ProcessCompany(object sender, EventArgs e)
        {
            if (e is CompanyCreatedEventArgs args)
            {
                Global.Instance.CurrentCompany = args.CreatedCompany;

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
        }

        private void ProcessLogin(object sender, EventArgs e)
        {
            if (e is LoginDoneEventArgs args)
            {
                cmbUsers.ComboBox.DataSource = Global.Instance.Users;

                if (cmbUsers.Items.Count > 0)
                {
                    int index = cmbUsers.Items.IndexOf(cmbUsers.Items.Cast<User>().Where(u => u.ID == args.LoggedInUser.ID).First());
                    cmbUsers.SelectedIndex = index == -1 ? 0 : index;

                    Global.Instance.CurrentUser = args.LoggedInUser;

                    UpdateTitleText();

                    RefreshWorkspace();

                    loggedIn = true;
                }
            }
            else if (e is UserCreatedEventArgs a)
            {
                cmbUsers.ComboBox.DataSource = Global.Instance.Users;

                if (cmbUsers.Items.Count > 0)
                {
                    loggedIn = true;

                    int index = cmbUsers.Items.IndexOf(cmbUsers.Items.Cast<User>().Where(u => u.ID == a.CreatedUser.ID).First());
                    cmbUsers.SelectedIndex = index == -1 ? 0 : index;

                    Global.Instance.CurrentUser = a.CreatedUser;

                    UpdateTitleText();

                    RefreshWorkspace();

                    loggedIn = true;
                }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            checkConnectionBGWorker.RunWorkerAsync();
            GetConsole().AddEntry("Checking database connection. Please wait...");
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
                GetConsole().AddEntry("Attempt to create a new call denied.");
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
                GetConsole().AddEntry("Attempt to create a new call denied.");
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
                GetConsole().AddEntry("Attempt to create a new call denied.");
                return;
            }

            KryptonPage page = new NewCallPage();
            dockingManager.AddToWorkspace("MainWorkspace", new KryptonPage[] { page });
            dockingManager.FindDockingWorkspace("MainWorkspace").SelectPage(page.UniqueName);
        }

        private void btnViewCalls_Click(object sender, EventArgs e)
        {
            if (Global.Instance.CurrentUser == null)
            {
                CMessageBox.Show("No employee is currently logged in!", "No Employee", MessageBoxButtons.OK, Resources.error_64x64);
                GetConsole().AddEntry("Attempt to create a new call denied.");
                return;
            }

            KryptonPage page = new ViewCallsPage();
            if (dockingManager.ContainsPage(page))
            {
                dockingManager.RemovePage(page, true);
                dockingManager.AddDockspace("Control", DockingEdge.Bottom, new KryptonPage[] { page });
            }
            else
            {
                dockingManager.AddDockspace("Control", DockingEdge.Bottom, new KryptonPage[] { page });
            }
        }

        private void btnEditCurrentEmployee_Click(object sender, EventArgs e)
        {
            if (Global.Instance.CurrentUser == null)
            {
                CMessageBox.Show("There is no employee selected to edit!", "No Employee", MessageBoxButtons.OK, Resources.error_64x64);
                GetConsole().AddEntry("Attempt to edit a non-existent employee denied.");
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
                GetConsole().AddEntry("Attempt to edit a non-existent company denied.");
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

        public void UpdateCalls()
        {
            //Update employee's calls in the grid
            (dockingManager.PageForUniqueName("CallsPage") as ViewCallsPage).UpdateCalls();
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Global.Instance.DatabaseConnected)
            {
                if (Global.Instance.CurrentUser != null & loggedIn)
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
                            GetConsole().AddEntry($"{Global.Instance.CurrentUser.Name} attempted to sign into {selectedUser.Name}'s account.");

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

        private void btnEmailNotifications_Click(object sender, EventArgs e)
        {
            NotificationsForm nf = new NotificationsForm(false);
            nf.ShowDialog();
        }

        private void btnSMSNotifications_Click(object sender, EventArgs e)
        {
            NotificationsForm nf = new NotificationsForm();
            nf.ShowDialog();
        }

        private void btnCheckUpdates_Click(object sender, EventArgs e)
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();
                }
                catch (DeploymentDownloadException dde)
                {
                    CRichMsgBox.Show("The new version of the application cannot be downloaded at this time.", "Error", $"Please check your network connection, or try again later. Error: {dde.Message}", MessageBoxButtons.OK, Resources.error_64x64);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    CRichMsgBox.Show("Cannot check for a new version of the application.\nThe ClickOnce deployment is corrupt.", "Error", $"Please redeploy the application and try again. Error: {ide.Message}", MessageBoxButtons.OK, Resources.error_64x64);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    CRichMsgBox.Show("This application cannot be updated.\nIt is likely not a ClickOnce application.", "Error", $"Error: {ioe.Message}", MessageBoxButtons.OK, Resources.error_64x64);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    bool doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = CMessageBox.Show($"An update is available.\nWould you like to update the application now?\nSize of Update: {Utility.FormatSize(info.UpdateSizeBytes)}", "Update Available", MessageBoxButtons.OKCancel, Resources.info_64x64);
                        if (!(DialogResult.OK == dr))
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        CMessageBox.Show("This application has detected a mandatory update from your current " +
                            "version to version " + info.MinimumRequiredVersion.ToString() +
                            ". The application will now install the update and restart.",
                            "Update Available", MessageBoxButtons.OK,
                            Resources.warning_64x64);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            CMessageBox.Show("The application has been upgraded, and will now restart.", "Update Pending", MessageBoxButtons.OK, Resources.warning_64x64);
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            CRichMsgBox.Show("Cannot install the latest version of the application.", "Error", $"Please check your network connection, or try again later. Error: {dde}", MessageBoxButtons.OK, Resources.error_64x64);
                            return;
                        }
                    }
                }
                else
                {
                    CMessageBox.Show($"Congrats! You are running the latest version.\nVersion: {Assembly.GetExecutingAssembly().GetName().Version}", "No Updates", MessageBoxButtons.OK, Resources.info_64x64);
                }
            }
            else
            {
                CRichMsgBox.Show("Cannot check for a new version of the application.\nThe ClickOnce deployment is corrupt.", "Error", $"Please redeploy the application and try again.", MessageBoxButtons.OK, Resources.error_64x64);
                return;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
