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
using System.Security.Cryptography;
using Polygon;
using System.Data.Common;
using System.Data.SqlClient;

namespace UC_Statistique
{
    public partial class Statistique : UserControl
    {
        private SQLiteConnection _con; // connection utilisé pour récupere les statistiques
        private Color[] colors = new Color[] { Color.Blue, Color.Green, Color.Red, Color.Yellow, Color.Purple, Color.Black, Color.Fuchsia };

        public Statistique()
        {
            InitializeComponent();
        }

        public Statistique(SQLiteConnection con) : this()
        {
            if(con.State != ConnectionState.Open)
            {
                throw new ArgumentException("La connexion doit être ouverte");
            }
            _con = con;
            tabStatistique.SelectedTab = tabPage1;
            tabStatistique_SelectedIndexChanged(this, EventArgs.Empty); // Déclenchement automatique pour charger la première page
            cbxCaserne.Focus();
        }

        private void tabStatistique_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_con == null) return;
            switch(tabStatistique.SelectedTab)
            {
                case var tab when tab == tabPage1:
                    loadCaserne();
                    cbxCaserne.Focus();
                    break;
                case var tab when tab == tabPage2:
                    loadInterventionStat();
                    break;
                case var tab when tab == tabPage3:
                    loadHabilitation();
                    cbxHabilitation.Focus();
                    break;
                default:
                    MessageBox.Show("Onglet inconnu sélectionné");
                    break;
            }
        }

        private SQLiteDataReader executeDataReaderCommand(string command)
        {
            SQLiteCommand cmd = new SQLiteCommand(command, _con);
            return cmd.ExecuteReader();
        }

        /** Statistique Relatif a la caserne choisie */
        private void loadCaserne()
        {
            try
            {
                cbxCaserne.DataSource = null;
                string command = "SELECT [id] AS Id, [nom] AS Nom FROM Caserne;";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command, _con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cbxCaserne.DataSource = dt;
                cbxCaserne.DisplayMember = "Nom";
                cbxCaserne.ValueMember = "Id";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxCaserne.SelectedIndex == -1) return;
            
            loadEnginPerHour();
            loadMostUsedEngin();
        }

        private void loadEnginPerHour()
        {
            if(cbxCaserne.SelectedValue == null) return;

            int selectedId = Convert.ToInt32(cbxCaserne.SelectedValue);
            flpHistogram.Controls.Clear();

            try
            {
                string command = $@"
                                SELECT E.codeTypeEngin, E.numero,
                                IFNULL(ROUND(SUM((julianday(M.dateHeureRetour) - julianday(M.dateHeureDepart)) * 24), 2),0) AS cumul_heures
                                FROM Engin E
                                LEFT JOIN Partiravec P 
                                ON E.idCaserne = P.idCaserne 
                                AND E.codeTypeEngin = P.codeTypeEngin 
                                AND E.numero = P.numeroEngin 
                                LEFT JOIN Mission M 
                                ON P.idMission = M.id
                                WHERE E.idCaserne = @idCaserne
                                GROUP BY E.codeTypeEngin, E.numero
                                ORDER BY cumul_heures DESC;";

                SQLiteCommand cmd = new SQLiteCommand(command, _con);
                cmd.Parameters.AddWithValue("@idCaserne", selectedId);
                SQLiteDataReader dataReader = cmd.ExecuteReader();
                
                float maxValue = 0;
                Dictionary<string, float> EnginPerHour = new Dictionary<string, float>();
                while(dataReader.Read())
                {
                    string engin = dataReader.GetString(0) + " " + dataReader.GetInt32(1).ToString();
                    float heures = dataReader.GetFloat(2);
                    if(heures > maxValue) maxValue = heures;
                    EnginPerHour.Add(engin, heures);
                }
                foreach(KeyValuePair<string, float> eph in EnginPerHour)
                {
                    flpHistogram.Controls.Add(new histogram(eph.Key, eph.Value, maxValue, "heure Cumulé : "));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadMostUsedEngin()
        {
            flpMostUsedEngin.Controls.Clear();
            if(cbxCaserne.SelectedValue == null) return;

            int selectedId = Convert.ToInt32(cbxCaserne.SelectedValue);
            string command = $@"SELECT 
                                E.codeTypeEngin,
                                E.numero,
                                COUNT(P.idMission) AS nbMissions
                                FROM Engin E
                                LEFT JOIN PartirAvec P 
                                ON P.codeTypeEngin = E.codeTypeEngin 
                                AND P.numeroEngin = E.numero 
                                AND P.idCaserne = E.idCaserne
                                WHERE E.idCaserne = 1
                                GROUP BY E.codeTypeEngin, E.numero
                                ORDER BY nbMissions DESC;";

            SQLiteCommand cmd = new SQLiteCommand(command, _con);
            cmd.Parameters.AddWithValue("@caserneId", selectedId);
            SQLiteDataReader data = cmd.ExecuteReader();

            Dictionary<string, float> values = new Dictionary<string, float>();
            float mostUsed = 0;
            while(data.Read())
            {
                string engin = data.GetString(0) + " " + data.GetInt32(1).ToString();
                float heures = data.GetFloat(2);
                if(heures > mostUsed) mostUsed = heures;
                values.Add(engin, heures);
            }
            foreach(KeyValuePair<string, float> eph in values)
            {
                flpMostUsedEngin.Controls.Add(new histogram(eph.Key, eph.Value, mostUsed, "heure Cumulé : "));
            }
        }

        // Statistique relatif aux interventions
        private void loadInterventionStat()
        {
            flpSinistreStat.Controls.Clear();
            string command = $@"SELECT ns.libelle, Count(*) 
                             FROM NatureSinistre ns
                             JOIN Mission M ON M.idNatureSinistre = ns.id
                             GROUP BY ns.id;";
            SQLiteDataReader data = executeDataReaderCommand(command);

            float maxValue = 0;
            Dictionary<string, float> EnginPerHour = new Dictionary<string, float>();
            while(data.Read())
            {
                string sinistre = data.GetString(0);
                float nbIntervention = data.GetFloat(1);
                if(nbIntervention > maxValue) maxValue = nbIntervention;
                EnginPerHour.Add(sinistre, nbIntervention);
            }
            foreach(KeyValuePair<string, float> eph in EnginPerHour)
            {
                flpSinistreStat.Controls.Add(new histogram(eph.Key, eph.Value, maxValue, "Nombre de Sinistres : "));
            }
        }

        /* Statistique relatif aux Habilitation */
        private void loadHabilitation()
        {
            loadMostUsedHabilitation();
            loadPompierPerHabilitation();
        }

        private void loadMostUsedHabilitation()
        {
            pnlGrapheHabit.Controls.Clear();
            flpLegendHabi.Controls.Clear();
            string command = $@"SELECT h.libelle, Count(m.idMission)
                                FROM Habilitation h
                                JOIN Mobiliser m ON h.id = m.idHabilitation
                                GROUP BY h.libelle
                                ORDER by COUNT(m.idMission) DESC";

            Dictionary<string, int> values = new Dictionary<string, int>();
            SQLiteDataReader data = executeDataReaderCommand(command);
            int i = 0;
            while(data.Read())
            {
                if(i > colors.Length - 1) i = 0;
                values.Add(data.GetString(0), data.GetInt32(1));
                legende l = new legende($"{data.GetString(0)} : {data.GetInt32(1)}", colors[i]);
                flpLegendHabi.Controls.Add(l);
                i++;
            }

            PartionedCircle camembert = new PartionedCircle(values, colors);
            camembert.Dock = DockStyle.Fill;
            camembert.m_EdgeSize = 0;
            pnlGrapheHabit.Controls.Add(camembert);
        }

        private void loadPompierPerHabilitation()
        {
            cbxHabilitation.DataSource = null;
            string command = $@"SELECT H.id AS Id, H.libelle AS Nom FROM Habilitation H;";

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command, _con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cbxHabilitation.DataSource = dt;
            cbxHabilitation.DisplayMember = "Nom";
            cbxHabilitation.ValueMember = "Id";
        }

        private void cbxHabilitation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxHabilitation.SelectedValue == null) return;

            flpHabilitation.Controls.Clear();
            int selectedId = Convert.ToInt32(cbxHabilitation.SelectedValue);

            string command = $@"SELECT P.nom, P.prenom
                                FROM Pompier P
                                JOIN Passer Pa ON Pa.matriculePompier = P.matricule
                                WHERE Pa.idHabilitation = @habId
                                ORDER BY P.nom";

            SQLiteCommand cmd = new SQLiteCommand(command, _con);
            cmd.Parameters.AddWithValue("@habId", selectedId);
            SQLiteDataReader data = cmd.ExecuteReader();

            while(data.Read())
            {
                Label Pompier = new Label();
                Pompier.Text = TruncateText($"{data.GetString(0)} {data.GetString(1)}");
                flpHabilitation.Controls.Add(Pompier);
            }

            if(flpHabilitation.Controls.Count == 0)
            {
                Label empty = new Label();
                empty.Text = "Aucun pompier n'a cette habilitation";
                flpHabilitation.Controls.Add(empty);
            }
        }


        private string TruncateText(string text, int maxLength = 10)
        {
            if(string.IsNullOrEmpty(text)) return text;
            return text.Length > maxLength ? text.Substring(0, maxLength) + "..." : text;
        }



    }
}