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
        public frmTerminerMission(List<int> lst)
        {
            InitializeComponent();
            LoadComboBox(lst); //Chargement de la liste des missions dans le combobox de la fenêtre
        }

        int selectedMissionID;
        string compteRendu;

        public void LoadComboBox(List<int> lst)
        {
            foreach (int i in lst)
            {
                cboMissionId.Items.Add(i);
            }
        }

        public int SelectedMissionID
        {
            get { return selectedMissionID; }
            set
            {
                selectedMissionID = value;
                if (!cboMissionId.Items.Contains(value))
                {
                   cboMissionId.Items.Add(value);
                }
                cboMissionId.SelectedItem = value;
            }
        }

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
            selectedMissionID = Convert.ToInt32(cboMissionId.SelectedItem); //Récupération de l'ID de la mission sélectionnée
            compteRendu = txtCompteRendu.Text; //Récupération du compte rendu
            DialogResult = DialogResult.OK; //Fermer la fenêtre avec le résultat OK
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //Fermer la fenêtre avec le résultat Annuler
        }
    }
}
