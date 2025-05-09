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
            //Ne pas oublier de bind tout les Controller a leur bouton

            btn1.UcControled = Tablodebord;
            
            foreach (UCButton btn in grpNavigation.Controls.OfType<UCButton>())
            {
                btn.ButtonClicked += NavigationButtonClick;
                btn.getBindedControl();
            }
        }

        private void NavigationButtonClick(object sender, EventArgs e)
        {
            //*faire la logique de clique une fois que on a tout les volet

        }

        private void Tablodebord_Load(object sender, EventArgs e)
        {

        }
    }
}
