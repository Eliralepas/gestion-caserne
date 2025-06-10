using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygon
{
    public partial class ButtonRounded : RoundedRectangle
    {
        public ButtonRounded():base()
        {
            InitializeComponent();
        }
        public ButtonRounded(int[] pos, Size size, int quality) : base(pos, size, quality)
        {
            InitializeComponent();
        }


    }
}
