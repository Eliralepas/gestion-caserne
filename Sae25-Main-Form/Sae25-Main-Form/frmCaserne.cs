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

        private UserControl voletActuel;

        private void frmCaserne_Load(object sender, EventArgs e)
        {
            foreach (UCButton btn in panelNavigation.Controls.OfType<UCButton>()) //Lier les boutons de navigation
            {
                btn.ButtonClicked += NavigationButtonClick; //Lier l'événement de clic du bouton
                btn.getBindedControl(); //Lier le bouton à son contrôleur
            }
        }

        private void NavigationButtonClick(object sender, EventArgs e)
        {
            //*faire la logique de clique une fois que on a tout les volet

        }

        private void TableauDeBord_Load(object sender, EventArgs e)
        {
            panelVolet.Controls.
        }
    }
}
