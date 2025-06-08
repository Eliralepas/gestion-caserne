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
using UC_Mission;
using System.Net;
using System.Reflection;
using UCGestionEngins;


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
        UCGestionPerso.UCGestionPerso perso;
        SQLiteConnection con;
        DataSet monDs;
        private void frmCaserne_Load(object sender, EventArgs e)
        {
            con = Connexion.Connec;     //Récupérer la connexion à la base de données
            monDs = MesDatas.DsGlobal;  //Récupérer le DataSet global
            try
            {
                DataTable schemaTable = con.GetSchema("Tables");    //Récupérer le schéma de la base de données
                foreach (DataRow row in schemaTable.Rows)           //Parcourir les lignes du schéma
                {
                    string nomTable = row[2].ToString();                                                //Récupérer le nom de la table
                    SQLiteDataAdapter da = new SQLiteDataAdapter("Select * From " + nomTable, con);     //Créer un adaptateur de données
                    da.Fill(monDs, nomTable);                                                           //Remplir le DataSet avec les données de la table
                }
            }
            catch { } //Gérer les exceptions
            finally
            {
                con.Close();
            }

            //Initialiser les boutons de navigation et définir leurs tags
            btn1.Tag = "tabBord";
            btn1.buttonText = "Tableau de Bord";
            btn2.Tag = "dummy";
            btn3.Tag = "engins";
            btn4.Tag = "perso";
            btn5.Tag = "tabStat";

            foreach (UCButton btn in panelNavigation.Controls.OfType<UCButton>())   //Lier les boutons de navigation
            {
                btn.ButtonClicked += NavigationButtonClick;                         //Lier l'événement de clic du bouton
            }
            panelVolet.Visible = false;                                             //Rendre le panneau de volet invisible au départ
        }

        private void NavigationButtonClick(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open) //Vérifier si la connexion est ouverte
            {
                con.Close(); //Fermer la connexion
            }
            panelVolet.Visible = true;          //Rendre le panneau de volet visible
            panelVolet.Controls.Clear();        //Vider le panneau de volet avant d'ajouter un nouveau contrôle
            switch (((UCButton)sender).Tag)     //Vérifier le tag du bouton cliqué
            {
                case ("tabBord"):
                    LoadTableauDeBord();
                    break;
                case ("tabStat"):
                    LoadStatistique();
                    break;
                case ("engins"):
                    LoadEngins();
                    break;
                case ("perso"):
                    LoadPerso();
                    break;
                
            }
        }

        private void LoadTableauDeBord()
        {
            if (tableauDeBord == null) //Si le tableau de bord n'existe pas
            {
                tableauDeBord = new UC_TableauDeBord.TableauDeBord();   //Instancier le volet de tableau de bord
                tableauDeBord.ajouterMissionBD = AjouterMissionBD;      //Lier la méthode d'ajout de mission à la base de données
                tableauDeBord.getEnginsMission = getEnginsMission;      //Lier la méthode de récupération des engins de la mission
                DataTable dtMissions = CreerTableMission();             //Créer une table de missions au bon format
                RemplirTableMission(dtMissions);                        //Remplir la table de missions
                tableauDeBord.LoadMissions(dtMissions);
            }
            panelVolet.Controls.Add(tableauDeBord); //Ajouter le tableau de bord au panneau
        }



        private void LoadPerso()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            if(perso == null)
            {
                perso = new UCGestionPerso.UCGestionPerso(con);
                perso.Dock = DockStyle.Fill;
            }
            panelVolet.Controls.Add(perso);
        }
        private void LoadStatistique()
        {
            con.Open(); //Ouvrir la connexion à la base de données
            if (tabStat == null) //Vérifier si le tableau de statistiques n'existe pas
            {   
                tabStat = new UCStatistique(con);   //Instancier le volet de statistiques
                tabStat.Dock = DockStyle.Fill;
            }
            panelVolet.Controls.Add(tabStat);       //Ajouter le tableau de statistiques au panneau
        }

        private void LoadEngins()
        {
            UCGestionEngin uc = new UCGestionEngin(monDs);
            uc.Dock = DockStyle.Fill;

            panelVolet.Controls.Add(uc);
        }


        private DataTable CreerTableMission()
        {
            if (monDs != null)
            {
                DataTable dtMissions = new DataTable();         //Créer une nouvelle table de données
                for(int i = 0; i < 7; i++)
                {
                 
                    DataColumn column = new DataColumn();       //Créer une nouvelle colonne
                    switch (i)
                    {
                        case 0:
                            column.ColumnName = "MissionID";    //Nom de la colonne
                            column.DataType = typeof(int);      //Type de données
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
                DataTable dt = monDs.Tables["Mission"];     //Récupérer la table des missions
                foreach (DataRow row in dt.Rows)            //Parcourir les lignes de la table
                {
                    DataRow newRow = dtMissions.NewRow();   //Créer une nouvelle ligne
                    //Récupérer l'ID de la mission
                    newRow["MissionID"] = Convert.ToInt32(row["id"]); 
                    //Récupérer le nom de la caserne
                    newRow["Caserne"] = monDs.Tables["Caserne"].Select("id = " + row["idCaserne"].ToString())[0]["nom"].ToString();
                    //Récupérer le nom de la nature de la mission
                    newRow["Nature"] = monDs.Tables["NatureSinistre"].Select("id = " + row["idNatureSinistre"].ToString())[0]["libelle"].ToString();
                    //Récupérer le motif de la mission
                    newRow["Motif"] = row["motifAppel"].ToString();
                    //Récupérer la date de début
                    newRow["DateDebut"] = DateTime.Parse(row["dateHeureDepart"].ToString());
                    //Récupérer la date de fin
                    if (row["dateHeureRetour"] == DBNull.Value)     //Vérifier si la date de retour est nulle
                    {
                        newRow["DateFin"] = DBNull.Value;           //Mettre la date de fin à null
                    }
                    else
                    {
                        newRow["DateFin"] = DateTime.Parse(row["dateHeureRetour"].ToString());
                    }
                    newRow["EstEnCours"] = !Convert.ToBoolean(row["terminee"]); //Récupérer l'état de la mission

                    dtMissions.Rows.Add(newRow); //Ajouter la nouvelle ligne à la table de données
                }
            }
        }

        private DataTable getEnginsMission(int idMission)
        {
            if (monDs != null)
            {
                DataTable dt = monDs.Tables["PartirAvec"];              //Récupérer la table des engins
                DataTable dtEnginsMission = dt.Clone();                 //Cloner la structure de la table des engins
                foreach (DataRow row in dt.Rows)                        //Parcourir les lignes de la table des engins
                {
                    if (Convert.ToInt32(row["idMission"]) == idMission) //Vérifier si l'ID de la mission correspond
                    {
                        dtEnginsMission.ImportRow(row);                 //Importer la ligne dans la nouvelle table
                    }
                }
                return dtEnginsMission; //Retourner la table des engins de la mission
            }
            return null; //Retourner null si le DataSet est vide
        }

        private void AjouterMissionBD(Mission mission, string compteRendu, DataTable engins)
        {
            string requete = "";                //Initialiser la requête SQL
            int idMission = mission.MissionID;  //Récupérer l'ID de la mission
            //Vérifier si la mission existe déjà
            if (monDs.Tables["Mission"].Select("id = " + idMission.ToString()).Length > 0)
            {
                requete = UpdateMission(mission, compteRendu);      //Appeler la méthode de mise à jour de mission
            }
            else 
            {
                requete = InsertionMission(mission, compteRendu);   //Appeler la méthode d'insertion de mission
            }
            try
            {
                con.Open();                                                     //Ouvrir la connexion à la base de données
                SQLiteCommand cmdMission = new SQLiteCommand(requete, con);     //Définir la commande SQL
                MessageBox.Show(requete);                                       //Afficher la requête SQL                                                                      
                cmdMission.ExecuteNonQuery();                                   //Insertion de la mission dans la table des missions
                //Récupérer la commande pour mettre à jour le statut "En panne" et "En mission" de chaque engin faisant partie de la mission
                UpdateStatutEnginsMission(idMission, engins);
                //Mettre à jour le statut "En mission" de chaque pompier faisant partie de la mission
                UpdateStatutPompiersMission(idMission);
                con.Close();                                                    //Fermer la connexion à la base de données
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout ou de la mise à jour de la mission dans la base de données"); //Afficher un message d'erreur
                MessageBox.Show(ex.ToString()); //Afficher l'erreur
            }
        }

        private string InsertionMission(Mission mission, string compteRendu)
        {
            // Logique pour ajouter une mission à la base de données
            int idMission = mission.MissionID; //Récupérer l'ID de la mission
            MessageBox.Show("Mission ajoutée à la base de données : Mission n°" + idMission + "\nCompte rendu: " + compteRendu); //Afficher un message de confirmation
            //Récupération des informations de la mission
            DataRow drMission = monDs.Tables["Mission"].Select("id = " + idMission.ToString())[0];  //Récupérer la ligne de la mission dans le DataSet local
            string AdresseMission = drMission["adresse"].ToString();                                //Récupération de l'adresse de la mission dans le DataSet local
            string CodePostalMission = drMission["cp"].ToString();                                  //Récupération du code postal de la mission dans le DataSet local
            string VilleMission = drMission["ville"].ToString();                                    //Récupération de la ville de la mission dans le DataSet local
            int IdNatureSinistre = Convert.ToInt32(drMission["idNatureSinistre"]);                  //Récupération de l'id du sinistre dans le DataSet local
            int IdCaserne = Convert.ToInt32(drMission["idCaserne"]);                                //Récupération de l'id de la caserne de la mission dans le DataSet local
            //Echappement de l'apostrophe
            mission.MotifMission = mission.MotifMission.Replace("'", " ");  //Remplacer les apostrophes par des espaces
            AdresseMission = AdresseMission.Replace("'", " ");              //Remplacer les apostrophes par des espaces
            compteRendu = compteRendu.Replace("'", " ");                    //Remplacer les apostrophes par des espaces

            //Renvoyer la requête SQL pour insérer la mission
            return "INSERT INTO Mission (id, dateHeureDepart, dateHeureRetour, motifAppel, adresse, cp, ville, terminee, compteRendu, idNatureSinistre, idCaserne)" +
                " VALUES " +
                "(" + idMission.ToString() + ",'" + mission.DateDebut + "','" + mission.DateFin + "','" + mission.MotifMission + "','" + AdresseMission +
                "','" + CodePostalMission + "','" + VilleMission + "', 1,'" + compteRendu + "'," + IdNatureSinistre.ToString() + "," + IdCaserne.ToString() + ");";
        }

        private string UpdateMission(Mission mission, string compteRendu)
        {
            MessageBox.Show("La mission existe déjà dans la base de données"); //Afficher le message
            //Renvoyer la requête SQL pour mettre à jour la mission
            return "UPDATE Mission SET dateHeureRetour = '" + mission.DateFin + "', terminee = 1, compteRendu = '" + compteRendu + "' " +
                    "WHERE id = " + mission.MissionID.ToString() + ";"; 
        }

        private void UpdateStatutEnginsMission(int idMission, DataTable engins)
        {
            //Mettre à jour le statut "En panne" et "En mission" de chaque engin faisant partie de la mission
            foreach(DataRow row in engins.Rows) {
                string codeTypeEngin = row["Type"].ToString();  //Récupérer le code type de l'engin
                int numero = Convert.ToInt32(row["Numero"]);    //Récupérer le numero de l'engin
                int enPanne = Convert.ToInt32(row["enPanne"]);  //Récupérer le statut "En panne" de l'engin
                SQLiteCommand cmdEngin = new SQLiteCommand("UPDATE Engin SET enPanne = " + enPanne + ", enMission = 0 WHERE codeTypeEngin = " + codeTypeEngin + " AND numero = " + numero + ";", con);
                cmdEngin.ExecuteNonQuery(); //Exécuter la commande SQL
            }
        }

        private void UpdateStatutPompiersMission(int idMission)
        {
            //Mettre à jour le statut "En mission" de chaque pompier faisant partie de la mission
            foreach(DataRow row in monDs.Tables["Mobiliser"].Rows) //Parcourir les lignes de la table "Mobiliser"
            {
                if (Convert.ToInt32(row["idMission"]) == idMission) //Vérifier si l'ID de la mission correspond
                {
                    int matriculePompier = Convert.ToInt32(row["matriculePompier"]); //Récupérer le matricule du pompier
                    SQLiteCommand cmdPompier = new SQLiteCommand("UPDATE Pompier SET enMission = 0 WHERE matricule = " + matriculePompier + ";", con);
                    cmdPompier.ExecuteNonQuery(); //Exécuter la commande SQL
                }
            }
        }
    }
}
