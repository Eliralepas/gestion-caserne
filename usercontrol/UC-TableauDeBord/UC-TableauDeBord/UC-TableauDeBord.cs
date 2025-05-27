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

    public delegate void AjouterMissionBD(Mission mission, string compteRendu, DataTable enginsEnPanne); //Déclaration de la signature du délégué pour ajouter une mission à la base de données
    public delegate DataTable GetEnginsMission(int idMission); //Déclaration de la signature du délégué pour récupérer les engins d'une mission

    public partial class TableauDeBord: UserControl
    {
        public TableauDeBord()
        {
            InitializeComponent();
        }

        private List<Mission> listMissions = new List<Mission>();       //Liste des missions
        public AjouterMissionBD ajouterMissionBD;                       //Instance du délégué pour ajouter une mission à la base de données
        public GetEnginsMission getEnginsMission;                       //Instance du délégué pour récupérer les engins d'une mission
        private bool switchCouleur = true;                              //Variable pour alterner les couleurs des missions
        private Color couleurSecondaire = Color.FromArgb(234,234,234);  //Couleur grise pour les missions

        public void LoadMissions(DataTable dt)
        {
            listMissions.Clear(); //Vider la liste avant de la remplir
            foreach (DataRow dr in dt.Rows)
            {
                Mission mission = new Mission(dr);              //Création d'une nouvelle mission à partir de la ligne du DataTable
                switchCouleurMission(mission);                  //Appel de la méthode pour alterner la couleur de la mission
                mission.terminerMission += TerminerMission;     //Ajout de l'événement pour terminer la mission
                listMissions.Add(mission);                      //Ajout de la mission à la liste
            }
            TriParIdDecroissant(listMissions); //Tri des missions par ID décroissant
            DisplayMissions(); //Appel de la méthode pour afficher les missions
        }

        public void AddMission(Mission mission)
        {
            listMissions.Insert(0, mission);            //Ajout de la mission au début de la liste
            switchCouleurMission(mission);              //Appel de la méthode pour alterner la couleur de la mission
            mission.terminerMission += TerminerMission; //Ajout de l'événement pour terminer la mission
            DisplayMissions();                          //Appel de la méthode pour afficher les missions
        }

        public void RemoveMission(Mission mission)
        {
            listMissions.Remove(mission);   //Suppression de la mission de la liste
            DisplayMissions();              //Appel de la méthode pour afficher les missions
        }

        private void TriParIdDecroissant(List<Mission> missions)
        {
            missions.Sort((x, y) => y.MissionID.CompareTo(x.MissionID)); //Tri des missions par ID décroissant
        }

        public void DisplayMissions()
        {
            panelMissions.Controls.Clear(); //Vider le panel avant d'ajouter les missions
            int top = 6;                    //Position en hauteur de la première mission
            int left = 30;                  //Position en largeur de la première mission
            foreach (Mission mission in listMissions)
            {
                if (!sckbEnCours.Checked || (sckbEnCours.Checked && mission.EstEnCours)) //Si la checkbox n'est pas cochée, ou que la checkbox est cochée et que la mission est en cours : on affiche la mission
                {
                    mission.Location = new Point(left, top);    //Position de la mission
                    panelMissions.Controls.Add(mission);        //Ajout de la mission au panel
                    top += mission.Height + 10;                 //Espace entre les missions
                }
            }
        }

        private void TerminerMission(object sender, EventArgs e, int idMission)
        {
            frmCompteRendu frm = new frmCompteRendu();  //Création d'une nouvelle instance de la fenêtre de terminaison de mission
            if (frm.ShowDialog() == DialogResult.OK)    //Affichage de la fenêtre et gestion de la fermeture du formulaire
            {
                Mission mission = (Mission)sender;  //Récupération de la mission sélectionnée
                mission.Terminer();                 //La mission n'est plus en cours, ajout automatique de la date de fin à la mission sélectionnée
                if (ajouterMissionBD != null)       //Si le délégué n'est pas nul
                {
                    DataTable engins = getEngins(idMission);            //Récupération des engins
                    ajouterMissionBD(mission, frm.CompteRendu, engins); //Appel du délégué pour ajouter la mission à la base de données
                }
                DisplayMissions(); //Appel de la méthode pour afficher les missions
            }
        }

        private DataTable getEngins(int idMission)
        {
            DataTable engins = new DataTable();         //Création d'un DataTable pour stocker les engins de la mission
            frmPanneEngins frm = new frmPanneEngins();  //Création d'une nouvelle instance de la fenêtre de panne d'engins
            frm.Remplir(getEnginsMission(idMission));   //Remplissage de la fenêtre avec les engins de la mission
            if (frm.ShowDialog() == DialogResult.OK)    //Affichage de la fenêtre et gestion de la fermeture du formulaire
            {
                //Récupération des engins sélectionnés dans le formulaire
                engins = frm.getEngins(); //Appel de la méthode pour récupérer les engins en panne
            }
            return engins; //Retourne le DataTable
        }

        private void switchCouleurMission(Mission mission)
        {
            switchCouleur = !switchCouleur; //Alterner la couleur
            if (switchCouleur)
            {
                mission.Couleur = couleurSecondaire; //Couleur grise
            }
        }

        private void sckbEnCours_CheckedChanged(object sender, EventArgs e)
        {
            DisplayMissions(); //Appel de la méthode pour afficher les missions
        }
    }
}
