using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationBarUserControl
{
    public partial class UCButton: UserControl
    {


        public UCButton()
        {
            InitializeComponent();
        }

        private Control _ucControled;
        public Control UcControled
        {
            get { return _ucControled; }
            set { _ucControled = value; }
        }

        private String _strText;
        public String buttonText{
            get { return _strText; }
            set { _strText = value;
                label1.Text = value;
            }

            }


        public UCButton(string str, Image img, Control binder)
        {
            InitializeComponent(); 
            label1.Text = str;
            pictureBox1.Image = img;
            UcControled = binder;
        }

        public event EventHandler<ControlClickedEventArgs> ButtonClicked;

        public class ControlClickedEventArgs : EventArgs
        {
            public Control ControlToReturn { get; }

            public ControlClickedEventArgs(Control control)
            {
                ControlToReturn = control;
            }
        }

        private void OnAnyClick(object sender, EventArgs e)
        {
            if (ButtonClicked != null)
            {
                ButtonClicked(this, new ControlClickedEventArgs(UcControled));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OnAnyClick(sender, e);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnAnyClick(sender, e);
        }
        private void roundedRectangle_Click(object sender, EventArgs e)
        {
            OnAnyClick(sender, e);
        }

        public Control getBindedControl()
        {
            return UcControled;
        }
    }
}
