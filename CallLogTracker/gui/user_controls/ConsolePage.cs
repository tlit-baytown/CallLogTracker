using ComponentFactory.Krypton.Navigator;

namespace CallLogTracker.gui.user_controls
{
    public class ConsolePage : KryptonPage
    {
        private ConsoleCtl userCtl;

        public ConsolePage()
        {
            Text = "Console";
            TextTitle = Text;
            UniqueName = "Console";

            userCtl = new ConsoleCtl
            {
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            Controls.Add(userCtl);

            ClearFlags(KryptonPageFlags.DockingAllowClose | KryptonPageFlags.DockingAllowFloating);
        }

        public ConsoleCtl GetConsole()
        {
            return userCtl;
        }
    }
}
