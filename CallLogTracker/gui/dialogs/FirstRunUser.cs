using CallLogTracker.gui.user_controls;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;
using static CallLogTracker.utility.CEventArgs;

namespace CallLogTracker.gui.dialogs
{
    public partial class FirstRunUser : KryptonForm
    {
        public EventHandler UserCreated;

        public FirstRunUser()
        {
            InitializeComponent();
        }

        private void FirstRunUser_Load(object sender, EventArgs e)
        {
            NewEmployee ctl = new NewEmployee();
            ctl.Dock = DockStyle.Fill;
            Controls.Add(ctl);
            ctl.UserCreated += OnUserCreate;
        }

        private void OnUserCreate(object sender, EventArgs e)
        {
            if (e is UserCreatedEventArgs args)
            {
                UserCreated?.Invoke(this, args);
            }
        }
    }
}
