using UC_Bouton;
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
using UC_TableauDeBord;
using UC_Statistique;
using UC_Mission;
using System.Net;
using System.Reflection;
using UC_GestionEngins;
using UC_AjoutMissions;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.pdf.draw;
using Org.BouncyCastle.Asn1.IsisMtt.X509;
using System.Xml.Linq;
using System.Diagnostics;
using Org.BouncyCastle.Asn1.Ocsp;
using SAE_Aparcio_Claudel_Meral.Properties;
using SAE_Aparcio_Claudel_Meral;
using UC_GestionPerso;


namespace SAE_Aparcio_Claudel_Meral
{
    public partial class frmCaserne : Form
    {
        public frmCaserne()
        {
            InitializeComponent();
        }

        private TableauDeBord tableauDeBord;    // Déclarer le volet du tableau de bord
        private AjoutMissions ajoutMissions;    // Déclarer le volet d'ajout de missions
        private GestionEngins gestionEngins;    // Déclarer le volet de gestion des engins
        private GestionPerso gestionPerso;      // Déclarer le volet de gestion du personnel
        private Statistique stats;              // Déclarer le volet de statistiques
        private SQLiteConnection con;           // Déclarer la connection à la base de données
        private DataSet monDs;                  // Déclarer le DataSet Global
        private DataTable dtMissionsFormatees;  // Déclarer une table de missions formatées pour le tableau de bord
        private Bouton btnActuel;               // Déclarer le bouton du volet actuellement ouvert

        private void frmCaserne_Load(object sender, EventArgs e)
        {
            con = Connexion.Connec;     // Récupérer la connexion à la base de données
            monDs = MesDatas.DsGlobal;  // Récupérer le DataSet global
            try
            {
                DataTable schemaTable = con.GetSchema("Tables");    // Récupérer le schéma de la base de données
                foreach(DataRow row in schemaTable.Rows)           // Parcourir les lignes du schéma
                {
                    string nomTable = row[2].ToString();                                                // Récupérer le nom de la table
                    SQLiteDataAdapter da = new SQLiteDataAdapter("Select * From " + nomTable, con);     // Créer un adaptateur de données
                    da.Fill(monDs, nomTable);                                                           // Remplir le DataSet avec les données de la table
                }
                dtMissionsFormatees = CreerTableMission(); // Créer la table de missions formatées pour le tableau de bord
            }
            catch { } // Gérer les exceptions
            finally
            {
                con.Close();
            }

            // Initialiser les boutons de navigation et définir leurs tags
            btnTableauDeBord.Tag = "tabBord";
            btnTableauDeBord.buttonText = "Tableau de Bord";
            btnAjoutMission.Tag = "nvMission";
            btnGestionEngins.Tag = "engins";
            btnGestionPersonnel.Tag = "perso";
            btnStatistiques.Tag = "tabStat";

            foreach(Bouton btn in panelNavigation.Controls.OfType<Bouton>())   // Lier les boutons de navigation
            {
                btn.ButtonClicked += NavigationButtonClick;                         // Lier l'événement de clic du bouton
            }
            panelVolet.Visible = false;                                             // Rendre le panneau de volet invisible au départ
        }

        private void NavigationButtonClick(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open) // Vérifier si la connexion est ouverte
            {
                con.Close(); // Fermer la connexion
            }
            Bouton btn = (Bouton)sender;    // Récupérer le bouton cliqué
            panelVolet.Visible = true;          // Rendre le panneau de volet visible
            panelVolet.Controls.Clear();        // Vider le panneau de volet avant d'ajouter un nouveau contrôle
            if(btnActuel != null)  // Vérifier si un bouton est déjà actif
            {
                btnActuel.IsClicked = false;    // Désactiver l'état cliqué du bouton précédent
            }
            btnActuel = btn;                    // Mettre à jour le bouton actuel
            switch(btn.Tag)     // Vérifier le tag du bouton cliqué
            {
                case ("tabBord"):
                    LoadTableauDeBord();    // Charger le tableau de bord
                    break;
                case ("tabStat"):
                    LoadStatistique();      // Charger les statistiques
                    break;
                case ("engins"):
                    LoadEngins();           // Charger la gestion des engins
                    break;
                case ("nvMission"):
                    LoadAjoutMission();     // Charger le volet d'ajout de mission
                    break;
                case ("perso"):
                    LoadPerso();
                    break;

            }
        }

