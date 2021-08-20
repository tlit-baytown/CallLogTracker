using CallLogTracker.backend.database;
using CallLogTracker.backend.database.wrappers;
using CallLogTracker.backend.notifications;
using CallLogTracker.gui.dialogs;
using CallLogTracker.Properties;
using CallLogTracker.utility;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static CallLogTracker.utility.Enums;

namespace CallLogTracker.gui.user_controls
{
    public partial class ViewCallsCtl : UserControl
    {
        private bool onlyCallsToday = true;
        private bool onlyCurrentUserCalls = true;
        private bool onlyUnresolved = true;
        private List<OutlookGridRow> rows = new List<OutlookGridRow>();

        public ViewCallsCtl()
        {
            InitializeComponent();

            dgCalls.RegisterGroupBoxEvents();
            DataGridViewSetup.SetupDGV(dgCalls, false);
        }

        public void UpdateCalls()
        {
            LoadData();
        }

        private void ViewCallsCtl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (!getCallsBGWorker.IsBusy & Global.Instance.CurrentUser != null)
            {
                if (onlyCurrentUserCalls)
                    Global.Instance.MainForm.GetConsole().AddEntry($"Loading calls for {Global.Instance.CurrentUser.Name}...");
                else
                    Global.Instance.MainForm.GetConsole().AddEntry("Loading all calls...");

                getCallsBGWorker.RunWorkerAsync();
            }
        }

