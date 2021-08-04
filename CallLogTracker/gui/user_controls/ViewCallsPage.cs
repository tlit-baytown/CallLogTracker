using ComponentFactory.Krypton.Navigator;

namespace CallLogTracker.gui.user_controls
{
    public class ViewCallsPage : KryptonPage
    {
        ViewCallsCtl userCtl;
        public ViewCallsPage()
        {
            Text = "Calls";
            TextTitle = Text;
            UniqueName = "CallsPage";

            userCtl = new ViewCallsCtl
            {
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            Controls.Add(userCtl);

            ClearFlags(KryptonPageFlags.DockingAllowClose | KryptonPageFlags.DockingAllowFloating);
        }

        public void UpdateCalls()
        {
            userCtl.UpdateCalls();
        }
    }
}
