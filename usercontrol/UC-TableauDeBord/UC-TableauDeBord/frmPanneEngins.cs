using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UC_Mission;
using UC_PanneEngins;

namespace UC_TableauDeBord
{
    public partial class frmPanneEngins: Form
    {

        public frmPanneEngins()
        {
            InitializeComponent();
        }

        public void Remplir(DataTable dt)
        {
            int top = 6;    // Position en hauteur du premier élément
            int left = 30;  // Position en largeur de l'élément
            foreach (DataRow dr in dt.Rows)
            {
                PanneEngins engin = new PanneEngins(dr);    // Création d'un nouveau user control PanneEngin à partir de la ligne du DataTable
                engin.Location = new Point(left, top);      // Position de la mission
                top += engin.Height + 10;                   // Espace entre les missions
                panelEngins.Controls.Add(engin);            // Ajout de chaque engin à la liste
            }
        }

        public DataTable getEngins()
        {
            // Création d'un DataTable pour stocker les engins en panne
            DataTable dt = new DataTable();
            dt.Columns.Add("Type", typeof(string));         // Ajout de la colonne type
            dt.Columns.Add("Numero", typeof(int));          // Ajout de la colonne numero
            dt.Columns.Add("EnPanne", typeof(bool));        // Ajout de la colonne en panne
            dt.Columns.Add("Reparations", typeof(string));  // Ajout de la colonne réparations
            foreach (PanneEngins engin in panelEngins.Controls.OfType<PanneEngins>())
            {
                dt.Rows.Add(engin.Type, engin.Numero, engin.EnPanne, engin.Reparations); // Ajout de la ligne avec le type, le numero, le statut en panne de l'engin et les réparations éventuelles
            }
            return dt; // Retourne le DataTable
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; // Fermer la fenêtre avec le résultat OK
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Fermer la fenêtre avec le résultat Annuler
        }
    }
}
