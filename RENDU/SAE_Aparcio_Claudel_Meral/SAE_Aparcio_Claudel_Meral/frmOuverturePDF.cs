using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_Mission
{
    public partial class frmOuverturePDF : Form
    {
        public frmOuverturePDF()
        {
            InitializeComponent();
        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; // On retourne OK pour indiquer que l'utilisateur a cliqué sur Oui
            Close(); // On ferme la fenêtre de confirmation
        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // On retourne Cancel pour indiquer que l'utilisateur a cliqué sur Non
            Close(); // On ferme la fenêtre de confirmation
        }
    }
}
