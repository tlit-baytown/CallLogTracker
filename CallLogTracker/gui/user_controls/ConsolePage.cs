using ComponentFactory.Krypton.Navigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
