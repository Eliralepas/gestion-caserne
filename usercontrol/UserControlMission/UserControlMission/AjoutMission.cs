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
            row["idNatureSinistre"] = Convert.ToInt32(cboNature.SelectedValue);
            row["idCaserne"] = Convert.ToInt32(cboCaserne.SelectedValue);

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
            ucMobil.Visible = true;

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
