using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UC_Mission;

namespace UC_TableauDeBord
{
    public partial class TableauDeBord: UserControl
    {
        public TableauDeBord()
        {
            InitializeComponent();
            listMissions.AddRange(new UC_Mission.Mission[]
            {
                new UC_Mission.Mission(1, "A", "Chépa", "Feur", DateTime.Now, false),
                new UC_Mission.Mission(2, "B", "Chépa", "Feur", DateTime.Now, true),
                new UC_Mission.Mission(3, "C", "Chépa", "Feur", DateTime.Now, true),
                new UC_Mission.Mission(4, "D", "Chépa", "Feur", DateTime.Now, true),
            }); //Ajout des missions à la liste
            DisplayMissions(); //Appel de la méthode pour afficher les missions
        }

        List<UC_Mission.Mission> listMissions = new List<UC_Mission.Mission>(); //Liste des missions
        
        public void LoadMissions(DataTable dt)
        {
            listMissions.Clear(); //Vider la liste avant de la remplir
            foreach (DataRow dr in dt.Rows)
            {
                UC_Mission.Mission mission = new UC_Mission.Mission(dr); //Création d'une nouvelle mission à partir de la ligne du DataTable
                mission.Tag = mission.MissionID; //Ajout de l'ID de la mission dans le tag de la mission
                listMissions.Add(mission); //Ajout de la mission à la liste
            }
            DisplayMissions(); //Appel de la méthode pour afficher les missions
        }

        public void AddMission(UC_Mission.Mission mission)
        {
            listMissions.Add(mission); //Ajout de la mission à la liste
            DisplayMissions(); //Appel de la méthode pour afficher les missions
        }

        public void RemoveMission(UC_Mission.Mission mission)
        {
            listMissions.Remove(mission); //Suppression de la mission de la liste
            DisplayMissions(); //Appel de la méthode pour afficher les missions
        }

        public void DisplayMissions()
        {
            panelMissions.Controls.Clear(); //Vider le panel avant d'ajouter les missions
            int top = 6; //Position en hauteur de la première mission
            int left = 30; //Position en largeur de la première mission
            foreach (UC_Mission.Mission mission in listMissions)
            {
                if (!ckbEnCours.Checked || (ckbEnCours.Checked && mission.EstEnCours)) //Si la checkbox n'est pas cochée, ou que la checkbox est cochée et que la mission est en cours : on affiche la mission
                {
                    mission.Location = new Point(left, top); //Position de la mission
                    panelMissions.Controls.Add(mission); //Ajout de la mission au panel
                    top += mission.Height + 10; //Espace entre les missions
                }
            }
        }

        private void ckbEnCours_CheckedChanged(object sender, EventArgs e)
        {
            DisplayMissions(); //Appel de la méthode pour afficher les missions
        }

        private void btnTerminerMission_Click(object sender, EventArgs e)
        {
            List<int> numeroMissions = new List<int>(); //Liste des numéros de mission
            foreach (UC_Mission.Mission mission in listMissions)
            {
                if (mission.EstEnCours) //Si la mission est en cours
                {
                    numeroMissions.Add(mission.MissionID); //Ajout de l'ID de la mission à la liste
                }
            }
            if (numeroMissions.Count == 0) //Si la liste des missions en cours est vide
            {
                MessageBox.Show("Aucune mission à terminer !"); //Message d'erreur
                return; //Sortir de la méthode
            }
            frmTerminerMission frm = new frmTerminerMission(numeroMissions); //Création d'une nouvelle instance de la fenêtre de terminaison de mission
            if (frm.ShowDialog() == DialogResult.OK) //Affichage de la fenêtre et gestion de la fermeture du formulaire
            {
                int i = 0; //Index de la mission sélectionnée
                int n = listMissions.Count; //Nombre de missions
                int selectedMissionID = frm.SelectedMissionID; //Récupération de l'ID de la mission sélectionnée
                while (i < n && listMissions[i].MissionID != selectedMissionID) //Parcours de la liste des missions pour trouver la mission sélectionnée
                {
                    i++; //Incrémentation de l'index
                }
                if (i < n) //Si la mission a été trouvée
                {
                    UC_Mission.Mission mission = listMissions[i]; //Récupération de la mission sélectionnée
                    mission.EstEnCours = false; //La mission n'est plus en cours, ajout automatique de la date de fin à la mission sélectionnée
                    mission.CompteRendu = frm.CompteRendu; //Ajout du compte rendu à la mission sélectionnée
                }
            }
        }
    }
}
