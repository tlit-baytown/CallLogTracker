using ComponentFactory.Krypton.Navigator;

namespace CallLogTracker.gui.user_controls
{
    public class ConsolePage : KryptonPage
    {
        public ConsolePage()
        {
            Text = "Console";
            TextTitle = Text;
            UniqueName = "Console";

            ConsoleCtl userCtl = new ConsoleCtl
            {
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            Controls.Add(userCtl);

            ClearFlags(KryptonPageFlags.DockingAllowClose | KryptonPageFlags.DockingAllowFloating);
        }
    }
}
