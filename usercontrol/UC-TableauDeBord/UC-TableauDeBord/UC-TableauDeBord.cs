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

    public delegate void AjouterMissionBD(UC_Mission.Mission mission, string compteRendu); //Déclaration de la signature du délégué pour ajouter une mission à la base de données

    public partial class TableauDeBord: UserControl
    {
        public TableauDeBord()
        {
            InitializeComponent();
            UC_Mission.Mission mission1 = new UC_Mission.Mission(1, "A", "Chépa", "Feur", DateTime.Now, DateTime.Now.AddDays(2));
            UC_Mission.Mission mission2 = new UC_Mission.Mission(2, "B", "Chépa", "Feur", DateTime.Now);
            UC_Mission.Mission mission3 = new UC_Mission.Mission(3, "C", "Chépa", "Feur", DateTime.Now);
            UC_Mission.Mission mission4 = new UC_Mission.Mission(4, "D", "Chépa", "Feur", DateTime.Now);
            AddMission(mission1);
            AddMission(mission2);
            AddMission(mission3);
            AddMission(mission4);
        }

        private List<UC_Mission.Mission> listMissions = new List<UC_Mission.Mission>(); //Liste des missions
        public AjouterMissionBD ajouterMissionBD; //Instance du délégué pour ajouter une mission à la base de données

        public void LoadMissions(DataTable dt)
        {
            listMissions.Clear(); //Vider la liste avant de la remplir
            bool switchCouleur = true; //Variable pour alterner les couleurs des missions
            foreach (DataRow dr in dt.Rows)
            {
                UC_Mission.Mission mission = new UC_Mission.Mission(dr); //Création d'une nouvelle mission à partir de la ligne du DataTable
                switchCouleur = !switchCouleur; //Alterner la couleur
                if (switchCouleur)
                {
                    mission.Couleur = Color.LightGray; //Couleur grise
                }
                mission.terminerMission += TerminerMission; //Ajout de l'événement pour terminer la mission
                listMissions.Add(mission); //Ajout de la mission à la liste
            }
            DisplayMissions(); //Appel de la méthode pour afficher les missions
        }

        public void AddMission(UC_Mission.Mission mission)
        {
            listMissions.Add(mission); //Ajout de la mission à la liste
            mission.terminerMission += TerminerMission; //Ajout de l'événement pour terminer la mission
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

        private void TerminerMission(object sender, EventArgs e, int idMission)
        {
            frmTerminerMission frm = new frmTerminerMission(); //Création d'une nouvelle instance de la fenêtre de terminaison de mission
            if (frm.ShowDialog() == DialogResult.OK) //Affichage de la fenêtre et gestion de la fermeture du formulaire
            {
                UC_Mission.Mission mission = (UC_Mission.Mission)sender; //Récupération de la mission sélectionnée
                mission.Terminer(); //La mission n'est plus en cours, ajout automatique de la date de fin à la mission sélectionnée
                if (ajouterMissionBD != null) //Si le délégué n'est pas nul
                {
                    ajouterMissionBD(mission, frm.CompteRendu); //Appel du délégué pour ajouter la mission à la base de données
                }
                DisplayMissions(); //Appel de la méthode pour afficher les missions
            }
        }
    }
}