        private void LoadAjoutMission()
        {
            if(ajoutMissions == null)  // Vérifier si monDs n'est pas vide
            {
                if(tableauDeBord == null) // Si le tableau de bord n'existe pas
                {
                    InitTableauDeBord(); // Initialiser le tableau de bord pour l'ajout éventuel de missions
                }
                ajoutMissions = new AjoutMissions();            // Instancier le volet 2 (Ajout de mission)
                ajoutMissions.ajouterMission = AjouterMission;  // Lier la méthode d'ajout de mission
            }
            panelVolet.Controls.Add(ajoutMissions); // Ajouter le volet d'ajout de mission au panneau
        }

        private void LoadTableauDeBord()
        {
            if(tableauDeBord == null) // Si le tableau de bord n'existe pas
            {
                InitTableauDeBord(); // Initialiser le tableau de bord
            }
            panelVolet.Controls.Add(tableauDeBord); // Ajouter le tableau de bord au panneau
        }

        private void InitTableauDeBord()
        {
            tableauDeBord = new TableauDeBord();                    // Instancier le volet de tableau de bord
            tableauDeBord.ajouterMissionBD = AjouterMissionBD;      // Lier la méthode d'ajout de mission à la base de données
            tableauDeBord.getEnginsMission = getEnginsMission;      // Lier la méthode de récupération des engins de la mission
            tableauDeBord.creerPdfMission = CreerPdfMission;        // Lier la méthode de création du PDF de la mission
            RemplirTableMissionsFormatees();                        // Remplir la table de missions formatées
            tableauDeBord.LoadMissions(dtMissionsFormatees);        // Charger les missions dans le tableau de bord
            tableauDeBord.Dock = DockStyle.Fill;                    // Définir le dock du tableau de bord
        }

