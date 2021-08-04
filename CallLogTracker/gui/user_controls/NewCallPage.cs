using CallLogTracker.backend.database.wrappers;
using ComponentFactory.Krypton.Navigator;

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
