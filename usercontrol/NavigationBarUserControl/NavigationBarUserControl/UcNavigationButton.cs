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
        }

        public event EventHandler<ControlClickedEventArgs> ButtonClicked;

        public class ControlClickedEventArgs : EventArgs
        {
            public String ControlToReturn { get; }

            public ControlClickedEventArgs(string Tag)
            {
                ControlToReturn = Tag;
            }
        }

        private void OnAnyClick(object sender, EventArgs e)
        {
            if (ButtonClicked != null && this.Tag != null)
            {
                ButtonClicked(this, new ControlClickedEventArgs(this.Tag.ToString()));
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

        public String getBindedControl()
        {
            return this.Tag.ToString() ;
        }
    }
}
