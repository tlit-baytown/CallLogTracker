using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CallLogTracker.utility
{
    public class TextBoxWriter : TextWriter
    {
        // The control where we will write text.
        private Control TextControl;

        public TextBoxWriter(Control control)
        {
            TextControl = control;
        }

        public override void Write(char value)
        {
            TextControl.Text += value;
        }

        public override void Write(string value)
        {
            TextControl.Text += value;
        }

        public override Encoding Encoding
        {
            get { return Encoding.Unicode; }
        }
    }
}
