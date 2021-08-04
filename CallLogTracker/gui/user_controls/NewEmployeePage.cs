using CallLogTracker.backend.database.wrappers;
using ComponentFactory.Krypton.Navigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.gui.user_controls
{
    public class NewEmployeePage : KryptonPage
    {
        public NewEmployeePage()
        {
            Text = "New Employee";
            TextTitle = Text;
            NewEmployee userCtl = new NewEmployee
            {
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            Controls.Add(userCtl);
        }

        public NewEmployeePage(User u)
        {
            Text = $"Edit Employee [{u.Name}]";
            TextTitle = Text;
            NewEmployee userCtl = new NewEmployee(u)
            {
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            Controls.Add(userCtl);
        }
    }
}
