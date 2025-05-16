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
            ChargementCbo(monDs.Tables["NatureSinistre"], "libelle", "id", cboNature);
            ChargementCbo(monDs.Tables["Caserne"], "nom", "id", cboCaserne);

            //le numéro + date de la prochaine mission
            nextId = monDs.Tables["Mission"].Rows.Count + 1;
            date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            lblNumMission.Text = "Mission n°"+ nextId.ToString();
            lblDate.Text = "déclenchée le : " + date;
        }

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

        /*
         * lblNumMission.Text = "Mission n°" + nextId.ToString();
            date = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            lblDate.Text = "déclenchée le : " + date;
            initialiser();
         */

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

            btnAnnuler.Visible = false;
            btnValider.Visible = false;

            //UC gried view
            grpMob.Visible = true;
            DataTable dtEngin = remplissageEngin(monDs, idSinistre, idCaserne);
            UC_MobilisationEnginPompier dgvEngin = new UC_MobilisationEnginPompier(dtEngin);
            //ajout dans le grp box
            grpMob.Controls.Add(dgvEngin);

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

        //créer une table pour stockage des types des diff engins qui sont nécessaires à la mission(avoir le numéro et le type)
        private DataTable enginMission(DataSet monDs, int idSinistre, int idCaserne)
        {
            DataRow[] tab = monDs.Tables["Necessiter"].Select("idNatureSinistre = " + idSinistre);
            DataTable dtEngins = new DataTable();
            dtEngins.Columns.Add("Type d'engin");
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

        
        private DataTable remplissageEngin(DataSet monDs, int idSinistre, int idCaserne)
        {
            DataTable dtEngins = enginMission(monDs, idSinistre, idCaserne);

            /*
             * mtn engin de la caserne selectionnée
             * Si l’un des engins requis n’est pas disponible dans la caserne choisie initialement,
             * on attribuera la mission à l’une des trois autres casernes.               
            */
            
            DataTable dt = new DataTable();
            dt.Columns.Add("Type d'engin");
            dt.Columns.Add("Numéro", typeof(int));
            int numero = 0;
            foreach (DataRow lg1 in dtEngins.Rows)
            {
                string tpengin = lg1["Type d'engin"].ToString();

                DataRow[] lignes = monDs.Tables["Engin"].Select("codeTypeEngin = '" + tpengin + "' " +
                    "AND idCaserne = " + idCaserne +
                    "AND enMission = 0 " +
                    "AND enPanne = 0 ");
                for (int i=0; i< lignes.Length; i++)
                {
                    //choisi le num du véhicule et le type -> le rajoute à la datatable dt
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
                monDs.Tables["PartirAvec"].Rows.Add(idCaserne, tpengin, numero, nextId, null);
            }



            return dt;

        }

        private DataTable remplissagePompier(DataSet monDs, int idSinistre, int idCaserne) 
        {
            DataTable dtPomp = new DataTable();

            DataTable dtEngins = enginMission(monDs, idSinistre, idCaserne);

            //Stockage des hab pour chaque engin nécessaire à la mission
            DataTable tab = new DataTable();
            tab.Columns.Add("Type d'engin");
            tab.Columns.Add("idHabilitation");
            tab.Columns.Add("nombre", typeof(int));

            //habilitation a stocker
            List<int> listHab = new List<int>();

            foreach (DataRow dr in dtEngins.Rows) 
            {
                //parcourir la table quel engin est relié à quelle habilitation
                foreach (DataRow dr1 in monDs.Tables["Embarquer"].Rows)
                {
                    if (dr1["codeTypeEngin"] == dr["Type d'engin"])
                    {
                        listHab.Add(Convert.ToInt32(dr1["idHabilitation"]));
                    }
                }
            }

            //les matricules qui sont affcetés à la caserne idCaserne
            foreach (DataRow dr2 in monDs.Tables["Affectation"].Rows) 
            {
                if ( Convert.ToInt32(dr2["idCaserne"]) == idCaserne)
                {
                    // voir si la matricule a passer l'habilitation dans la table Passer
                    foreach(DataRow dr3 in monDs.Tables["Passer"].Rows)
                    {
                        if (dr2["matriculePompier"] == dr3["matriculePompier"])
                        {
                            //list hab à tester puis le mettre dans la table (par rapport aux nombres de hab nécessaire)
                        }
                    }
                }
            }
            
            
            foreach (int elem in listHab) 
            {

            }


            return dtPomp;
        }



    }
}
