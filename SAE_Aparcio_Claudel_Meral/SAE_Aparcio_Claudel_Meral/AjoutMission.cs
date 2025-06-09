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
    public delegate void AjouterMission(DataRow drMission); // Déclaration de la signature du délégué pour ajouter une mission

    public partial class ucMission : UserControl
    {
        public ucMission()
        {
            InitializeComponent();
            monDs = SAE_Aparcio_Claudel_Meral.MesDatas.DsGlobal;
            ChargementCbo(monDs.Tables["NatureSinistre"], "libelle", "id", cboNature);
            ChargementCbo(monDs.Tables["Caserne"], "nom", "id", cboCaserne);

            //le numéro + date de la prochaine mission
            nextId = monDs.Tables["Mission"].Rows.Count + 1;
            date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            lblNumMission.Text = "Mission n°" + nextId.ToString();
            lblDate.Text = "déclenchée le : " + date;
        }

        public AjouterMission ajouterMission; // Instance du délégué pour ajouter une mission
        DataSet monDs;
        int nextId = 0;
        String date;


        List<int[]> pompIdHab;
        DataTable dtEngin;
        bool equipeCompletePossible;


        //méthodes KeyPress 
        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if(Char.IsDigit(e.KeyChar) && txtCP.Text.Length < 5)
            {
                e.Handled = false;
            }
            if(e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back) { e.Handled = false; }
        }

        private void txtVille_KeyPress(object sender, KeyPressEventArgs e)
        {
            erp.Clear();
            TextBox tb = sender as TextBox;
            string texteActuel = tb.Text;
            int pos = tb.SelectionStart;

            e.Handled = true;

            if(e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

            if(char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            if(e.KeyChar == ' ' || e.KeyChar == '-')
            {
                e.Handled = false;

                // Pas en premier caractère
                if(pos == 0)
                {
                    e.Handled = true;
                }

                // Pas deux espaces/tirets consécutifs
                if((pos > 0 && (texteActuel[pos - 1] == ' ' || texteActuel[pos - 1] == '-')))
                {
                    e.Handled = true;
                }
            }
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
            //error provider 
            if(txtCP.Text == String.Empty || (txtCP.Text != String.Empty && txtCP.Text.Length < 5)) { erp.SetError(txtCP, "Veuillez rentrez le code postal."); return; }
            else if(txtRue.Text == String.Empty) { erp.SetError(txtRue, "Veuillez rentrez la rue."); return; }
            else if(txtVille.Text == String.Empty) { erp.SetError(txtVille, "Veuillez rentrez la ville."); return; }
            else if(txtMotif.Text == String.Empty) { erp.SetError(txtRue, "Veuillez rentrez le motif."); return; }
            else if(cboCaserne.SelectedIndex == -1) { erp.SetError(cboCaserne, "Veuillez choisir la caserne."); return; }
            else if(cboNature.SelectedIndex == -1) { erp.SetError(cboNature, "Veuillez choisir la nature du sinistre."); return; }
            // Si la mission peut être exécuter (même si l'équipe incomplète alors remplir la table Mission de mon DataSet)

            int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);
            int idSinistre = Convert.ToInt32(cboNature.SelectedValue);
            DataTable enginNecessaire = enginMission(idSinistre); ;

            if(tryEngin(idSinistre, idCaserne)
                && tryPompier(idCaserne, enginNecessaire))
            {
                remplirMission();
                //remplissageEngin(idSinistre, idCaserne);
                //remplissagePompier(idCaserne, enginNecessaire);
                generationUC(idSinistre, idCaserne);

                //UC gried view
                grpMob.Visible = true;
                //ajout dans le grp box
                btnNvMission.Visible = true;

                //mettre tout a enabled = false
                txtMotif.Enabled = false;
                txtRue.Enabled = false;
                txtVille.Enabled = false;
                txtCP.Enabled = false;
                cboCaserne.Enabled = false;
                cboNature.Enabled = false;
            }
            else
            {
                initialiser();
                if(!(tryEngin(idSinistre, idCaserne)))
                {
                    MessageBox.Show("Il n'y a pas assez d'engins pour la mission.");
                }
                else
                {
                    MessageBox.Show("Il n'y a pas assez de pompiers ayant les habilitations nécessaires pour cette mission.");
                }
            }

        }

        //créer une table pour stockage des types des diff engins qui sont nécessaires à la mission(avoir le numéro et le type)
        private DataTable enginMission(int idSinistre)
        {
            DataRow[] tab = monDs.Tables["Necessiter"].Select("idNatureSinistre = " + idSinistre);
            DataTable dtEngins = new DataTable();
            dtEngins.Columns.Add("codeTypeEngin");
            dtEngins.Columns.Add("nombre", typeof(int));

            foreach(DataRow ligne in tab)
            {
                string typeEngin = ligne["codeTypeEngin"].ToString();
                int nombre = Convert.ToInt32(ligne["nombre"]);
                // Ajouter dans la table
                dtEngins.Rows.Add(typeEngin, nombre);
            }
            return dtEngins;
        }

        private void remplirMission()
        {
            // Ajout d'une nouvelle ligne dans la table Mission de monDs
            DataRow row = monDs.Tables["Mission"].NewRow();
            row["id"] = Convert.ToInt32(nextId);
            row["dateHeureDepart"] = date;
            row["motifAppel"] = txtMotif.Text;
            row["adresse"] = txtRue.Text;
            row["cp"] = txtCP.Text;
            row["ville"] = txtVille.Text;
            row["terminee"] = 0;
            int idSinistre = Convert.ToInt32(cboNature.SelectedValue);
            row["idNatureSinistre"] = Convert.ToInt32(idSinistre);
            int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);
            row["idCaserne"] = Convert.ToInt32(idCaserne);

            //Ajout de la ligne
            monDs.Tables["Mission"].Rows.Add(row);
            if(ajouterMission != null)
            {
                ajouterMission(row); // Appel du délégué pour ajouter la mission
            }

            //Après avoir valider rendre les boutons pas visible 
            btnAnnuler.Visible = false;
            btnValider.Visible = false;
            btnNvMission.Visible = true;
        }



        private bool tryEngin(int idSinistre, int idCaserne)
        {
            // Récupère les types et quantités d'engins necessaire pour le sinistre
            DataTable enginNecessaire = enginMission(idSinistre);

            foreach(DataRow dr in enginNecessaire.Rows)
            {
                string typeEngin = dr["codeTypeEngin"].ToString();
                int nbMinEngin = Convert.ToInt32(dr["nombre"]);

                // Vérifier si les engins disponibles pour ce type sont dans la caserne
                DataRow[] enginsDispo = monDs.Tables["Engin"].Select(
                    $"idCaserne = {idCaserne} AND codeTypeEngin = '{typeEngin}' AND enMission = 0 AND enPanne = 0");

                if(enginsDispo.Length < nbMinEngin)
                {
                    // Pas assez d'engins disponibles
                    return false;
                }
            }

            // Tous les engins requis sont dispo
            return true;
        }



        //trier liste de tableau
        private List<int[]> trierTab(List<int[]> liste)
        {
            //Stocker les matricules uniques
            List<int> matricule = new List<int>();
            for(int j = 0; j < liste.Count; j++)
            {
                int matriculeUnique = liste[j][0];
                if(!matricule.Contains(matriculeUnique))
                {
                    matricule.Add(matriculeUnique);
                }
            }

            //Stocker dans une liste la fréquence d'apprition des matricules
            List<int[]> frequence = new List<int[]>();
            for(int k = 0; k < matricule.Count; k++)
            {
                int idmat = matricule[k];
                int nb = 0;
                for(int j = 0; j < liste.Count; j++)
                {
                    if(liste[j][0] == idmat)
                    {
                        nb++;
                    }
                }
                int[] x = new int[] { idmat, nb };
                frequence.Add(x);
            }

            //Trier la liste de fréquence par nombre d'apparition
            List<int[]> trier = new List<int[]>();
            for(int p = 0; p < frequence.Count; p++)
            {
                int[] courant = frequence[p];
                int h = 0;
                while(h < trier.Count && trier[h][1] < courant[1])
                {
                    h++;
                }
                trier.Insert(h, courant);
            }

            //Puis enfin trier la liste de base 
            List<int[]> res = new List<int[]>();
            for(int i = 0; i < trier.Count; i++)
            {
                foreach(int[] dr in liste)
                {
                    if(trier[i][0] == dr[0])
                    {
                        res.Add(dr);
                    }
                }
            }
            return res;
        }



        private bool tryPompier(int idCaserne, DataTable enginNecessaire)
        {
            //Liste de pompier qui pourraient participer à la mission 
            List<int[]> listePompierNecessaire = new List<int[]>();

            DataTable enginHab = new DataTable();
            enginHab.Columns.Add("codeTypeEngin", typeof(string));
            enginHab.Columns.Add("idHabilitation", typeof(int));
            enginHab.Columns.Add("nombre", typeof(int));

            foreach(DataRow engin in enginNecessaire.Rows)
            {
                string codeTypeEngin = engin["codeTypeEngin"].ToString();

                // Récupère les habilitations pour ce type d'engin
                DataRow[] habilites = monDs.Tables["Embarquer"].Select($"codeTypeEngin = '{codeTypeEngin}'");
                foreach(DataRow hab in habilites)
                {
                    enginHab.ImportRow(hab);
                }

                // Filtrons ceux appartenant à la caserne ET qui ne sont pas encore utilisés

                foreach(DataRow habilitation in habilites)
                {
                    //Après avoir l'habilitation, regarder dans la table Passer les idPompier qui ont passé cette habilitation
                    int idhab = Convert.ToInt32(habilitation["idHabilitation"]);
                    DataRow[] pompierhab = monDs.Tables["Passer"].Select($"idHabilitation = {idhab}");

                    // Récuprer les pompiers qui sont dans la caserne

                    foreach(DataRow pomp in pompierhab)
                    {
                        int idPompier = Convert.ToInt32(pomp["matriculePompier"]);
                        DataRow[] pompierCaserne = monDs.Tables["Affectation"].Select($"idCaserne = {idCaserne} AND matriculePompier = {idPompier}");
                        foreach(DataRow pompierTrier in pompierCaserne)
                        {
                            int[] ligne = new int[] { idPompier, idhab };
                            listePompierNecessaire.Add(ligne);
                        }
                    }

                }
            }

            dtEngin = enginHab;

            // Trier la liste des pompiers par nombre croissant d'habilitations
            listePompierNecessaire = trierTab(listePompierNecessaire);
            pompIdHab = listePompierNecessaire;

            bool equipeCompletePossible = true;

            //Liste de pompier attribué a un véhicule pour éviter les doublons
            List<int> listePompier = new List<int>();

            // Vérifie si on peut envoyer une équipe complète
            int i = 0;
            while(i < enginHab.Rows.Count && equipeCompletePossible)
            {
                DataRow engin = enginHab.Rows[i];   // Stocker dans un DataRow 
                int idHabilitation = Convert.ToInt32(engin["idHabilitation"]);
                int nombreRequis = Convert.ToInt32(engin["nombre"]);
                int nombreAttribués = 0;

                int j = 0;
                while(j < listePompierNecessaire.Count && nombreAttribués < nombreRequis)
                {
                    int[] tab = listePompierNecessaire[j];
                    if(tab[1] == idHabilitation && !listePompier.Contains(tab[0]))
                    {
                        listePompier.Add(tab[0]);
                        nombreAttribués++;
                    }
                    j++;
                }

                if(nombreAttribués < nombreRequis)
                {
                    equipeCompletePossible = false;
                }

                i++;
            }

            if(equipeCompletePossible)
            {
                return true; // Équipe complète possible
            }

            // Sinon, tentative d’équipe incomplète : 1 pompier minimum par habilitation
            listePompier.Clear();

            i = 0;
            bool equipeMinimumPossible = true;
            while(i < enginHab.Rows.Count && equipeMinimumPossible)
            {
                DataRow engin = enginHab.Rows[i];
                int idHabilitation = Convert.ToInt32(engin["idHabilitation"]);
                bool trouve = false;

                int j = 0;
                while(j < listePompierNecessaire.Count && !trouve)
                {
                    int[] tab = listePompierNecessaire[j];
                    if(tab[1] == idHabilitation && !listePompier.Contains(tab[0]))
                    {
                        listePompier.Add(tab[0]);
                        trouve = true;
                    }
                    j++;
                }

                if(!trouve)
                {
                    equipeMinimumPossible = false;
                }

                i++;
            }

            return equipeMinimumPossible;
        }

        private DataTable remplissageEngin(int idSinistre, int idCaserne)
        {
            DataTable enginNecessaire = enginMission(idSinistre);
            DataTable dt = new DataTable();
            dt.Columns.Add("TypeEngin");
            dt.Columns.Add("Numero", typeof(int));
            foreach(DataRow dr in enginNecessaire.Rows)
            {
                string typeEngin = dr["codeTypeEngin"].ToString();
                int nbMinEngin = Convert.ToInt32(dr["nombre"]);

                // Vérifie les engins disponibles pour ce type dans la caserne
                DataRow[] enginsDispo = monDs.Tables["Engin"].Select(
                    $"idCaserne = {idCaserne} AND codeTypeEngin = '{typeEngin}' AND enMission = 0 AND enPanne = 0");

                int nbEnginDispo = enginsDispo.Length;

                int res = (nbEnginDispo < nbMinEngin) ? nbEnginDispo : nbMinEngin;

                // Choisir les nbMinEngin premiers engins
                for(int i = 0; i < res; i++)
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

        private DataTable remplissagePompier(int idCaserne, DataTable enginsNecessaires)
        {
            DataTable dtPompiersMobilises = new DataTable();
            dtPompiersMobilises.Columns.Add("Matricule", typeof(int));
            dtPompiersMobilises.Columns.Add("idHabilitation", typeof(int));
            List<int> listePompier = new List<int>();


            foreach(DataRow engin in dtEngin.Rows)
            {
                int idHabilitation = Convert.ToInt32(engin["idHabilitation"]);
                int nombre = equipeCompletePossible ? Convert.ToInt32(engin["nombre"]) : 1;
                int nbTrouve = 0;
                foreach(int[] tab in pompIdHab)
                {
                    if(tab[1] == idHabilitation && !listePompier.Contains(tab[0]) && nbTrouve < nombre)
                    {
                        nbTrouve++;
                        listePompier.Add(tab[0]);
                        dtPompiersMobilises.Rows.Add(tab[0], idHabilitation);
                    }
                }
            }

            //mettre en mission les pompiers dans mon DataSet
            foreach(DataRow pompierMission in monDs.Tables["Pompier"].Rows)
            {
                int matricule = Convert.ToInt32(pompierMission["matricule"]);
                for(int i = 0; i < listePompier.Count; i++)
                {
                    if(matricule == listePompier[i])
                    {
                        pompierMission["enMission"] = 1;
                    }
                }
            }

            remplirMobiliser(dtPompiersMobilises);

            return dtPompiersMobilises;
        }

        private void remplirMobiliser(DataTable dtPompierMobilise)
        {
            // ajout des lignes dans la table mobiliser
            foreach(DataRow dr in dtPompierMobilise.Rows)
            {
                DataRow ligne = monDs.Tables["Mobiliser"].NewRow();
                ligne["matriculePompier"] = Convert.ToInt32(dr["Matricule"]);
                ligne["idMission"] = Convert.ToInt32(nextId);
                ligne["idHabilitation"] = Convert.ToInt32(dr["idHabilitation"]);

                monDs.Tables["Mobiliser"].Rows.Add(ligne);
            }
        }


        private void generationUC(int idSinistre, int idCaserne)
        {
            DataTable Engin = remplissageEngin(idSinistre, idCaserne);
            DataTable Pompier = remplissagePompier(idCaserne, enginMission(idSinistre));
            int top = 10;
            int left = 5;
            foreach(DataRow dr in Engin.Rows)
            {
                string code = "Type d'engin : " + dr["TypeEngin"].ToString();
                string id = "Numéro de l'engin : " + dr["Numero"].ToString();

                UC_MobilisationEnginPompier engin = new UC_MobilisationEnginPompier(code, id);

                engin.Top = top;
                engin.Left = left;
                engin.AutoSize = true;

                pnlEngin.Controls.Add(engin);
                top += engin.Height + 10;
            }
            top = 10;
            foreach(DataRow dr in Pompier.Rows)
            {
                string matricule = "Matricule du pompier : " + dr["Matricule"].ToString();
                string id = "L'habilitation associée : " + dr["idHabilitation"].ToString();

                UC_MobilisationEnginPompier pompier = new UC_MobilisationEnginPompier(matricule, id);

                pompier.Top = top;
                pompier.Left = left;
                pompier.AutoSize = true;

                pnlPompier.Controls.Add(pompier);
                top += pompier.Height + 10;
            }

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


        private void btnNvMission_Click(object sender, EventArgs e)
        {
            erp.Clear();
            btnNvMission.Visible = false;
            btnValider.Visible = true;
            btnAnnuler.Visible = true;

            grpMob.Visible = false;
            pnlEngin.Controls.Clear();
            pnlPompier.Controls.Clear();

            txtMotif.Enabled = true;
            txtRue.Enabled = true;
            txtVille.Enabled = true;
            txtCP.Enabled = true;
            cboCaserne.Enabled = true;
            cboNature.Enabled = true;

            initialiser();

            nextId++;
            date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            lblNumMission.Text = "Mission n°" + nextId.ToString();
            lblDate.Text = "déclenchée le : " + date;
        }


    }
}
