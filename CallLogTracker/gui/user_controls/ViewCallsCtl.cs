using CallLogTracker.backend.database;
using CallLogTracker.backend.database.wrappers;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallLogTracker.gui.user_controls
{
    public partial class ViewCallsCtl : UserControl
    {
        private bool onlyCallsToday = true;
        private List<OutlookGridRow> rows = new List<OutlookGridRow>();

        public ViewCallsCtl()
        {
            InitializeComponent();
        }

        public void UpdateCalls()
        {
            LoadData();
        }

        private void ViewCallsCtl_Load(object sender, EventArgs e)
        {
            dgCalls.RegisterGroupBoxEvents();
            LoadData();
        }

        private void LoadData()
        {
            if (!getCallsBGWorker.IsBusy & Global.Instance.CurrentUser != null)
            {
                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Loading calls for {Global.Instance.CurrentUser.Name}...");
                getCallsBGWorker.RunWorkerAsync();
            }
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {

        }

        private void chkOnlyCallsToday_Click(object sender, EventArgs e)
        {
            onlyCallsToday = (chkOnlyCallsToday.Checked == ButtonCheckState.Checked);
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgCalls.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgCalls.SelectedRows[0];
                Call c = r.Tag as Call;
                Global.Instance.MainForm.DockingWorkspace.DockingManager.AddFloatingWindow("Floating", new KryptonPage[] { new NewCallPage(c) });
            }
        }

        private void getCallsBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (onlyCallsToday)
                Global.Instance.CallsToday = CallConnector.GetCallsForToday();
            else
                Global.Instance.CallsToday = CallConnector.GetCalls();

            getCallsBGWorker.ReportProgress(10);

            OutlookGridRow row;
            rows = new List<OutlookGridRow>();

            int cCounter = 0;
            foreach (Call c in Global.Instance.CallsToday)
            {
                row = new OutlookGridRow();
                row.CreateCells(dgCalls, new object[] {
                    c.Date.ToShortDateString().Replace('/', '-'),
                    c.IsUrgent ? "*" : "",
                    c.CallerName,
                    c.CallerPhone,
                    c.Message
                });
                row.Tag = c;
                rows.Add(row);
                cCounter++;
                getCallsBGWorker.ReportProgress((cCounter / Global.Instance.CallsToday.Count) * 100);
            }
            getCallsBGWorker.ReportProgress(100);
        }

        private void getCallsBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Loading calls: {e.ProgressPercentage}%");
        }

        private void getCallsBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!Disposing && !IsDisposed)
            {
                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Calls loaded!");

                dgCalls.SuspendLayout();
                dgCalls.ClearInternalRows();
                dgCalls.AssignRows(rows);
                dgCalls.ForceRefreshGroupBox();
                dgCalls.Fill();

                foreach (Call c in Global.Instance.CallsToday)
                {
                    if (!c.IsUrgent)
                    {
                        int index = rows.FindIndex(r => (r.Tag as Call).ID == c.ID);
                        if (index != -1)
                        {
                            dgCalls[0, index].Style = new DataGridViewCellStyle();
                            dgCalls.UpdateCellValue(0, index);
                        }
                    }
                }

                dgCalls.ResumeLayout();
            }
            else
            {
                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> Call loading canceled!");
            }
        }
    }
}
