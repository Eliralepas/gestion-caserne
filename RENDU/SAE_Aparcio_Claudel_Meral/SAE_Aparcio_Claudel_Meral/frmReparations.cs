using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_PanneEngins
{
    public partial class frmReparations: Form
    {
        public frmReparations()
        {
            InitializeComponent();
        }

        public string Reparations
        {
            get { return txtReparations.Text; }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
