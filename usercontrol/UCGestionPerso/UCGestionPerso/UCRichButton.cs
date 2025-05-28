using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCGestionPerso
{
    public delegate void ClickedWithTagHandler(UCRichButton me,object tag);

    public partial class UCRichButton : UserControl
    {
        public event ClickedWithTagHandler clickReturnTag;

        private bool _selected = false;
        public bool isSelected { set { _selected = value; } }

        public UCRichButton()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }

        public UCRichButton(string inf01) : this()
        {
            lblInfo1.Text = inf01;
            this.Controls.Remove(pictureBox1);
            this.Controls.Remove(lblInfo2);
            lblInfo1.Left = 10;
            this.Width = 200;
            this.Height = 80;
            lblInfo1.Top = 80 / 2 - lblInfo1.Height + 2;
        }

        public UCRichButton(string inf01, string inf02) : this()
        {
            lblInfo1.Text = inf01;
            lblInfo2.Text = inf02;
            this.Controls.Remove(pictureBox1);
            lblInfo1.Left = 10;
            lblInfo2.Left = lblInfo1.Left;
            this.Width = 175;
        }

        public UCRichButton(string inf01, string inf02, Image img) : this()
        {
            lblInfo1.Text = inf01;
            lblInfo2.Text = inf02;
            pictureBox1.Image = img;
        }

        private void UCRichButton_Load(object sender, EventArgs e)
        {
        }

        private void UCRichButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void UCRichButton_MouseLeave(object sender, EventArgs e)
        {

            if(!_selected)
            {

             this.BackColor = Color.White;
            }
        }

        private void RichButton_MouseClick(object sender, MouseEventArgs e)
        {
            clickReturnTag(this,this.Tag);
        }
    }
}
