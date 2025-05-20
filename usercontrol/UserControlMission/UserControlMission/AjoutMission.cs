using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Net;

namespace UserControlMission
{
    public partial class ucMission : UserControl
    {
        public ucMission()
        {
            InitializeComponent();
        }

        DataSet monDs;
        int nextId = 0;
        String date;

        public ucMission(DataSet ds)
        {
            InitializeComponent();
            monDs = ds;
            ChargementCbo(monDs.Tables["NatureSinistre"], "libelle", "id", cboNature);
            ChargementCbo(monDs.Tables["Caserne"], "nom", "id", cboCaserne);

            //le numéro + date de la prochaine mission
            nextId = monDs.Tables["Mission"].Rows.Count + 1;
            date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            lblNumMission.Text = "Mission n°" + nextId.ToString();
            lblDate.Text = "déclenchée le : " + date;
        }

        //méthodes KeyPress 
        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) && txtCP.Text.Length < 5)
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back) { e.Handled = false; }
        }

        private void txtVille_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back || Char.IsLetter(e.KeyChar)) { e.Handled = false; }
            if (txtVille.SelectionStart != 0 && e.KeyChar == ' ') { e.Handled = false; }
            if (e.KeyChar == '-' && txtVille.SelectionStart != 0) { e.Handled = false; }
        }

        private void ChargementCbo(DataTable dt, String col1, String col2, ComboBox c)
        {
            c.Items.Clear();
            c.DataSource = dt;
            c.DisplayMember = col1;
            c.ValueMember = col2;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Si la mission peut être exécuter (même si l'équipe incomplète alors remplir la table Mission de mon DataSet)

            int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);
            int idSinistre = Convert.ToInt32(cboNature.SelectedValue);
            DataTable enginNecessaire = enginMission(idSinistre);

            if (tryEngin(idSinistre, idCaserne) && tryPompier(idCaserne, enginNecessaire))
            {
                remplirMission();
                remplissageEngin(idSinistre, idCaserne);
            }
            else
            {
                initialiser();
            }

            //UC gried view
            grpMob.Visible = true;

            DataTable dtEngin = remplissageEngin(idSinistre, idCaserne);
            UC_MobilisationEnginPompier dgvEngin = new UC_MobilisationEnginPompier(dtEngin);
            //ajout dans le grp box
            grpMob.Controls.Add(dgvEngin);

        }

        //créer une table pour stockage des types des diff engins qui sont nécessaires à la mission(avoir le numéro et le type)
        private DataTable enginMission(int idSinistre)
        {
            DataRow[] tab = monDs.Tables["Necessiter"].Select("idNatureSinistre = " + idSinistre);
            DataTable dtEngins = new DataTable();
            dtEngins.Columns.Add("codeTypeEngin");
            dtEngins.Columns.Add("nombre", typeof(int));

            foreach (DataRow ligne in tab)
            {
                string typeEngin = ligne["codeTypeEngin"].ToString();
                int nombre = Convert.ToInt32(ligne["nombre"]);
                // Ajouter dans la table
                dtEngins.Rows.Add(typeEngin, nombre);
            }
            return dtEngins;
        }

        // Stockage des types des diff habilitations nécessaires à la mission en fonction de l'engin
        private DataTable habilitationNecessaire(DataTable enginNecessaire)
        {
            DataTable habilitationNecessaire = new DataTable();
            habilitationNecessaire.Columns.Add("TypeEngin");
            habilitationNecessaire.Columns.Add("idHab", typeof(int));
            habilitationNecessaire.Columns.Add("nombre", typeof(int));
            foreach (DataRow dr in enginNecessaire.Rows)
            {
                DataRow[] dt = monDs.Tables["Embarquer"].Select("codeTypeEngin = '" + dr["TypeEngin"] + "'");
                foreach (DataRow ligne in dt)
                {
                    string type = ligne["codeTypeEngin"].ToString();
                    int idHab = Convert.ToInt32(ligne["idHabilitation"]);
                    int nb = Convert.ToInt32(ligne["nombre"]);
                    habilitationNecessaire.Rows.Add(type, idHab, nb);
                }
            }
            return habilitationNecessaire;
        }

        private void remplirMission()
        {
            // Ajout d'une nouvelle ligne dans la table Mission de monDs
            DataRow row = monDs.Tables["Mission"].NewRow();
            row["id"] = nextId;
            row["dateHeureDepart"] = date;
            row["motifAppel"] = txtMotif.Text;
            row["adresse"] = txtRue.Text;
            row["cp"] = txtCP.Text;
            row["ville"] = txtVille.Text;
            row["terminee"] = 0;
            int idSinistre = Convert.ToInt32(cboNature.SelectedValue);
            row["idNatureSinistre"] = idSinistre;
            int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);
            row["idCaserne"] = idCaserne;

            //Ajout de la ligne
            monDs.Tables["Mission"].Rows.Add(row);

            //Après avoir valider rendre les boutons pas visible 
            btnAnnuler.Visible = false;
            btnValider.Visible = false;
        }


        private bool tryEngin(int idSinistre, int idCaserne)
        {
            // Récupère les types et quantités d'engins necessaire pour le sinistre
            DataTable enginNecessaire = enginMission(idSinistre);

            foreach (DataRow dr in enginNecessaire.Rows)
            {
                string typeEngin = dr["codeTypeEngin"].ToString();
                int nbMinEngin = Convert.ToInt32(dr["nombre"]);

                // Vérifier si les engins disponibles pour ce type sont dans la caserne
                DataRow[] enginsDispo = monDs.Tables["Engin"].Select(
                    $"idCaserne = {idCaserne} AND codeTypeEngin = '{typeEngin}' AND enMission = 0 AND enPanne = 0");

                if (enginsDispo.Length < nbMinEngin)
                {
                    // Pas assez d'engins disponibles
                    MessageBox.Show("Il n'y a pas assez d'engins disponibles");
                    return false;
                }
            }

            // Tous les engins requis sont dispo
            return true;
        }

        private bool tryPompier(int idCaserne, DataTable enginNecessaire)
        {
            // Liste des pompiers déjà affectés pour éviter les doublons,
            // un pompier ne peut pas être mobilisé deux fois pour deux types d'engins différents
            List<int> pompiersUtilises = new List<int>();

            foreach (DataRow engin in enginNecessaire.Rows)
            {
                string codeTypeEngin = engin["codeTypeEngin"].ToString();
                int nombreRequis = Convert.ToInt32(engin["nombre"]);
                int nombreTrouve = 0;

                // Récupère les habilitations pour ce type d'engin
                DataRow[] habilites = monDs.Tables["Embarquer"].Select($"codeTypeEngin = '{codeTypeEngin}'");

                // Filtrons ceux appartenant à la caserne ET qui ne sont pas encore utilisés
                foreach (DataRow habilitation in habilites)
                {
                    int idPompier = Convert.ToInt32(habilitation["idPompier"]);

                    // Vérifier que ce pompier appartient bien à la caserne + pas en mission, ni en congé
                    DataRow[] pompierInfo = monDs.Tables["Pompier"].Select($"idPompier = {idPompier} AND idCaserne = {idCaserne} AND enMission = 0 AND enConge = 0");

                    if (pompierInfo.Length > 0 && !pompiersUtilises.Contains(idPompier))
                    {
                        pompiersUtilises.Add(idPompier);
                        nombreTrouve++;

                        // On a trouvé assez de pompiers pour ce type d'engin
                        if (nombreTrouve == nombreRequis)
                        {
                            break;
                        }
                    }
                }

                // Pas du tout de pompiers habilités disponibles pour ce type d'engin
                if (nombreTrouve == 0)
                {
                    return false;
                }
            }

            // Tous les engins ont suffisamment de pompiers habilités
            return true;
        }


        private DataTable remplissageEngin(int idSinistre, int idCaserne)
        {
            DataTable enginNecessaire = enginMission(idSinistre);

            DataTable dt = new DataTable();
            dt.Columns.Add("Type d'engin");
            dt.Columns.Add("Numéro", typeof(int));
            foreach (DataRow dr in enginNecessaire.Rows)
            {
                string typeEngin = dr["codeTypeEngin"].ToString();
                int nbMinEngin = Convert.ToInt32(dr["nombre"]);

                // Vérifie les engins disponibles pour ce type dans la caserne
                DataRow[] enginsDispo = monDs.Tables["Engin"].Select(
                    $"idCaserne = {idCaserne} AND codeTypeEngin = '{typeEngin}' AND enMission = 0 AND enPanne = 0");

                // Choisir les nbMinEngin premiers engins
                for (int i = 0; i < nbMinEngin; i++)
                {
                    // Ajout dans dt
                    dt.Rows.Add(typeEngin, enginsDispo[i]["numero"]);

                    // Ajout dans la table PartirAvec 
                    DataRow drPartir = monDs.Tables["PartirAvec"].NewRow();
                    drPartir["idCaserne"] = idCaserne;
                    drPartir["codeTypeEngin"] = enginsDispo[i]["codeTypeEngin"];
                    drPartir["numeroEngin"] = enginsDispo[i]["numero"];
                    drPartir["idMission"] = nextId;

                    monDs.Tables["PartirAvec"].Rows.Add(drPartir);

                    // Marquer l'engin comme en mission
                    enginsDispo[i]["enMission"] = 1;
                }

            }
            return dt;

        }

        private DataTable remplissagePompier(int idCaserne, int idMission, DataTable enginsNecessaires)
        {
            DataTable dtPompiersMobilises = new DataTable();
            dtPompiersMobilises.Columns.Add("Matricule", typeof(int));
            dtPompiersMobilises.Columns.Add("idHabilitation", typeof(int));

            // Récupère les habilitations nécessaires
            DataTable dtHabsNecessaires = habilitationNecessaire(enginsNecessaires);

            // Liste des pompiers déjà affectés (éviter double attribution)
            List<int> pompiersDejaPris = new List<int>();

            foreach (DataRow habRow in dtHabsNecessaires.Rows)
            {
                string typeEngin = habRow["TypeEngin"].ToString();
                int idHab = Convert.ToInt32(habRow["idHab"]);
                int nbRequis = Convert.ToInt32(habRow["nombre"]);

                // Cherche les pompiers disponibles (dans la caserne, pas en congé ni en mission)
                DataRow[] pompiers = monDs.Tables["Pompier"].Select(
                    $"idCaserne = {idCaserne} AND enMission = 0 AND enConge = 0");

                int nbAffectes = 0;

                foreach (DataRow pompier in pompiers)
                {
                    int matricule = Convert.ToInt32(pompier["matricule"]);

                    if (pompiersDejaPris.Contains(matricule))
                        continue;

                    // Vérifie que le pompier a l’habilitation requise
                    DataRow[] habilitations = monDs.Tables["Posseder"].Select(
                        $"matricule = {matricule} AND idHabilitation = {idHab}");

                    if (habilitations.Length > 0)
                    {
                        // Ajouter dans dtPompiersMobilises
                        dtPompiersMobilises.Rows.Add(matricule, idHab);

                        // Ajouter dans Mobiliser (matricule, idHabilitation, idMission)
                        DataRow drMobiliser = monDs.Tables["Mobiliser"].NewRow();
                        drMobiliser["matricule"] = matricule;
                        drMobiliser["idHabilitation"] = idHab;
                        drMobiliser["idMission"] = idMission;

                        monDs.Tables["Mobiliser"].Rows.Add(drMobiliser);

                        // Marquer comme en mission
                        pompier["enMission"] = 1;

                        // Marquer comme utilisé
                        pompiersDejaPris.Add(matricule);

                        nbAffectes++;

                        if (nbAffectes == nbRequis)
                            break;
                    }
                }

                if (nbAffectes < nbRequis)
                {
                    MessageBox.Show($"Mission annulée : pas assez de pompiers avec l'habilitation {idHab} pour l'engin {typeEngin}.");
                    return null;
                }
            }

            return dtPompiersMobilises;
        }




        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            initialiser();

        }

        private void initialiser()
        {
            txtCP.Text = String.Empty;
            txtVille.Text = String.Empty;
            txtRue.Text = String.Empty;
            txtMotif.Text = String.Empty;
            cboCaserne.SelectedIndex = -1;
            cboNature.SelectedIndex = -1;
        }
    }
}
