using CallLogTracker.backend.database.wrappers;
using ComponentFactory.Krypton.Navigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.gui.user_controls
{
    public class NewCallPage : KryptonPage
    {
        public NewCallPage()
        {
            Text = "Record New Call";
            TextTitle = Text;
            NewCall userCtl = new NewCall
            {
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            Controls.Add(userCtl);
        }

        public NewCallPage(Call c)
        {
            Text = $"Edit Call [{c.ID}.{c.UserID}.{c.CompanyID}]";
            TextTitle = Text;
            NewCall userCtl = new NewCall(c)
            {
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            Controls.Add(userCtl);
        }
    }
}
