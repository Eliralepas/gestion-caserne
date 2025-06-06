using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCGestionPerso
{
    public partial class frmCreationPompier : Form
    {
        public SQLiteConnection _con;

        public frmCreationPompier(SQLiteConnection con)
        {
            InitializeComponent();
            _con = con;
        }

        private void frmCreationPompier_Load(object sender, EventArgs e)
        {
            try
            {
                string cmdMatricule = $@"SELECT MAX(matricule) FROM Pompier";
                SQLiteCommand cd = new SQLiteCommand(cmdMatricule, _con);
                int matricule = Convert.ToInt32(cd.ExecuteScalar());
                matricule++;

                lblMatricule.Text += matricule;
                lblMatricule.Tag = matricule;
                ChargercboCaserne();
                ChargercboGrade();

                dtpC.MinDate = DateTime.Now.AddDays(15);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            string texteActuel = tb.Text;
            int pos = tb.SelectionStart;

            e.Handled = true;

            if (e.KeyChar == (char) Keys.Back)
            {
                e.Handled = false;
            }

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            if (e.KeyChar == ' ' || e.KeyChar == '-')
            {
                e.Handled = false;
                
                // Pas en premier caractère
                if (pos == 0)
                {
                    e.Handled = true;
                }

                // Pas deux espaces/tirets consécutifs
                if ((pos > 0 && (texteActuel[pos - 1] == ' ' || texteActuel[pos - 1] == '-')))
                {
                    e.Handled = true;
                }
            } 
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //creer pompier 
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            string nom = ti.ToTitleCase(txtNom.Text.ToLower()); ;
            string prenom = ti.ToTitleCase(txtPrenom.Text.ToLower());

            string sexe="";
            if (rdbFemme.Checked)
            {
                sexe = "f";
            }
            else if (rdbHomme.Checked)
            {
                sexe = "m";
            }

            string type = "";
            if (rdbPro.Checked)
            {
                type = "p";
            }
            else if (rdbVolontaire.Checked)
            {
                type = "v";
            }

            string dateN = dtpN.Value.ToString("yyyy-MM-dd");
            int matricule = Convert.ToInt32(lblMatricule.Tag);
            int bip = matricule;

            string codeGrade = cboGrade.SelectedValue.ToString();
            int codeCaserne = Convert.ToInt32(cboCaserne.SelectedValue);
            string dateE = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            string tel = null;
            if (txtTel.Text != String.Empty)
            {
                tel = txtTel.Text;
                
            }

            string dateC = null;
            if (dtpC.Visible)
            {
                dateC = dtpC.Value.ToString("yyyy-MM-dd");
            }

            string requete = "";
            if (tel == null)
            {
                requete = $@"INSERT INTO Pompier VALUES ({matricule}, '{nom}', '{prenom}', '{sexe}', '{dateN}', '{type}', NULL, {bip}, 0, 0, '{codeGrade}', '{dateE}')";
            }
            else if (tel != null)
            {
                requete = $@"INSERT INTO Pompier VALUES ({matricule}, '{nom}', '{prenom}', '{sexe}', '{dateN}', '{type}', '{tel}', {bip}, 0, 0, '{codeGrade}', '{dateE}')";
            }
            SQLiteCommand cd = new SQLiteCommand(requete, _con);
            cd.ExecuteNonQuery();

            string requete1 = "";
            if (dateC == null)
            {
                requete1 = $@"INSERT INTO Affectation VALUES ({matricule}, '{dateE}', NULL, {codeCaserne})";
            }
            else if (dateC != null)
            {
                requete1 = $@"INSERT INTO Affectation VALUES ({matricule}, '{dateE}', '{dateC}', {codeCaserne})";
            }
            SQLiteCommand cd1 = new SQLiteCommand(requete1, _con);
            cd1.ExecuteNonQuery();

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //Annuler
            this.Close();
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            e.Handled = true;

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            if (tb.Text.Length >= 10)
            {
                e.Handled = true;
            }

            if (e.KeyChar != '0' && tb.SelectionStart == 0)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '0' && tb.SelectionStart == 1)
            {
                e.Handled = true;
            }
        }

        private void ChargementCbo(DataTable dt, String col1, String col2, ComboBox c)
        {
            c.Items.Clear();
            c.DataSource = dt;
            c.DisplayMember = col1;
            c.ValueMember = col2;
        }

        private void ChargercboGrade()
        {
            string cmdGrade = $@"SELECT code, libelle FROM Grade";
            SQLiteCommand cd1 = new SQLiteCommand(cmdGrade, _con);
            SQLiteDataReader dr1 = cd1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("code");
            dt.Columns.Add("libelle");
            while (dr1.Read())
            {
                DataRow ligne = dt.NewRow();
                ligne[0] = dr1.GetString(0);
                ligne[1] = dr1.GetString(1);
                dt.Rows.Add(ligne);
            }
            dr1.Close();
            ChargementCbo(dt, "libelle", "code", cboGrade);
        }

        private void ChargercboCaserne()
        {
            string cmdCaserne = $@"SELECT * FROM Caserne";
            SQLiteCommand cd1 = new SQLiteCommand(cmdCaserne, _con);
            SQLiteDataReader dr1 = cd1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nom");
            while (dr1.Read())
            {
                DataRow ligne = dt.NewRow();
                ligne[0] = dr1.GetInt32(0);
                ligne[1] = dr1.GetString(1);
                dt.Rows.Add(ligne);
            }
            dr1.Close();
            ChargementCbo(dt, "nom", "id", cboCaserne);
        }

        private void btnDateF_Click(object sender, EventArgs e)
        {
            lblDateFin.Visible = true;
            dtpC.Visible = true;
            btnDateF.Visible = false;
            btnAnnulDateF.Visible = true;
        }

        private void btnAnnulDateF_Click(object sender, EventArgs e)
        {
            lblDateFin.Visible = false;
            dtpC.Visible = false;
            btnDateF.Visible = true;
            btnAnnulDateF.Visible=false;
        }
    }
}
