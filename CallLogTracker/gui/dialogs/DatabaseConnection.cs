using CallLogTracker.backend.database;
using CallLogTracker.Properties;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CallLogTracker.utility.CEventArgs;

namespace CallLogTracker.gui.dialogs
{
    public partial class DatabaseConnection : KryptonForm
    {
        private MySqlException errorCode;
        private bool isConnected;

        /// <summary>
        /// When this event is fired, a <see cref="DBArgs"/> object that represents the error code of the DBConnection attempt, is returned.
        /// </summary>
        public event EventHandler DatabaseConnectFinished;

        public DatabaseConnection()
        {
            InitializeComponent();

            btnTestConnection.Click += TestConnection;
            btnFinish.Click += Finish;
        }

        private void DBConnection_Load(object sender, EventArgs e)
        {
            txtServer.Text = Database.Server;
            txtPort.Text = Database.Port;
            txtDB.Text = Database.DB;
            txtUsername.Text = Database.Username;
            txtPassword.Text = Database.Password;

            tlpStatus.Visible = false;
            progressBarLoad.Value = 0;
        }

        private void TestConnection(object sender, EventArgs e)
        {
            if (!bgWorker.IsBusy)
            {
                progressBarLoad.Value = 0;
                tlpStatus.Visible = true;
                progressBarLoad.Visible = true;
                bgWorker.RunWorkerAsync();
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Database.Server = txtServer.Text;
            txtStatus.Text = "Checking Server...";
            bgWorker.ReportProgress(10);
            Thread.Sleep(500);

            Database.Port = txtPort.Text;
            txtStatus.Text = "Checking Port...";
            bgWorker.ReportProgress(20);
            Thread.Sleep(500);

            Database.DB = txtDB.Text;
            txtStatus.Text = "Checking Database...";
            bgWorker.ReportProgress(30);
            Thread.Sleep(500);

            Database.Username = txtUsername.Text;
            txtStatus.Text = "Checking Username...";
            bgWorker.ReportProgress(40);
            Thread.Sleep(500);

            Database.Password = txtPassword.Text;
            txtStatus.Text = "Checking Password...";
            bgWorker.ReportProgress(50);
            Thread.Sleep(500);

            Database.SaveConnectionString();
            txtStatus.Text = "Checking Connection.";
            bgWorker.ReportProgress(60);
            Thread.Sleep(500);

            txtStatus.Text = "Checking Connection..";
            bgWorker.ReportProgress(70);
            Thread.Sleep(500);

            txtStatus.Text = "Checking Connection...";
            bgWorker.ReportProgress(80);
            Thread.Sleep(500);

            errorCode = Database.CheckConnection();

            txtStatus.Text = "Checking Connection.";
            bgWorker.ReportProgress(90);
            Thread.Sleep(500);

            txtStatus.Text = "Checking Connection..";
            bgWorker.ReportProgress(100);
            Thread.Sleep(500);
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarLoad.Value = e.ProgressPercentage;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isConnected = errorCode == null;

            if (isConnected)
            {
                progressBarLoad.Visible = false;
                txtStatus.Text = "Connected!";
                btnFinish.Visible = true;
                Global.Instance.DatabaseConnected = true;
            }
            else
            {
                txtStatus.Text = "Not Connected to Server!";
                btnFinish.Visible = false;
                Global.Instance.DatabaseConnected = false;
                CRichMsgBox.Show("There was an issue communicating with the server. See the error below:", "Server Connection Failed", Database.GetErrorMessage(errorCode), MessageBoxButtons.OK, Resources.error_64x64);
            }
        }

        private void Finish(object sender, EventArgs e)
        {
            if (errorCode == null)
                DatabaseConnectFinished?.Invoke(this, new DBArgs(-1));

            if (isConnected)
            {
                Close();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (Global.Instance.NumberOfDBConnectionFormsOpen > 0)
                Global.Instance.NumberOfDBConnectionFormsOpen -= 1;

            base.OnFormClosed(e);
        }
    }
}
