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
    public partial class button: UserControl
    {
        public button()
        {
            InitializeComponent();
        }

        public delegate  void ClickOnButton(object sender,EventArgs e);

        ClickOnButton ButtonClick;
        

        private void label1_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }

        private void roundedRectangle_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, e);
        }
    }
}
