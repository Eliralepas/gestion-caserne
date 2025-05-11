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
using System.Data.SQLite;

namespace Sae25_Main_Form
{
    public partial class frmCaserne : Form
    {
        public frmCaserne()
        {
            InitializeComponent();
        }

        UC_TableauDeBord.TableauDeBord tableauDeBord;

        private void frmCaserne_Load(object sender, EventArgs e)
        {
            foreach (UCButton btn in panelNavigation.Controls.OfType<UCButton>()) //Lier les boutons de navigation
            {
                btn.ButtonClicked += NavigationButtonClick; //Lier l'événement de clic du bouton
                btn.getBindedControl(); //Lier le bouton à son contrôleur
            }
            //Test du TableauDeBord --A SUPPRIMER PLUS TARD--
            LoadTableauDeBord(); //Charger le tableau de bord par défaut
        }

        private void NavigationButtonClick(object sender, EventArgs e)
        {
            //*faire la logique de clique une fois que on a tout les volet

        }

        private void LoadTableauDeBord()
        {
            tableauDeBord = new UC_TableauDeBord.TableauDeBord(); //Instancier le volet de tableau de bord
            tableauDeBord.ajouterMissionBD = AjouterMissionBD; //Lier la méthode d'ajout de mission à la base de données
            //tableauDeBord.LoadMissions(DataTable locale des missions qui regroupe les missions de la base et celles du DataSet local)
            panelVolet.Controls.Add(tableauDeBord); //Ajouter le nouveau contrôle au panneau
        }

        private void AjouterMissionBD(UC_Mission.Mission mission, string compteRendu)
        {
            // Logique pour ajouter une mission à la base de données
            MessageBox.Show("Mission ajoutée à la base de données : Mission n°" + mission.MissionID + "\nCompte rendu: " + compteRendu); //Afficher un message de confirmation
            /* Pseudo code pour insérer la mission dans la base de données
            Début
                Connexion à la base de données
                AdresseMission = (récupération de l'adresse de la mission dans le DataSet local);
                CodePostalMission = (récupération du code postal de la mission dans le DataSet local);
                VilleMission = (récupération de la ville de la mission dans le DataSet local);
                IdNatureSinistre = (récupération de l'id du sinistre dans le DataSet local);
                IdCaserne = (récupération de l'id de la caserne de la mission dans le DataSet local);
                Création d'une commande SQL pour insérer la mission:
                "INSERT INTO Missions VALUES (mission.MissionID, mission.DateDebut, mission.DateFin, mission.MotifMission, AdresseMission, CodePostalMission, VilleMission, mission.EstEnCours, IdNatureSinistre, IdCaserne);"
                Insertion de la mission dans la table des missions
                Supprimer la mission du dataset local
            Fin
            */
        }
    }
}