        List<Call> callsToNotifyAbout;
        private void btnNotify_Click(object sender, EventArgs e)
        {
            callsToNotifyAbout = new List<Call>();

            if (dgCalls.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgCalls.SelectedRows)
                {
                    if (row.Tag is Call c)
                        callsToNotifyAbout.Add(c);
                }

                if (!notifyBGWorker.IsBusy)
                {
                    Global.Instance.MainForm.GetConsole().AddEntry("Notifing users about selected calls...");
                    notifyBGWorker.RunWorkerAsync();
                }
            }
            else
            {
                CMessageBox.Show("No Calls were selected. There is nothing to notify users about.", "No Calls", MessageBoxButtons.OK, Resources.error_64x64);
            }
        }

        private void btnNotifyAllUnresolved_Click(object sender, EventArgs e)
        {
            callsToNotifyAbout = new List<Call>();
            foreach (DataGridViewRow row in dgCalls.Rows)
            {
                if (row.Tag is Call c)
                    if (!c.IsResolved)
                        callsToNotifyAbout.Add(c);
            }

            if (callsToNotifyAbout.Count == 0)
            {
                CMessageBox.Show("There are currently no \"Unresolved\" calls. Nothing to notify about.", "No Calls", MessageBoxButtons.OK, Resources.info_64x64);
                return;
            }

            if (!notifyBGWorker.IsBusy)
            {
                Global.Instance.MainForm.GetConsole().AddEntry("Notifing users about unresolved calls...");
                notifyBGWorker.RunWorkerAsync();
            }
        }

        int numberOfCallsNotified = 0;
        Call current;
        private void notifyBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (Call c in callsToNotifyAbout)
            {
                current = c;
                if (Notifier.Instance.Notify(current))
                {
                    numberOfCallsNotified++;
                }
                else
                    Global.Instance.MainForm.GetConsole().AddEntry($"There was an error while trying to notify recipients of call {c.ID}.{c.UserID}.{c.CompanyID}.");
            }
        }

        private void notifyBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Global.Instance.MainForm.GetConsole().AddEntry($"Recipients notified of call {current.ID}.{current.UserID}.{current.CompanyID}");
        }

        private void notifyBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CMessageBox.Show($"Notified users about {numberOfCallsNotified} Call(s).\n{callsToNotifyAbout.Count - numberOfCallsNotified} Call(s) could not be processed.", "Success", MessageBoxButtons.OK, Resources.success_64x64);
        }

        List<Call> callsToUpdate;
        private void btnMarkResolved_Click(object sender, EventArgs e)
        {
            if (dgCalls.SelectedRows.Count > 0)
            {
                callsToUpdate = new List<Call>();
                foreach (DataGridViewRow row in dgCalls.SelectedRows)
                {
                    if (row.Tag is Call c)
                    {
                        if (!c.IsResolved)
                            callsToUpdate.Add(c);
                    }
                }

                if (!updateBGWorker.IsBusy)
                {
                    updateBGWorker.RunWorkerAsync();
                    Global.Instance.MainForm.GetConsole().AddEntry("Updating all selected calls to \"Resolved\" status...");
                }
            }
        }

        private Call currentCall;
        private void updateBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (callsToUpdate != null)
                updateBGWorker.ReportProgress(100);

            foreach (Call c in callsToUpdate)
            {
                currentCall = c;
                currentCall.IsResolved = true;
                string msg = currentCall.Update();
                if (msg.Contains("error"))
                {
                    Global.Instance.MainForm.GetConsole().AddEntry("There was an unexpected error updating the call's status. Please try again.");
                    updateBGWorker.ReportProgress(100);
                }
            }
        }

        private void updateBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (currentCall != null)
                Global.Instance.MainForm.GetConsole().AddEntry($"Updating status of call: {currentCall.ID}.{currentCall.UserID}.{currentCall.CompanyID}... {e.ProgressPercentage}%");
        }

        private void updateBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!Disposing && !IsDisposed)
            {
                LoadData();
                CMessageBox.Show($"{callsToUpdate.Count} Call(s) have been marked as resolved.", "Success", MessageBoxButtons.OK, Resources.success_64x64);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgCalls.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgCalls.SelectedRows[0];
                Call c = r.Tag as Call;

                if (c.UserID != Global.Instance.CurrentUser.ID)
                {
                    CMessageBox.Show("You cannot edit calls taken by someone else!", "Error", MessageBoxButtons.OK, Resources.error_64x64);
                    return;
                }

                if (c.IsResolved)
                {
                    DialogResult result = CMessageBox.Show("The selected call has been marked as \"Resolved\".\n Are you sure you want to edit it?", "Error", MessageBoxButtons.YesNo, Resources.warning_64x64);
                    if (result == DialogResult.Yes)
                        Global.Instance.MainForm.DockingWorkspace.DockingManager.AddFloatingWindow("Floating", new KryptonPage[] { new NewCallPage(c) });
                }
            }
        }

        private List<IDBObject> objectsToDelete;

        private void btnDeleteCall_Click(object sender, EventArgs e)
        {
            if (dgCalls.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgCalls.SelectedRows[0];
                Call c = r.Tag as Call;

                if (c == null)
                {
                    Global.Instance.MainForm.GetConsole().AddEntry("Could not delete call entry; the call was null.");
                    return;
                }

                if (c.UserID != Global.Instance.CurrentUser.ID)
                {
                    CMessageBox.Show("You cannot delete calls taken by someone else!", "Error", MessageBoxButtons.OK, Resources.error_64x64);
                    return;
                }

                objectsToDelete = new List<IDBObject>();

                foreach (DataGridViewRow row in dgCalls.SelectedRows)
                {
                    if (row.Tag == null)
                        continue;
                    objectsToDelete.Add(row.Tag as IDBObject);
                }


                DialogResult result = ShowDeleteDialog();
                if (result == DialogResult.Yes)
                {
                    if (!deleteBGWorker.IsBusy)
                    {
                        Global.Instance.MainForm.GetConsole().AddEntry($"Attempting to delete {objectsToDelete.Count} call records from the database...");
                        deleteBGWorker.RunWorkerAsync();
                    }
                    else
                    {
                        Global.Instance.MainForm.GetConsole().AddEntry("There is currently a delete operation in progress. Please wait for it to finish...");
                        return;
                    }
                }
            }
            else
            {
                CMessageBox.Show("No row(s) selected. There is nothing to delete.", "Information", MessageBoxButtons.OK, Resources.info_64x64);
                return;
            }
        }

        private DialogResult ShowDeleteDialog()
        {
            string rtfHeader = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil Segoe UI;}{\\f1\\fnil\fcharset0 Segoe UI;}{\\f2\\fnil\\fcharset0 Arial;}}" +
                                "{\\colortbl;\\red255\\green0\\blue0; }" +
                                "{\\*\\generator Riched20 10.0.19041}\\viewkind4\\uc1" +
                                "\\pard\\ri-1800\\cf1\\f0\\fs19 The following will be deleted based on the type of object the grid is\\f1  \\f0 displaying\\f1  and what is selected:\\par\\cf0\\b\\f2\\fs22\\par";

            string rtfText = "\\pard\\b\\f0\\fs22 Call\\f1\\b0 - \\cf1\\f0 delete the call record only; can only delete if the call is not referenced anywhere else.\\f2\\fs20\\par}\n";;
            string totalText = rtfHeader + "\n" + rtfText;
            return CRichMsgBox.ShowDeleteDialog("Are you sure you want to delete this record?\nTHIS IS AN IRREVERSABLE OPERATION!", "Confirm", totalText, true, MessageBoxButtons.YesNo, Resources.warning_64x64, objectsToDelete);
        }


        private IDBObject currentObjectToDelete;
        private List<IDBObject> undeletableItems;
        private string currentDeleteOutput;

        private void deleteBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            undeletableItems = new List<IDBObject>();

            int i = 0;
            foreach (IDBObject obj in objectsToDelete)
            {
                currentObjectToDelete = obj;
                currentDeleteOutput = obj.Delete();
                if (currentDeleteOutput.Contains("error"))
                    undeletableItems.Add(obj);
                deleteBGWorker.ReportProgress((i / objectsToDelete.Count) * 100);
            }
        }

        private void deleteBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Global.Instance.MainForm.GetConsole().AddEntry($"Deleting calls: {e.ProgressPercentage} %");
            Global.Instance.MainForm.GetConsole().AddEntry($"Deleting call with id {currentObjectToDelete.ID}...");
        }

        private void deleteBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!Disposing && !IsDisposed)
            {
                LoadData();
                if (undeletableItems.Count > 0)
                {
                    StringBuilder bldr = new StringBuilder();
                    foreach (IDBObject obj in undeletableItems)
                    {
                        bldr.AppendLine(obj.ToString());
                    }
                    CRichMsgBox.Show("The following calls could not be deleted due to an unexpected error.", "Error on Deletion", bldr.ToString(), MessageBoxButtons.OK, Resources.warning_64x64);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void chkOnlyCallsToday_Click(object sender, EventArgs e)
        {
            onlyCallsToday = (chkOnlyCallsToday.Checked == ButtonCheckState.Checked);
            LoadData();
        }

        private void chkOnlyCurrentUserCalls_Click(object sender, EventArgs e)
        {
            onlyCurrentUserCalls = (chkOnlyCurrentUserCalls.Checked == ButtonCheckState.Checked);
            LoadData();
        }

        private void chkOnlyUnresolved_Click(object sender, EventArgs e)
        {
            onlyUnresolved = (chkOnlyUnresolved.Checked == ButtonCheckState.Checked);
            LoadData();
        }

        private void getCallsBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            CallDisplay display = new CallDisplay(onlyCurrentUserCalls, onlyCallsToday, onlyUnresolved);
            Global.Instance.CallsToday = CallConnector.GetCalls(display);

            getCallsBGWorker.ReportProgress(10);

            OutlookGridRow row;
            rows = new List<OutlookGridRow>();

            int cCounter = 0;
            foreach (Call c in Global.Instance.CallsToday)
            {
                row = new OutlookGridRow();
                row.CreateCells(dgCalls, new object[] {
                    $"{c.Date.ToShortDateString()} {c.Timestamp.ToLocalTime().ToShortTimeString()}",
                    Global.Instance.Users.ToList().Where(u => u.ID == c.UserID).First().Name,
                    c.IsUrgent ? "*" : "",
                    c.IsResolved ? "Yes" : "No",
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
            Global.Instance.MainForm.GetConsole().AddEntry($"Loading calls: {e.ProgressPercentage}%");
        }

        private void getCallsBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!Disposing && !IsDisposed)
            {
                Global.Instance.MainForm.GetConsole().AddEntry("Calls loaded!");

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

                if (!onlyCurrentUserCalls)
                    dgCalls.Columns["takenByColumn"].Visible = true;
                else
                    dgCalls.Columns["takenByColumn"].Visible = false;

                UpdatePageName();

                hdrGroup.ValuesSecondary.Heading = $"Total Calls: {dgCalls.Rows.Count}";

                if (!onlyCurrentUserCalls)
                    UpdateRowColors();
            }
            else
            {
                Global.Instance.MainForm.GetConsole().AddEntry("Call loading canceled!");
            }
        }

        private void UpdatePageName()
        {
            string titleText = "Nothing to Display";

            if (!onlyCurrentUserCalls & !onlyCallsToday & !onlyUnresolved)
                titleText = "All Calls";
            else if (!onlyCurrentUserCalls & !onlyCallsToday & onlyUnresolved)
                titleText = "All Unresolved Calls";
            else if (!onlyCurrentUserCalls & onlyCallsToday & !onlyUnresolved)
                titleText = $"All Calls on {DateTime.Now.ToLocalTime().ToShortDateString()}";
            else if (!onlyCurrentUserCalls & onlyCallsToday & onlyUnresolved)
                titleText = $"All Unresolved Calls on {DateTime.Now.ToLocalTime().ToShortDateString()}";
            else if (onlyCurrentUserCalls & !onlyCallsToday & !onlyUnresolved)
                titleText = $"All Calls for {Global.Instance.CurrentUser.Name}";
            else if (onlyCurrentUserCalls & !onlyCallsToday & onlyUnresolved)
                titleText = $"All Unresolved Calls for {Global.Instance.CurrentUser.Name}";
            else if (onlyCurrentUserCalls & onlyCallsToday & !onlyUnresolved)
                titleText = $"Calls for {Global.Instance.CurrentUser.Name} on {DateTime.Now.ToLocalTime().ToShortDateString()}";
            else if (onlyCurrentUserCalls & onlyCallsToday & onlyUnresolved)
                titleText = $"All Unresolved Calls for {Global.Instance.CurrentUser.Name} on {DateTime.Now.ToLocalTime().ToShortDateString()}";

            GetParent().TextTitle = titleText;
        }

        //Highlights the current user's calls if we are showing all calls
        private void UpdateRowColors()
        {
            try
            {
                dgCalls.SuspendLayout();
                //192, 255, 192
                foreach (DataGridViewRow row in dgCalls.Rows)
                {
                    if (row.Tag == null)
                        continue;
                    else
                    {
                        if ((row.Tag as Call).UserID == Global.Instance.CurrentUser.ID)
                        {
                            row.DefaultCellStyle = new DataGridViewCellStyle
                            {
                                BackColor = Color.FromArgb(192, 255, 192) //light green
                            };
                        }
                    }
                }
                dgCalls.ResumeLayout();
            } catch (Exception)
            {
                Global.Instance.MainForm.GetConsole().AddEntry("UpdateRowColors(): Something went wrong trying to update row colors for current user...");
                return;
            }
        }

        private KryptonPage GetParent()
        {
            return Parent as KryptonPage;
        }
    }
}
