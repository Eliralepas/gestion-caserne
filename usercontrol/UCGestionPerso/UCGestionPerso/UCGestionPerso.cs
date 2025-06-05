using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using System.Globalization;

namespace UCGestionPerso
{
    public delegate void validateLogin(Dictionary<string, string> KeyLogin);

    public partial class UCGestionPerso : UserControl
    {
        SQLiteConnection _con;
        UCLogin login;


        private UCRichButton Selected;
        public bool Connected
        {
            get { return login != null && login.Connected; }
            set { if(login != null) login.Connected = value; }
        }

        public validateLogin validateLoginDel;

        public UCGestionPerso()
        {
            InitializeComponent();
        }

        public UCGestionPerso(SQLiteConnection con) : base()
        {
            InitializeComponent();
            _con = con;
            login = new UCLogin();

            if(con.State == ConnectionState.Closed)
            {
                throw new Exception("Illegal argument : La connexion doit être ouverte 😒");
            }
        }

        private void UCGestionPerso_Load(object sender, EventArgs e)
        {
            try
            {
                string caserneCommand = "SELECT nom, id FROM Caserne";
                SQLiteCommand cmd = new SQLiteCommand(caserneCommand, _con);
                SQLiteDataReader data = cmd.ExecuteReader();

                while(data.Read())
                {
                    string nom = data.GetString(0);
                    string id = data.GetValue(1).ToString();

                    UCRichButton btn = new UCRichButton(nom);
                    btn.Tag = id;
                    btn.clickReturnTag += btnClick;

                    flpCaserne.Controls.Add(btn);
                }

                ChargercboGrade();
                ChargercboCaserne();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClick(UCRichButton clicked,object tag)
        {
            if(Selected != null)
            {
                Selected.isSelected = false;
                Selected.BackColor = Color.White;
            }
            clicked.isSelected = true;
            Selected = clicked;
            refreshPompier();

        }

        private void btnClickPompier(UCRichButton clicked,object tag)
        {
            if (Selected != null)
            {
                Selected.isSelected = false;
                Selected.BackColor = Color.White;
            }
            clicked.isSelected = true;
            Selected = clicked;
            formPompier();
        }


        private void refreshPompier()
        {
            try
            {
                flpPompier.Controls.Clear();
                string cmdPompier = $@"SELECT matriculePompier FROM Affectation WHERE idCaserne = {Selected.Tag}";
                SQLiteCommand cd = new SQLiteCommand(cmdPompier, _con);
                SQLiteDataReader dr = cd.ExecuteReader();

                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string cmdNom = $@"SELECT CONCAT(prenom, ' ', nom) FROM Pompier WHERE matricule = {id}";
                    SQLiteCommand cd1 = new SQLiteCommand(cmdNom, _con);
                    string nom = (string) cd1.ExecuteScalar();

                    UCRichButton btn = new UCRichButton(nom, id.ToString());
                    btn.Tag = id;
                    btn.clickReturnTag += btnClickPompier;

                    flpPompier.Controls.Add(btn);
                }
                dr.Close();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur : connexion fermée !");
            }
            catch (SQLiteException)
            {
                MessageBox.Show("Erreur dans la requête SQL !");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally { }
        }

        private void formPompier()
        {
            try
            {
                InitPompierInfo();
                grpIdentite.Visible = true;
                grpContact.Visible = true;
                lblMatricule.Visible = true;
                btnInfo.Visible = true;

                int id = Convert.ToInt32(Selected.Tag);
                lblMatricule.Text = "Matricule "+id;

                string requete = $@"SELECT * FROM Pompier WHERE matricule = {id}";
                SQLiteCommand cd = new SQLiteCommand(requete, _con);
                SQLiteDataReader dr = cd.ExecuteReader();


                while (dr.Read())
                {
                    lblNom.Text = dr.GetString(1);
                    lblPrenom.Text = dr.GetString(2);
                    lblSexe.Text = dr.GetString(3);
                    lblDateNaissance.Text = dr.GetString(4);
                    string type = dr.GetString(5);
                    if (type == "p")
                    {
                        rdbPro.Checked = true;
                    }
                    else if (type == "v")
                    {
                        rdbVolontaire.Checked = true;
                    }
                    lblTel.Text = dr.GetString(6);
                    lblBip.Text = dr.GetInt32(7).ToString();
                    int enConge = dr.GetInt32(9);
                    string codeGrade = dr.GetString(10);
                    txtGradeCode.Text = codeGrade;
                    cboGrade.SelectedValue = codeGrade;
                    if (enConge == 1) {
                        chbConge.Checked = true;
                    }

                }
                dr.Close();



                string cmdCaserne = $@"SELECT * FROM Affectation WHERE matriculePompier = "+id+" ORDER BY dateA";
                SQLiteCommand cd1 = new SQLiteCommand(cmdCaserne, _con);
                SQLiteDataReader dr1 = cd1.ExecuteReader();

                int idCaserne=0;

                while (dr1.Read())
                {
                    string affectation = "";
                    lblDateEmbauche.Text = "X";

                    if (!dr1.IsDBNull(2))
                    {
                        DateTime dateNow = DateTime.Now;
                        DateTime dateFin = DateTime.ParseExact(dr1.GetString(2), "yyyy-MM-dd", CultureInfo.InvariantCulture);

                        int comp = DateTime.Compare(dateNow, dateFin);

                        if (dr1.GetString(2) == null || comp > 0)
                        {
                            idCaserne = dr1.GetInt32(3);
                            lblDateEmbauche.Text = dr1.GetString(1);

                            affectation  += dr1.GetString(1);
                        }
                    }
                    else
                    {
                        idCaserne = dr1.GetInt32(3);
                        lblDateEmbauche.Text = dr1.GetString(1);
                        affectation += dr1.GetString(1);
                    }
                    cboCaserne.SelectedValue = idCaserne;
                    affectation += cboCaserne.Text;

                    rtbAffec.Text += " " + affectation + "\n";
                }
                dr1.Close();
                

                if (login.Connected)
                {

                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur : la connexion est fermé !");
            }
            catch (SQLiteException)
            {
                MessageBox.Show("Erreur dans la requête SQL !");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally { }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            grpCaserne.Visible = true;
            btnInfo.Visible = false;
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

        private void InitPompierInfo()
        {
            
            //Info
            lblNom.Text = String.Empty;
            lblPrenom.Text = String.Empty;
            lblMatricule.Text = String.Empty;
            lblSexe.Text = String.Empty;
            lblDateNaissance.Text = String.Empty;
            lblDateEmbauche.Text = String.Empty;
            rdbPro.Checked = false;
            rdbVolontaire.Checked = false;

            //Contact
            lblBip.Text = String.Empty;
            lblTel.Text = String.Empty;

            //Carrière
            txtGradeCode.Text = String.Empty;
            cboCaserne.SelectedIndex = -1;
            cboGrade.SelectedIndex = -1;
            rtbAffec.Text = String.Empty;
            rtbHab.Text = String.Empty;
            chbConge.Checked = false;

        }

        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
