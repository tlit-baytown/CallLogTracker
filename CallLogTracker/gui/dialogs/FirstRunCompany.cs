using CallLogTracker.gui.user_controls;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CallLogTracker.utility.CEventArgs;

namespace CallLogTracker.gui.dialogs
{
    public partial class FirstRunCompany : KryptonForm
    {
        public EventHandler CompanyCreated;

        public FirstRunCompany()
        {
            InitializeComponent();
        }

        private void FirstRunCompany_Load(object sender, EventArgs e)
        {
            NewCompany ctl = new NewCompany();
            ctl.Dock = DockStyle.Fill;
            Controls.Add(ctl);
            ctl.CompanyCreated += OnCompanyCreate;
        }

        private void OnCompanyCreate(object sender, EventArgs e)
        {
            if (e is CompanyCreatedEventArgs args)
            {
                CompanyCreated?.Invoke(this, args);
            }
        }
    }
}
