using CallLogTracker.backend.database.wrappers;
using ComponentFactory.Krypton.Navigator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallLogTracker.gui.user_controls
{
    public partial class NewCall : UserControl
    {
        private readonly Call newCall;

        public NewCall()
        {
            InitializeComponent();

            newCall = new Call();
        }

        public NewCall(Call c)
        {
            InitializeComponent();

            if (c != null)
                newCall = c;
        }

        private KryptonPage GetParent()
        {
            return Parent as KryptonPage;
        }

        private void btnSaveAndNotify_Click(object sender, EventArgs e)
        {
            Global.Instance.SelectedPageUniqueName = GetParent().UniqueName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Global.Instance.SelectedPageUniqueName = GetParent().UniqueName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
