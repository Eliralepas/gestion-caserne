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
using UC_Statistique;


namespace Sae25_Main_Form
{
    public partial class frmCaserne : Form
    {
        public frmCaserne()
        {
            InitializeComponent();
        }

        UC_TableauDeBord.TableauDeBord tableauDeBord;
        UCStatistique tabStat;
        SQLiteConnection con;
        DataSet monDs;

        private void frmCaserne_Load(object sender, EventArgs e)
        {
            con = Connexion.Connec; //Récupérer la connexion à la base de données
            monDs = MesDatas.DsGlobal; //Récupérer le DataSet global
            try //Ouvrir la connexion à la base de données
            {
                DataTable schemaTable = con.GetSchema("Tables"); //Récupérer le schéma de la base de données
                foreach (DataRow row in schemaTable.Rows) //Parcourir les lignes du schéma
                {
                    string nomTable = row[2].ToString(); //Récupérer le nom de la table
                    SQLiteDataAdapter da = new SQLiteDataAdapter("Select * From " + nomTable, con); //Créer un adaptateur de données
                    da.Fill(monDs, nomTable); //Remplir le DataSet avec les données de la table
                }
            }
            catch { } //Gérer les exceptions

            //Initialiser les boutons de navigation et définir leurs tags
            btn1.Tag = "tabBord";
            btn1.buttonText = "Tableau de Bord";
            btn2.Tag = "dummy";
            btn3.Tag = "dummy";
            btn4.Tag = "dummy";
            btn5.Tag = "tabStat";

            foreach (UCButton btn in panelNavigation.Controls.OfType<UCButton>()) //Lier les boutons de navigation
            {
                btn.ButtonClicked += NavigationButtonClick; //Lier l'événement de clic du bouton
            }
            panelVolet.Visible = false; //Rendre le panneau de volet invisible au départ
        }

        private void NavigationButtonClick(object sender, EventArgs e)
        {
            panelVolet.Visible = true; //Rendre le panneau de volet visible
            panelVolet.Controls.Clear(); //Vider le panneau de volet avant d'ajouter un nouveau contrôle
            switch (((UCButton)sender).Tag) //Vérifier le tag du bouton cliqué
            {
                case ("tabBord"):
                    LoadTableauDeBord();
                    break;
                case ("tabStat"):
                    LoadStatistique();
                    break;
                
            }
            //*faire la logique de clique une fois que on a tout les volet

        }

        private void LoadTableauDeBord()
        {
            if (tableauDeBord == null) //Si le tableau de bord n'existe pas
            {
                tableauDeBord = new UC_TableauDeBord.TableauDeBord(); //Instancier le volet de tableau de bord
                tableauDeBord.ajouterMissionBD = AjouterMissionBD; //Lier la méthode d'ajout de mission à la base de données
                DataTable dtMissions = CreerTableMission(); //Créer une table de missions au bon format
                RemplirTableMission(dtMissions); //Remplir la table de missions
                tableauDeBord.LoadMissions(dtMissions);
            }
            panelVolet.Controls.Add(tableauDeBord); //Ajouter le tableau de bord au panneau
        }

        private void LoadStatistique()
        {
            if (tabStat == null) //Vérifier si le tableau de statistiques n'existe pas
            {
                tabStat = new UCStatistique(con); //Instancier le volet de statistiques
                tabStat.Dock = DockStyle.Fill;
            }
            panelVolet.Controls.Add(tabStat); //Ajouter le tableau de statistiques au panneau
        }

        private DataTable CreerTableMission()
        {
            if (monDs != null)
            {
                DataTable dtMissions = new DataTable(); //Créer une nouvelle table de données
                for(int i = 0; i < 7; i++)
                {
                    DataColumn column = new DataColumn(); //Créer une nouvelle colonne
                    switch (i)
                    {
                        case 0:
                            column.ColumnName = "MissionID"; //Nom de la colonne
                            column.DataType = typeof(int); //Type de données
                            break;
                        case 1:
                            column.ColumnName = "Caserne";
                            column.DataType = typeof(string);
                            break;
                        case 2:
                            column.ColumnName = "Nature";
                            column.DataType = typeof(string);
                            break;
                        case 3:
                            column.ColumnName = "Motif";
                            column.DataType = typeof(string);
                            break;
                        case 4:
                            column.ColumnName = "DateDebut";
                            column.DataType = typeof(DateTime);
                            break;
                        case 5:
                            column.ColumnName = "DateFin";
                            column.DataType = typeof(DateTime);
                            break;
                        case 6:
                            column.ColumnName = "EstEnCours";
                            column.DataType = typeof(bool);
                            break;
                    }
                    dtMissions.Columns.Add(column); //Ajouter la colonne à la table de données
                }
                return dtMissions; //Retourner la table de données
            }
            return null; //Retourner null si le DataSet est vide
        }

        private void RemplirTableMission(DataTable dtMissions)
        {
            if (monDs != null)
            {
                DataTable dt = monDs.Tables["Mission"]; //Récupérer la table des missions
                foreach (DataRow row in dt.Rows) //Parcourir les lignes de la table
                {
                    DataRow newRow = dtMissions.NewRow(); //Créer une nouvelle ligne
                    //Récupérer l'ID de la mission
                    newRow["MissionID"] = Convert.ToInt32(row["id"]); 
                    //Récupérer la caserne
                    newRow["Caserne"] = monDs.Tables["Caserne"].Select("id = " + row["idCaserne"].ToString());
                    //Récupérer la nature de la mission
                    newRow["Nature"] = monDs.Tables["NatureSinistre"].Select("id = " + row["idNatureSinistre"].ToString());
                    //Récupérer le motif de la mission
                    newRow["Motif"] = row["motifAppel"].ToString();
                    //Récupérer la date de début
                    newRow["DateDebut"] = DateTime.Parse(row["dateHeureDepart"].ToString());
                    //Récupérer la date de fin
                    if (row["dateHeureRetour"] == DBNull.Value) //Vérifier si la date de retour est nulle
                    {
                        newRow["DateFin"] = DBNull.Value; //Mettre la date de fin à null
                    }
                    else
                        newRow["DateFin"] = DateTime.Parse(row["dateHeureRetour"].ToString()); 

                    newRow["EstEnCours"] = Convert.ToInt32(row["terminee"]); //Récupérer l'état de la mission

                    dtMissions.Rows.Add(newRow); //Ajouter la nouvelle ligne à la table de données
                }
            }
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
