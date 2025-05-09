using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sae25_Main_Form
{
    public partial class frmCaserne : Form
    {
        public frmCaserne()
        {
            InitializeComponent();
        }

        private void frmCaserne_Load(object sender, EventArgs e)
        {
            
            foreach (Button btn in grpNavigation.Controls.OfType<Button>())
            {
                btn.Click = MenuClickButon();
            }
        }


    }
}
