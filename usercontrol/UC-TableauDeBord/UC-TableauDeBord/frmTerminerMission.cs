using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_TableauDeBord
{
    public partial class frmTerminerMission: Form
    {
        public frmTerminerMission()
        {
            InitializeComponent();
        }
        string compteRendu;

        public string CompteRendu
        {
            get {  return compteRendu; }
            set 
            { 
                compteRendu = value;
                txtCompteRendu.Text = value; 
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            compteRendu = txtCompteRendu.Text; //Récupération du compte rendu
            DialogResult = DialogResult.OK; //Fermer la fenêtre avec le résultat OK
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //Fermer la fenêtre avec le résultat Annuler
        }
    }
}
