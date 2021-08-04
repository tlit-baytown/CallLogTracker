using ComponentFactory.Krypton.Toolkit;
using JDHSoftware.Krypton.Toolkit.KryptonOutlookGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallLogTracker.utility
{
    public class DataGridViewSetup
    {
        public static void SetupDGV(KryptonOutlookGrid grid, bool restoreIfPossible)
        {
            grid.ClearEverything();
            if (grid.GroupBox != null)
            {
                grid.GroupBox.Visible = true;
                grid.HideColumnOnGrouping = false;
            }

            grid.FillMode = FillMode.GROUPSANDNODES; //tree mode enabled
            grid.ShowLines = true;

            List<DataGridViewColumn> columnsToAdd = new List<DataGridViewColumn>();
            DataGridViewColumn dateColumn = new KryptonDataGridViewTextBoxColumn
            {
                HeaderText = "Date Taken",
                Name = "dateColumn",
                SortMode = DataGridViewColumnSortMode.Programmatic,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100
            };
            columnsToAdd.Add(dateColumn);
            DataGridViewColumn urgentColumn = new KryptonDataGridViewTextBoxColumn
            {
                HeaderText = "Is Urgent?",
                Name = "urgentColumn",
                SortMode = DataGridViewColumnSortMode.Programmatic,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
                Width = 88,
                MaxInputLength = 1
            };
            columnsToAdd.Add(urgentColumn);
            DataGridViewColumn nameColumn = new KryptonDataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Name = "nameColumn",
                SortMode = DataGridViewColumnSortMode.Programmatic,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 150
            };
            columnsToAdd.Add(nameColumn);
            DataGridViewColumn phoneColumn = new KryptonDataGridViewTextBoxColumn
            {
                HeaderText = "Phone #",
                Name = "phoneColumn",
                SortMode = DataGridViewColumnSortMode.Programmatic,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100
            };
            columnsToAdd.Add(phoneColumn);
            DataGridViewColumn messageColumn = new KryptonDataGridViewTextBoxColumn
            {
                HeaderText = "Message",
                Name = "messageColumn",
                SortMode = DataGridViewColumnSortMode.Programmatic,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            columnsToAdd.Add(messageColumn);

            grid.Columns.AddRange(columnsToAdd.ToArray());

            grid.AddInternalColumn(dateColumn, new OutlookGridDateTimeGroup(null) { OneItemText = "1 call", XXXItemsText = " calls" }, SortOrder.None, -1, -1);
            grid.AddInternalColumn(urgentColumn, new OutlookGridDefaultGroup(null) { OneItemText = "1 call", XXXItemsText = " calls" }, SortOrder.None, -1, -1);
            grid.AddInternalColumn(nameColumn, new OutlookGridDefaultGroup(null) { OneItemText = "1 call", XXXItemsText = " calls" }, SortOrder.None, -1, -1);
            grid.AddInternalColumn(phoneColumn, new OutlookGridDefaultGroup(null) { OneItemText = "1 call", XXXItemsText = " calls" }, SortOrder.None, -1, -1);
            grid.AddInternalColumn(messageColumn, new OutlookGridDefaultGroup(null) { OneItemText = "1 call", XXXItemsText = " calls" }, SortOrder.None, -1, -1);
        }
    }
}
