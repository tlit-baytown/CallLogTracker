using System;
using System.Windows.Forms;

namespace CallLogTracker.gui.user_controls
{
    public partial class ConsoleCtl : UserControl
    {
        public ConsoleCtl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add an entry to the console log. This is a simple logging entry where the date is inserted automatically.
        /// </summary>
        /// <param name="logEntry">The log entry (without a date).</param>
        public void AddEntry(string logEntry)
        {
            lbConsole.Items.Add($"{DateTime.Now.ToLocalTime()} -> {logEntry}");
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> {logEntry}");
        }
    }
}
