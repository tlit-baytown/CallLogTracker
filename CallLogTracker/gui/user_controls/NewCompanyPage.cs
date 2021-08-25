using CallLogTracker.backend.database.wrappers;
using ComponentFactory.Krypton.Navigator;

namespace CallLogTracker.gui.user_controls
{
    public class NewCompanyPage : KryptonPage
    {
        public NewCompanyPage()
        {
            Text = "New Company";
            TextTitle = Text;
            NewCompany userCtl = new NewCompany
            {
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            Controls.Add(userCtl);
        }

        public NewCompanyPage(Company c)
        {
            Text = $"Edit Company [{c.Name}]";
            TextTitle = Text;
            NewCompany userCtl = new NewCompany(c)
            {
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            Controls.Add(userCtl);
        }
    }
}
