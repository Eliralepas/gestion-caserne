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
    public partial class ucMission: UserControl
    {
        public ucMission()
        {
            InitializeComponent();
        }

        DataSet monDs;
        int nextId;
        String date;

        public ucMission(DataSet ds)
        {
            InitializeComponent();
            monDs = ds;
            ChargementCbo(monDs.Tables["NatureSinistre"], "id", "libelle", cboNature);
            ChargementCbo(monDs.Tables["Caserne"], "id", "nom", cboCaserne);

            //le numéro + date de la prochaine mission
            nextId = monDs.Tables["Mission"].Rows.Count + 1;
            date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            lblNumMission.Text = lblNumMission.Text + nextId.ToString();
            lblDate.Text += date.ToString();
        }

        //Ajout de contrainte

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) && txtCP.Text.Length<5)
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char) Keys.Enter || e.KeyChar == (char)Keys.Back) { e.Handled = false; }
        }

        private void txtVille_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back || Char.IsLetter(e.KeyChar)) { e.Handled = false; }
            if (txtVille.SelectionStart != 0 && e.KeyChar == ' ') {  e.Handled = false; }
            if (e.KeyChar == '-' && txtVille.SelectionStart != 0) { e.Handled = false; }
        }

        private void ChargementCbo(DataTable dt, String col1, String col2, ComboBox c) {
            c.Items.Clear();
            c.DataSource = dt;
            c.DisplayMember = col1;
            c.ValueMember = col2;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Ajout dans maTableLocal local mais pas directement dans la base de données
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

            //Nouvelle mission avec une nouvelle Date et Heure
            nextId++;
            lblNumMission.Text = "Mission n°" + nextId.ToString();
            date = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            lblDate.Text = "déclenchée le : " + date;
            initialiser();
            btnAnnuler.Visible = false;
            btnValider.Visible = false;

            //UC gried view

            grpMob.Visible = true;

            DataTable dtEngin = remplissageEngin(monDs, idSinistre, idCaserne); 
            UC_MobilisationEnginPompier dgvEngin = new UC_MobilisationEnginPompier(dtEngin);
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

        
        private DataTable remplissageEngin(DataSet monDs, int idSinistre, int idCaserne)
        {
            DataRow[] tab = monDs.Tables["Necessiter"].Select("idNatureSinistre = " + idSinistre);

            //créer une table pour stockage des types des diff engins (avoir le numéro et le type)
            DataTable dtEngins = new DataTable();
            dtEngins.Columns.Add("Type d'engin");
            dtEngins.Columns.Add("nombre", typeof(int));

            string typeEngin;
            int nombre=0;
            foreach (DataRow ligne in tab)
            {
                typeEngin = ligne["codeTypeEngin"].ToString();
                nombre = Convert.ToInt32(ligne["nombre"]);
                // Ajouter dans la table
                dtEngins.Rows.Add(typeEngin, nombre);
            }

            /*
             * mtn engin de la caserne selectionnée
             * Si l’un des engins requis n’est pas disponible dans la caserne choisie initialement,
             * on attribuera la mission à l’une des trois autres casernes.
             * 
             * Tables qui changent : Engin (en mission) : Fait
             *                       Ajout ligne dans Partir avec : Fait                    
            */
            
            DataTable dt = new DataTable();
            dt.Columns.Add("Type d'engin");
            dt.Columns.Add("Numéro", typeof(int));
            int numero=0;
            foreach (DataRow lg1 in dtEngins.Rows)
            {
                string tpengin = lg1["Type d'engin"].ToString();

                DataRow[] lignes = monDs.Tables["Engin"].Select("codeTypeEngin = '" + tpengin + "' " +
                    "AND idCaserne = " + idCaserne +
                    "AND enMission = 0 " +
                    "AND enPanne = 0 ");
                for (int i=0; i<nombre; i++)
                {
                    //choisi le nombre de véhicule
                    numero = Convert.ToInt32(lignes[i]["numero"]);
                    dt.Rows.Add(tpengin, numero);

                    //Parcourir le tab Engin et changer la ligne correspondant au numero et type et idCaserne
                    foreach (DataRow lg2 in monDs.Tables["Engin"].Rows)
                    {
                        if ((Convert.ToInt32(lg2["numéro"]) == numero) 
                            && (lg2["codeTypeEngin"].ToString() == tpengin) 
                            && (Convert.ToInt32(lg2["idCaserne"]) == idCaserne))
                        {
                            lg2["enMission"] = 1; // 1 car il est maintenant en mission
                        }
                    }
                }

                //Ajout ligne dans Partir avec : idcaserne, codeTypeEngin, numeroEngin, idMission
                monDs.Tables["PartirAvec"].Rows.Add(idCaserne, tpengin, numero, nextId);
            }


            return dt;

        }


        /*
         * Tables a utiliser : Embarquer 
         * 
         * Les tables à modifier: Mobiliser 
         * 
         * 
         * 
        */

        private DataTable remplissagePompier(DataSet monDs, int idSinistre, int idCaserne) 
        {
            DataTable dtPomp = new DataTable();
            return dtPomp;
        }



    }
}
