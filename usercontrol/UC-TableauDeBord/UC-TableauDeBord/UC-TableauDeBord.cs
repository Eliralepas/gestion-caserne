using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_TableauDeBord
{
    public partial class TableauDeBord: UserControl
    {
        public TableauDeBord()
        {
            InitializeComponent();
        }

        List<UC_Mission.Mission> listMissions = new List<UC_Mission.Mission>(); //Liste des missions
        
        public void LoadMissions(DataTable dt)
        {
            listMissions.Clear(); //Vider la liste avant de la remplir
            foreach (DataRow dr in dt.Rows)
            {
                UC_Mission.Mission mission = new UC_Mission.Mission(dr); //Création d'une nouvelle mission à partir de la ligne du DataTable
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
                if (ckbEnCours.Checked && mission.EstEnCours) //Si la checkbox est cochée et que la mission est en cours : on l'affiche
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
    }
}
