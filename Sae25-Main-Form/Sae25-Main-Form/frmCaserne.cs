using NavigationBarUserControl;
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
            
            foreach (button btn in grpNavigation.Controls.OfType<button>())
            {
                btn.ButtonClicked += NavigationButtonClick;
            }
        }

        private void NavigationButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show($"Le bounton {(button)sender.UcControled} a étais cliquer");
        }


    }
}
