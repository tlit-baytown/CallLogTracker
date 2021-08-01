using CallLogTracker.backend.database;
using CallLogTracker.backend.database.wrappers;
using CallLogTracker.backend.notifications;
using CallLogTracker.gui.dialogs;
using CallLogTracker.gui.user_controls;
using CallLogTracker.Properties;
using CallLogTracker.utility;
using ComponentFactory.Krypton.Toolkit;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TextBoxWriter writer = new TextBoxWriter(txtConsole);
            Console.SetOut(writer);
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Call Logger Loaded!");

            InitializeSettings();
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
                            UpdateTitleText();
                        Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Database connected: {Database.Server}\\{Database.DB}");
                        break;
                    }
                    default: //unknown error; display error code for debugging
                    CMessageBox.Show($"An error occured with DB connection. Error code: {args.ExceptionCode}\nCheck your settings and try again.", "Could not connect", MessageBoxButtons.OK, Resources.error);
                    break;
                }
            }
        }

        private void UpdateTitleText()
        {
            Text = $"{Resources.AppName} - {Database.Server}\\{Database.DB} -" +
                            $" {(Global.Instance.CurrentUser == null ? "No User" : $"{Global.Instance.CurrentUser.Name}")} -" +
                            $" {(Global.Instance.CurrentCompany == null ? "No Company" : $"{Global.Instance.CurrentCompany.Name}")}";
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

            //Set main form
            Global.Instance.MainForm = this;

            //If database is connected, get all of the users
            if (Global.Instance.DatabaseConnected)
            {
                cmbCompanies.DataSource = CompanyConnector.GetCompanies();
                if (cmbCompanies.Items.Count > 0)
                    Global.Instance.CurrentCompany = cmbCompanies.Items[0] as Company;

                if (Global.Instance.CurrentCompany != null)
                {
                    Global.Instance.Users = UserConnector.GetUsers(Global.Instance.CurrentCompany.ID);
                    cmbUsers.DataSource = Global.Instance.Users;
                }
            }
                
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            checkConnectionBGWorker.RunWorkerAsync();
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Checking database connection. Please wait...");
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            NewEmployee ctl = new NewEmployee();
            ctl.Dock = DockStyle.Fill;
            panContent.Controls.Clear();
            panContent.Controls.Add(ctl);
        }
    }
}
