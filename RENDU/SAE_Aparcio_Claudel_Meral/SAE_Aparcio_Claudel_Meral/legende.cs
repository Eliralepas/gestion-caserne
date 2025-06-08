using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_Statistique
{
    public partial class legende : UserControl
    {
        public legende()
        {
            InitializeComponent();
        }

        public legende(string value,Color color) : this()
        {
            rctColor.m_BackGroundColor = color;
            lblLegende.Text = value;
            this.Width = lblLegende.Width+rctColor.Width+20;
        }
        private void legende_Load(object sender, EventArgs e)
        {
            this.Width = lblLegende.Width + rctColor.Width + 20;
        }
    }
}