        private void LoadStatistique()
        {
            con.Open();             // Ouvrir la connexion à la base de données
            if(stats == null)    // Vérifier si le tableau de statistiques n'existe pas
            {
                stats = new Statistique(con);   // Instancier le volet de statistiques
            }
            panelVolet.Controls.Add(stats);       // Ajouter le tableau de statistiques au panneau
        }
        private void LoadPerso()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            if(gestionPerso == null)
            {
                gestionPerso = new UC_GestionPerso.GestionPerso(con);
            }
            panelVolet.Controls.Add(gestionPerso);
        }
        private void LoadEngins()
        {
            if(gestionEngins == null) // Vérifier si le volet de gestion des engins n'existe pas
            {
                gestionEngins = new GestionEngins(monDs);   // Instancier le volet de gestion des engins
                gestionEngins.Dock = DockStyle.Fill;         // Définir le dock du volet de gestion des engins
            }
            panelVolet.Controls.Add(gestionEngins); // Ajouter le volet de gestion des engins au panneau
        }


        private DataTable CreerTableMission()
        {
            if(monDs != null)
            {
                DataTable dtMissions = new DataTable();         // Créer une nouvelle table de données
                for(int i = 0; i < 7; i++)
                {

                    DataColumn column = new DataColumn();       // Créer une nouvelle colonne
                    switch(i)
                    {
                        case 0:
                            column.ColumnName = "MissionID";    // Nom de la colonne
                            column.DataType = typeof(int);      // Type de données
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
                    dtMissions.Columns.Add(column); // Ajouter la colonne à la table de données
                }
                return dtMissions; // Retourner la table de données
            }
            return null; // Retourner null si le DataSet est vide
        }

        private void RemplirTableMissionsFormatees()
        {
            if(monDs != null)
            {
                DataTable dt = monDs.Tables["Mission"];     // Récupérer la table des missions
                foreach(DataRow row in dt.Rows)            // Parcourir les lignes de la table
                {
                    dtMissionsFormatees.Rows.Add(FormaterMission(row)); // Ajouter la nouvelle ligne à la table de données
                }
            }
        }

        private DataRow FormaterMission(DataRow drMission)
        {
            DataRow newRow = dtMissionsFormatees.NewRow();   // Créer une nouvelle ligne
            // Récupérer l'ID de la mission
            newRow["MissionID"] = Convert.ToInt32(drMission["id"]);
            // Récupérer le nom de la caserne
            newRow["Caserne"] = monDs.Tables["Caserne"].Select("id = " + drMission["idCaserne"].ToString())[0]["nom"].ToString();
            // Récupérer le nom de la nature de la mission
            newRow["Nature"] = monDs.Tables["NatureSinistre"].Select("id = " + drMission["idNatureSinistre"].ToString())[0]["libelle"].ToString();
            // Récupérer le motif de la mission
            newRow["Motif"] = drMission["motifAppel"].ToString();
            // Récupérer la date de début
            newRow["DateDebut"] = DateTime.Parse(drMission["dateHeureDepart"].ToString());
            // Récupérer la date de fin
            if(drMission["dateHeureRetour"] == DBNull.Value)     // Vérifier si la date de retour est nulle
            {
                newRow["DateFin"] = DBNull.Value;           // Mettre la date de fin à null
            }
            else
            {
                newRow["DateFin"] = DateTime.Parse(drMission["dateHeureRetour"].ToString());
            }
            newRow["EstEnCours"] = !Convert.ToBoolean(drMission["terminee"]); // Récupérer l'état de la mission

            return newRow; // Retourner la nouvelle ligne formatée
        }

        private void AjouterMission(DataRow drMission)
        {
            tableauDeBord.AjouterMission(FormaterMission(drMission)); // Ajouter la mission formatée au tableau de bord
        }

        private DataTable getEnginsMission(int idMission)
        {
            if(monDs != null)
            {
                DataTable dt = monDs.Tables["PartirAvec"];              // Récupérer la table des engins
                DataTable dtEnginsMission = dt.Clone();                 // Cloner la structure de la table des engins
                foreach(DataRow row in dt.Rows)                        // Parcourir les lignes de la table des engins
                {
                    if(Convert.ToInt32(row["idMission"]) == idMission) // Vérifier si l'ID de la mission correspond
                    {
                        dtEnginsMission.ImportRow(row);                 // Importer la ligne dans la nouvelle table
                    }
                }
                return dtEnginsMission; // Retourner la table des engins de la mission
            }
            return null; // Retourner null si le DataSet est vide
        }

        private void AjouterMissionBD(Mission mission, string compteRendu, DataTable engins)
        {
            // Mettre à jour le DataSet local avec les informations de la mission
            int idMission = mission.MissionID;  // Récupérer l'ID de la mission
            DataRow drMission = monDs.Tables["Mission"].Select("id = " + idMission.ToString()).FirstOrDefault(); // Récupérer la ligne de la mission dans le DataSet local
            drMission["dateHeureRetour"] = mission.DateFin; // Mettre à jour la date de fin de la mission dans le DataSet local
            drMission["compteRendu"] = compteRendu;         // Mettre à jour le compte rendu de la mission dans le DataSet local
            drMission["terminee"] = 1;                      // Mettre à jour le statut de la mission à "terminée" dans le DataSet local
            string requeteMission = "";         // Initialiser la requête SQL pour la mission
            con.Open(); // Ouvrir la connexion à la base de données
            // Vérifier si la mission existe déjà
            if(ExisteMissionBD(idMission)) // Si la mission existe déjà dans la base de données
            {
                requeteMission = UpdateMission(mission, compteRendu);      // Appeler la méthode de mise à jour de mission
            }
            else // Si la mission n'existe pas dans la base de données
            {
                requeteMission = InsertionMission(mission, compteRendu); // Appeler la méthode d'insertion de mission
                InsertionMobiliser(idMission);  // Appeler la méthode d'insertion des pompiers mobilisés
                InsertionPartirAvec(idMission); // Appeler la méthode d'insertion des engins mobilisés
            }
            try
            {
                SQLiteCommand cmdMission = new SQLiteCommand(requeteMission, con);  // Définir la commande SQL                                                                    
                cmdMission.ExecuteNonQuery();                                       // Insertion de la mission dans la table des missions
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout ou de la mise à jour de la mission dans la base de données"); // Afficher un message d'erreur
                MessageBox.Show(ex.ToString()); // Afficher l'erreur
            }
            // Mettre à jour le statut "En panne" et "En mission" de chaque engin faisant partie de la mission
            UpdateStatutEnginsMission(idMission, engins);

            // Mettre à jour le statut "En mission" de chaque pompier faisant partie de la mission
            UpdateStatutPompiersMission(idMission);
            con.Close(); // Fermer la connexion à la base de données
        }

        private bool ExisteMissionBD(int idMission)
        {
            // Logique pour vérifier si la mission existe déjà dans la base de données
            SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM Mission WHERE id = " + idMission, con);
            int count = Convert.ToInt32(cmd.ExecuteScalar()); // Exécuter la requête et récupérer le nombre de missions
            return count > 0; // Retourner true si la mission existe, sinon false
        }

        private string InsertionMission(Mission mission, string compteRendu)
        {
            // Logique pour ajouter une mission à la base de données
            int idMission = mission.MissionID; // Récupérer l'ID de la mission
            // Récupération des informations de la mission
            DataRow drMission = monDs.Tables["Mission"].Select("id = " + idMission.ToString())[0];  // Récupérer la ligne de la mission dans le DataSet local
            string AdresseMission = drMission["adresse"].ToString();                                // Récupération de l'adresse de la mission dans le DataSet local
            string CodePostalMission = drMission["cp"].ToString();                                  // Récupération du code postal de la mission dans le DataSet local
            string VilleMission = drMission["ville"].ToString();                                    // Récupération de la ville de la mission dans le DataSet local
            int IdNatureSinistre = Convert.ToInt32(drMission["idNatureSinistre"]);                  // Récupération de l'id du sinistre dans le DataSet local
            int IdCaserne = Convert.ToInt32(drMission["idCaserne"]);                                // Récupération de l'id de la caserne de la mission dans le DataSet local
            // Echappement de l'apostrophe
            mission.MotifMission = mission.MotifMission.Replace("'", " ");  // Remplacer les apostrophes par des espaces
            AdresseMission = AdresseMission.Replace("'", " ");              // Remplacer les apostrophes par des espaces
            compteRendu = compteRendu.Replace("'", " ");                    // Remplacer les apostrophes par des espaces

            // Renvoyer la requête SQL pour insérer la mission
            return "INSERT INTO Mission (id, dateHeureDepart, dateHeureRetour, motifAppel, adresse, cp, ville, terminee, compteRendu, idNatureSinistre, idCaserne)" +
                " VALUES " +
                $"({idMission.ToString()}, '{mission.DateDebut}', '{mission.DateFin}', '{mission.MotifMission}', '{AdresseMission}', " +
                $"'{CodePostalMission}', '{VilleMission}', 1, '{compteRendu}', {IdNatureSinistre.ToString()}, {IdCaserne.ToString()});";
        }

        private string UpdateMission(Mission mission, string compteRendu)
        {
            // Renvoyer la requête SQL pour mettre à jour la mission
            return $"UPDATE Mission SET dateHeureRetour = '{mission.DateFin}', terminee = 1, compteRendu = '{compteRendu}' WHERE id = {mission.MissionID.ToString()};";
        }

        private void InsertionMobiliser(int idMission)
        {
            try
            {
                // Logique pour ajouter les pompiers mobilisés à la mission dans la base de données
                string requeteMobiliser = ""; // Initialiser la requête SQL pour la mobilisation des pompiers
                foreach(DataRow row in monDs.Tables["Mobiliser"].Rows) // Parcourir les lignes de la table "Mobiliser"
                {
                    if(Convert.ToInt32(row["idMission"]) == idMission) // Vérifier si l'ID de la mission correspond
                    {
                        int matriculePompier = Convert.ToInt32(row["matriculePompier"]);    // Récupérer le matricule du pompier
                        int idHabilitation = Convert.ToInt32(row["idHabilitation"]);        // Récupérer l'ID de l'habilitation du pompier
                        requeteMobiliser = $"INSERT INTO Mobiliser (matriculePompier, idMission, idHabilitation) VALUES ({matriculePompier}, {idMission}, {idHabilitation}); "; // Créer la requête d'insertion
                    }
                }
                SQLiteCommand cmdMobiliser = new SQLiteCommand(requeteMobiliser, con);  // Définir la commande SQL                                                                  
                cmdMobiliser.ExecuteNonQuery();                                         // Insertion de la mobilisation des pompiers dans la table "Mobiliser"
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la mobilisation des pompiers dans la base de données"); // Afficher un message d'erreur
                MessageBox.Show(ex.ToString()); // Afficher l'erreur
            }
        }

        private void InsertionPartirAvec(int idMission)
        {
            try
            {
                // Logique pour ajouter les engins mobilisés à la mission dans la base de données
                string requetePartirAvec = ""; // Initialiser la requête SQL pour la mobilisation des engins
                foreach(DataRow row in monDs.Tables["PartirAvec"].Rows) // Parcourir les lignes de la table "PartirAvec"
                {
                    if(Convert.ToInt32(row["idMission"]) == idMission) // Vérifier si l'ID de la mission correspond
                    {
                        int idCaserne = Convert.ToInt32(row["idCaserne"]);                          // Récupérer l'ID de la caserne
                        string codeTypeEngin = row["codeTypeEngin"].ToString();                     // Récupérer le code type de l'engin
                        int numeroEngin = Convert.ToInt32(row["numeroEngin"]);                      // Récupérer le numéro de l'engin
                        string reparationsEventuelles = row["reparationsEventuelles"].ToString();   // Récupérer les réparations éventuelles de l'engin
                        requetePartirAvec += $"INSERT INTO PartirAvec (idCaserne, codeTypeEngin, numeroEngin, idMission, reparationsEventuelles) VALUES ({idCaserne}, '{codeTypeEngin}', {numeroEngin}, {idMission}, '{reparationsEventuelles}'); "; // Créer la requête d'insertion
                    }
                }
                SQLiteCommand cmdPartirAvec = new SQLiteCommand(requetePartirAvec, con);    // Définir la commande SQL                                                                    
                cmdPartirAvec.ExecuteNonQuery();                                            // Insertion de la mobilisation des engins dans la table "PartirAvec"
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la mobilisation des engins dans la base de données"); // Afficher un message d'erreur
                MessageBox.Show(ex.ToString()); // Afficher l'erreur
            }
        }

        private void UpdateStatutEnginsMission(int idMission, DataTable engins)
        {
            // Mettre à jour le statut "En panne" et "En mission" de chaque engin faisant partie de la mission
            try
            {
                foreach(DataRow row in engins.Rows)
                {
                    // Mettre à jour le statut de l'engin dans la base de données
                    string codeTypeEngin = row["Type"].ToString();  // Récupérer le code type de l'engin
                    int numero = Convert.ToInt32(row["Numero"]);    // Récupérer le numero de l'engin
                    int enPanne = Convert.ToInt32(row["enPanne"]);  // Récupérer le statut "En panne" de l'engin
                    SQLiteCommand cmdEngin = new SQLiteCommand($"UPDATE Engin SET enPanne = {enPanne}, enMission = 0 WHERE codeTypeEngin = '{codeTypeEngin}' AND numero = {numero};", con);
                    cmdEngin.ExecuteNonQuery(); // Exécuter la commande SQL pour mettre à jour le statut de l'engin dans la table "Engin"

                    // Mettre à jour les réparations éventuelles de l'engin dans la base de données
                    string reparations = row["Reparations"].ToString(); // Récupérer les réparations éventuelles de l'engin
                    reparations = reparations.Replace("'", " ");        // Remplacer les apostrophes par des espaces pour éviter les erreurs SQL
                    int idCaserne = Convert.ToInt32(monDs.Tables["Mission"].Select($"id = {idMission}").FirstOrDefault()["idCaserne"]);  // Récupérer l'ID de la caserne
                    SQLiteCommand cmdReparations = new SQLiteCommand($"UPDATE PartirAvec SET reparationsEventuelles = '{reparations}' WHERE idCaserne = {idCaserne} AND codeTypeEngin = '{codeTypeEngin}' AND numeroEngin = {numero} AND idMission = {idMission};", con);
                    cmdReparations.ExecuteNonQuery(); // Exécuter la commande SQL pour mettre à jour les réparations éventuelles

                    // Mettre à jour le statut de l'engin dans le DataSet local
                    DataRow drEngin = monDs.Tables["Engin"].Select($"codeTypeEngin = '{codeTypeEngin}' AND numero = {numero}").FirstOrDefault(); // Récupérer la ligne de l'engin dans le DataSet local
                    drEngin["enPanne"] = enPanne;                       // Mettre à jour le statut "En panne" de l'engin dans le DataSet local
                    drEngin["enMission"] = 0;                           // Mettre à jour le statut "En mission" de l'engin dans le DataSet local
                    // Mettre à jour les réparations éventuelles de l'engin dans le DataSet local
                    DataRow drReparations = monDs.Tables["PartirAvec"].Select($"idCaserne = {idCaserne} AND codeTypeEngin = '{codeTypeEngin}' AND numeroEngin = {numero} AND idMission = {idMission}").FirstOrDefault(); // Récupérer la ligne de l'engin dans la table "PartirAvec" du DataSet local
                    drReparations["reparationsEventuelles"] = reparations; // Mettre à jour les réparations éventuelles de l'engin dans le DataSet local
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour des engins dans la base de données"); // Afficher un message d'erreur
                MessageBox.Show(ex.ToString()); // Afficher l'erreur
            }
        }

        private void UpdateStatutPompiersMission(int idMission)
        {
            // Mettre à jour le statut "En mission" de chaque pompier faisant partie de la mission
            try
            {
                foreach(DataRow row in monDs.Tables["Mobiliser"].Rows) // Parcourir les lignes de la table "Mobiliser"
                {
                    if(Convert.ToInt32(row["idMission"]) == idMission) // Vérifier si l'ID de la mission correspond
                    {
                        // Mettre à jour le statut du pompier dans la base de données
                        int matriculePompier = Convert.ToInt32(row["matriculePompier"]); // Récupérer le matricule du pompier
                        SQLiteCommand cmdPompier = new SQLiteCommand("UPDATE Pompier SET enMission = 0 WHERE matricule = " + matriculePompier + ";", con);
                        cmdPompier.ExecuteNonQuery(); // Exécuter la commande SQL
                        // Mettre à jour le statut du pompier dans le DataSet local
                        DataRow drPompier = monDs.Tables["Pompier"].Select("matricule = " + matriculePompier.ToString()).FirstOrDefault(); // Récupérer la ligne du pompier dans le DataSet local
                        drPompier["enMission"] = 0; // Mettre à jour le statut "En mission" du pompier dans le DataSet local
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour des pompiers dans la base de données"); // Afficher un message d'erreur
                MessageBox.Show(ex.ToString()); // Afficher l'erreur
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            con.Close();        // Fermer la connexion à la base de données
            Application.Exit(); // Quitter l'application
        }

        private string CreerPdfMission(int idMission)
        {
            DataRow drMission = monDs.Tables["Mission"].Select("id = " + idMission.ToString())[0];  // Récupérer la ligne de la mission dans le DataSet local

            // Logique pour générer le PDF
            try
            {
                // Chemin du fichier PDF à générer dans le dossier de l'utilisateur
                string cheminFichier = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Mission_" + idMission + ".pdf"); //Récupérer le chemin du dossier Documents

                // Création du document PDF
                Document document = new Document(PageSize.A4);
                PdfWriter.GetInstance(document, new FileStream(cheminFichier, FileMode.Create));

                // Ouvrir le document pour y écrire
                document.Open();

                // Définir les polices de caractères
                iTextSharp.text.Font fontTitre = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 25, iTextSharp.text.Font.BOLD);    // Définir la police de caractère de titre
                iTextSharp.text.Font fontGras = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15, iTextSharp.text.Font.BOLD);     // Définir la police de caractère en gras

                // Créer un séparateur avec une ligne horizontale
                Chunk separateur = new Chunk(new LineSeparator(2f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, 0));

                // Ajouter le contenu au document PDF
                AjouterImagePDF(document);                              // Ajouter l'image du logo des pompiers
                AjouterTitrePDF(document, idMission, fontTitre);        // Ajouter le titre du rapport
                AjouterDateDebutPDF(document, drMission);               // Ajouter la date de début de la mission
                AjouterDateFinPDF(document, drMission);                 // Ajouter la date de fin de la mission

                document.Add(new Paragraph("\n\n\n\n"));                // Ajouter des sauts de ligne pour l'espacement

                AjouterSeparateurPDF(document, separateur);             // Ajouter le séparateur

                AjouterNaturePDF(document, drMission, fontGras);        // Ajouter la nature de la mission
                AjouterMotifPDF(document, drMission, fontGras);         // Ajouter le motif de la mission
                AjouterAdressePDF(document, drMission, fontGras);       // Ajouter l'adresse de la mission
                AjouterCompteRenduPDF(document, drMission, fontGras);   // Ajouter le compte rendu de la mission

                AjouterSeparateurPDF(document, separateur);             // Ajouter le séparateur

                AjouterCasernePDF(document, drMission, fontGras);       // Ajouter la caserne de la mission
                AjouterEnginsPDF(document, idMission, fontGras);        // Ajouter les engins mobilisés
                AjouterPompiersPDF(document, idMission, fontGras);      // Ajouter les pompiers mobilisés

                // Fermer le document
                document.Close();

                // Afficher un message de succès
                MessageBox.Show("PDF de la mission n°" + idMission + " généré avec succès :\n" + cheminFichier, "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return cheminFichier; // Retourner le chemin du fichier PDF généré
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message); //Afficher un message d'erreur
            }
            return null; // Retourner null en cas d'erreur
        }

        private void AjouterSeparateurPDF(Document document, Chunk separateur)
        {
            document.Add(new Paragraph("\n"));  // Ajouter un saut de ligne avant le séparateur
            document.Add(separateur);           // Ajouter le séparateur au document
            document.Add(new Paragraph("\n"));  // Ajouter un saut de ligne après le séparateur
        }

        private void AjouterImagePDF(Document document)
        {
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Resources.pompiers, System.Drawing.Imaging.ImageFormat.Png); // Récupérer l'image du logo des pompiers depuis les ressources
            img.ScaleToFit(190f, 190f); // Ajuster la taille de l'image
            img.Alignment = iTextSharp.text.Image.TEXTWRAP | iTextSharp.text.Image.ALIGN_RIGHT; // Aligner l'image à droite
            document.Add(img); // Ajouter l'image du logo des pompiers
        }

        private void AjouterTitrePDF(Document document, int idMission, iTextSharp.text.Font fontTitre)
        {
            document.Add(new Phrase($"Rapport: Mission n°{idMission}", fontTitre)); //Ajouter le titre du rapport
        }

        private void AjouterDateDebutPDF(Document document, DataRow drMission)
        {
            DateTime dateDebut = Convert.ToDateTime(drMission["dateHeureDepart"]);      // Récupérer la date de fin de la mission
            string dateDebutFormatted = dateDebut.ToString("dd MMMM yyyy à HH:mm");     // Formater la date de fin
            document.Add(new Paragraph($"\nDéclenchée le {dateDebutFormatted}"));       // Indiquer la date de début de la mission
        }

        private void AjouterDateFinPDF(Document document, DataRow drMission)
        {
            if(Convert.ToInt32(drMission["terminee"]) == 0) // Vérifier si la mission est en cours
            {
                document.Add(new Paragraph("\nEn cours ...")); // Indiquer que la mission est en cours
            }
            else
            {
                DateTime dateFin = Convert.ToDateTime(drMission["dateHeureRetour"]);    // Récupérer la date de fin de la mission
                string dateFinFormatted = dateFin.ToString("dd MMMM yyyy à HH:mm");     // Formater la date de fin
                document.Add(new Paragraph($"\nTerminée le {dateFinFormatted}"));       // Indiquer la date de fin de la mission
            }
        }

        private void AjouterNaturePDF(Document document, DataRow drMission, iTextSharp.text.Font fontGras)
        {
            string natureMission = monDs.Tables["NatureSinistre"].Select("id = " + drMission["idNatureSinistre"].ToString())[0]["libelle"].ToString(); // Récupérer la nature de la mission
            document.Add(new Phrase("Nature de la mission : ", fontGras)); // Indiquer la nature de la mission
            document.Add(new Phrase(natureMission + "\n")); // Ajouter la nature de la mission
        }

        private void AjouterMotifPDF(Document document, DataRow drMission, iTextSharp.text.Font fontGras)
        {
            document.Add(new Phrase("Motif de la mission : ", fontGras)); // Indiquer le motif de la mission
            document.Add(new Phrase(drMission["motifAppel"].ToString() + "\n")); // Ajouter le motif de la mission
        }

        private void AjouterAdressePDF(Document document, DataRow drMission, iTextSharp.text.Font fontGras)
        {
            string adresseMission = drMission["adresse"].ToString();    // Récupérer l'adresse de la mission
            string codePostalMission = drMission["cp"].ToString();      // Récupérer le code postal de la mission
            string villeMission = drMission["ville"].ToString();        // Récupérer la ville de la mission
            document.Add(new Phrase("Adresse : ", fontGras));           // Indiquer l'adresse de la mission
            document.Add(new Phrase($"{adresseMission}, {villeMission}, {codePostalMission}\n")); // Ajouter l'adresse de la mission
        }

        private void AjouterCompteRenduPDF(Document document, DataRow drMission, iTextSharp.text.Font fontGras)
        {
            document.Add(new Phrase("Compte rendu : ", fontGras));         // Indiquer le compte rendu de la mission
            document.Add(new Phrase(drMission["compteRendu"].ToString())); // Ajouter le compte rendu de la mission
        }

        private void AjouterCasernePDF(Document document, DataRow drMission, iTextSharp.text.Font fontGras)
        {
            document.Add(new Phrase("Caserne : ", fontGras)); // Indiquer la caserne
            string nomCaserne = monDs.Tables["Caserne"].Select("id = " + drMission["idCaserne"].ToString())[0]["nom"].ToString(); // Récupérer le nom de la caserne
            document.Add(new Phrase(nomCaserne)); // Ajouter le nom de la caserne
        }

        private void AjouterEnginsPDF(Document document, int idMission, iTextSharp.text.Font fontGras)
        {
            document.Add(new Paragraph("\n")); // Ajouter un saut de ligne
            document.Add(new Paragraph("Engins mobilisés :", fontGras)); // Indiquer les engins mobilisés

            DataTable enginsMission = getEnginsMission(idMission);      // Récupérer les engins de la mission
            if(enginsMission != null && enginsMission.Rows.Count > 0)  // Vérifier si des engins sont mobilisés
            {
                foreach(DataRow row in enginsMission.Rows) // Parcourir les lignes de la table des engins
                {
                    string codeTypeEngin = row["codeTypeEngin"].ToString(); // Récupérer le code type de l'engin
                    string numeroEngin = row["numeroEngin"].ToString();     // Récupérer le numéro de l'engin
                    string idCaserne = row["idCaserne"].ToString();         // Récupérer l'ID de la caserne de l'engin
                    string typeEngin = monDs.Tables["TypeEngin"].Select($"code = '{codeTypeEngin}'")[0]["nom"].ToString(); // Récupérer le libellé du type d'engin
                    int enPanne = Convert.ToInt32(monDs.Tables["Engin"].Select($"idCaserne = {idCaserne} AND codeTypeEngin = '{codeTypeEngin}' AND numero = {numeroEngin}")[0]["enPanne"]); // Récupérer le statut "En panne" de l'engin
                    string enPanneText = enPanne == 1 ? "Oui" : "Non"; //Indiquer si l'engin est en panne
                    string reparationsEventuelles = monDs.Tables["PartirAvec"].Select($"idCaserne = {idCaserne} AND codeTypeEngin = '{codeTypeEngin}' AND numeroEngin = '{numeroEngin}' AND idMission = {idMission}")[0]["reparationsEventuelles"].ToString(); // Récupérer les réparations éventuelles de l'engin
                    if(string.IsNullOrEmpty(reparationsEventuelles))
                    {
                        reparationsEventuelles = "Aucune réparation prévue"; // Indiquer qu'il n'y a pas de réparations prévues
                    }
                    document.Add(new Paragraph($" --> {typeEngin} {idCaserne}-{codeTypeEngin}-{numeroEngin} (En panne: {enPanneText})\n       Réparations éventuelles: {reparationsEventuelles}")); // Indiquer le type d'engin, son numéro, son statut "En panne" et les réparations éventuelles
                }
            }
            else
            {
                document.Add(new Paragraph("Aucun engin mobilisé pour cette mission.")); // Indiquer qu'aucun engin n'est mobilisé
            }
        }

        private void AjouterPompiersPDF(Document document, int idMission, iTextSharp.text.Font fontGras)
        {
            document.Add(new Paragraph("\n")); // Ajouter un saut de ligne
            document.Add(new Paragraph("Pompiers mobilisés :", fontGras)); // Indiquer les pompiers mobilisés

            DataTable pompiersMission = monDs.Tables["Mobiliser"].Select("idMission = " + idMission.ToString()).CopyToDataTable(); // Récupérer les pompiers de la mission
            if(pompiersMission != null && pompiersMission.Rows.Count > 0) // Vérifier si des pompiers sont mobilisés
            {
                foreach(DataRow row in pompiersMission.Rows) // Parcourir les lignes de la table des pompiers
                {
                    string matriculePompier = Convert.ToInt32(row["matriculePompier"]).ToString(); // Récupérer le matricule du pompier
                    string prenomPompier = monDs.Tables["Pompier"].Select("matricule = " + matriculePompier)[0]["prenom"].ToString();       // Récupérer le prénom du pompier
                    string nomPompier = monDs.Tables["Pompier"].Select("matricule = " + matriculePompier)[0]["nom"].ToString();             // Récupérer le nom du pompier
                    string codeGradePompier = monDs.Tables["Pompier"].Select("matricule = " + matriculePompier)[0]["codeGrade"].ToString(); // Récupérer le grade du pompier
                    string gradePompier = monDs.Tables["Grade"].Select($"code = '{codeGradePompier}'")[0]["libelle"].ToString();            // Récupérer le libellé du grade du pompier
                    string idHabilitationPompier = monDs.Tables["Mobiliser"].Select($"matriculePompier = {matriculePompier} AND idMission = {idMission}")[0]["idHabilitation"].ToString(); // Récupérer l'habilitation du pompier
                    string habilitationPompier = monDs.Tables["Habilitation"].Select("id = " + idHabilitationPompier)[0]["libelle"].ToString(); // Récupérer le libellé de l'habilitation du pompier

                    document.Add(new Paragraph($" --> {gradePompier} {prenomPompier} {nomPompier} ({habilitationPompier})")); // Indiquer le grade, le prénom, le nom et l'habilitation du pompier
                }
            }
            else
            {
                document.Add(new Paragraph("Aucun pompier mobilisé pour cette mission.")); // Indiquer qu'aucun pompier n'est mobilisé
            }
        }
    }
}
