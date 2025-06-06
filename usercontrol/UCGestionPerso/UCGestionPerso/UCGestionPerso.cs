using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCGestionPerso
{
    public delegate void validateLogin(Dictionary<string, string> KeyLogin);

    public partial class UCGestionPerso : UserControl
    {
        SQLiteConnection _con;
        UCLogin login;

        //chemin
        string chemin = Path.Combine(Application.StartupPath, "ImagesGrades");

        int idCaserneInit;
        string codeGradeInit;
        bool dateF;
        int enCongeInit;

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
                //On remplit le panel avec des boutons (Caserne)
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

                //On charge nos combobox 
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

            grpCaserne.Visible = false;
            grpContact.Visible = false;
            grpIdentite.Visible = false;
            lblMatricule.Visible = false;
            btnInfo.Visible = false;

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

                    string cmdGrade = $@"SELECT codeGrade FROM Pompier WHERE matricule = {id}";
                    SQLiteCommand cd2 = new SQLiteCommand(cmdGrade, _con);
                    string grade = (string)cd2.ExecuteScalar();

                    string photo = Path.Combine(chemin, $"{grade}.png");
                    Image monImage = Image.FromFile(photo);
                    UCRichButton btn = new UCRichButton(nom, id.ToString(), monImage);
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
                lblMatricule.Tag = id;

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
                    codeGradeInit = codeGrade;
                    cboGrade.SelectedValue = codeGrade;

                    if (enConge == 1) {
                        chbConge.Checked = true;
                        enCongeInit = 1;
                    }
                    lblDateEmbauche.Text = dr.GetString(11);
                }
                dr.Close();


                ///Affectations
                string cmdCaserne = $@"SELECT * FROM Affectation WHERE matriculePompier = "+id+" ORDER BY dateA";
                SQLiteCommand cd1 = new SQLiteCommand(cmdCaserne, _con);
                SQLiteDataReader dr1 = cd1.ExecuteReader();

                int idCaserne=0;

                while (dr1.Read())
                {
                    string affectation = "";
                    if (!dr1.IsDBNull(2))
                    {
                        dateF = true; //il existe une date fin

                        DateTime dateNow = DateTime.Now;
                        DateTime dateFin = DateTime.ParseExact(dr1.GetString(2), "yyyy-MM-dd", CultureInfo.InvariantCulture);

                        int comp = DateTime.Compare(dateNow, dateFin);

                        if (dr1.GetString(2) == null || comp > 0)
                        {
                            idCaserne = dr1.GetInt32(3);
                            affectation  += dr1.GetString(1);
                        }
                    }
                    else
                    {
                        dateF = false; 
                        idCaserne = dr1.GetInt32(3);
                        affectation += dr1.GetString(1);
                    }
                    cboCaserne.SelectedValue = idCaserne;
                    affectation += " " + cboCaserne.Text;

                    rtbAffec.Text += affectation + "\n";
                }
                dr1.Close();
                idCaserneInit = idCaserne;

                ///Habilitations
                string cmdHab = $@"SELECT * FROM Passer WHERE matriculePompier = {id}";
                SQLiteCommand cd2 = new SQLiteCommand(cmdHab, _con);
                SQLiteDataReader dr2 = cd2.ExecuteReader();

                while (dr2.Read())
                {
                    string rq = $@"SELECT libelle FROM Habilitation WHERE id = {dr2.GetInt32(1)}";
                    SQLiteCommand cm = new SQLiteCommand(rq, _con);
                    string nom = (string) cm.ExecuteScalar();
                    
                    string hab = nom.Split('-')[0];

                    rtbHab.Text += hab + " " + dr2.GetString(2) + "\n";
                }

                string photo = Path.Combine(chemin, $"{codeGradeInit}.png");
                pic.Image = Image.FromFile(photo);

                if (login.Connected)
                {
                    btnChanger.Visible = true;
                    cboCaserne.Enabled = true;
                    cboGrade.Enabled = true;
                    chbConge.Enabled = true;
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
            grpCaserne.Visible = false;

        }

        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGrade.SelectedIndex != -1)
            {
                txtGradeCode.Text = cboGrade.SelectedValue.ToString();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (login.Connected)
            {
                MessageBox.Show("Vous devez être connecté pour pouvoir créer un pompier !");
                return;
            }

            frmCreationPompier creerPompier = new frmCreationPompier(_con);
            DialogResult res = creerPompier.ShowDialog();

            if (res == DialogResult.OK) 
            {
                MessageBox.Show("Vous avez créer un nouveau pompier");
            }
        }

        private void btnChanger_Click(object sender, EventArgs e)
        {
            SQLiteTransaction transaction = null;
            transaction = _con.BeginTransaction();

            try
            {
                int id = Convert.ToInt32(lblMatricule.Tag);

                int enConge = 0;
                if (chbConge.Checked)
                {
                    enConge = 1;
                }

                int idCaserne = Convert.ToInt32(cboCaserne.SelectedValue);
                string codeGrade = txtGradeCode.Text;

                if (codeGrade != codeGradeInit || enCongeInit!=enConge) 
                {
                    SQLiteCommand cmdTabPompier = new SQLiteCommand($@"UPDATE Pompier SET enConge = {enConge}, codeGrade = '{codeGrade}' WHERE matricule = {id}", _con, transaction);
                    cmdTabPompier.ExecuteNonQuery();

                    MessageBox.Show("Les données ont bien été mises à jour.");

                    codeGradeInit = codeGrade;
                    enCongeInit = enConge;
                }

                if (idCaserne != idCaserneInit)
                {
                    string date = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                    if (!dateF)
                    {
                        SQLiteCommand cmdAffectation = new SQLiteCommand($@"UPDATE Affectation SET dateFin = '{date}' WHERE matriculePompier = {id} AND idCaserne = {idCaserneInit}", _con, transaction);
                        cmdAffectation.ExecuteNonQuery();
                    }
                    idCaserneInit = idCaserne;

                    SQLiteCommand cmdAffectationAdd = new SQLiteCommand($@"INSERT INTO Affectation (matriculePompier, dateA, idCaserne) VALUES ({id}, '{date}', {idCaserneInit})", _con, transaction);
                    cmdAffectationAdd.ExecuteNonQuery();

                    MessageBox.Show("Le pompier a bien été affecté à une caserne.");
                }

                transaction.Commit();
            }
            catch (SQLiteException ex)
            {
                if (ex.ResultCode == SQLiteErrorCode.Constraint)
                {
                    MessageBox.Show("Erreur : Vous ne pouvez pas affecter le pompier à une autre caserne le même jour!");
                }
                else
                {
                    MessageBox.Show("Erreur SQLite : " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                transaction.Dispose();
            }
        }
    }
}
