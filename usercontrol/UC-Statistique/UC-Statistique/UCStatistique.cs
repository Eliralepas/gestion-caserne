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
 

    public partial class UCStatistique: UserControl
    {
        private SQLiteConnection _con;//connection utilisé pour récupere les statistiques
        private Color[] colors = new Color[] { Color.Blue, Color.Green, Color.Red, Color.Yellow, Color.Purple, Color.Black, Color.Fuchsia };
        public UCStatistique()
        {
            InitializeComponent();
        }

        public UCStatistique(SQLiteConnection con) : this()
        {
            if (con.State != ConnectionState.Open)
            {
                throw new ArgumentException("Connection dois être ouverte");
            }
            _con = con;
            tabStatistique.SelectedTab = tabPage1; 
            tabStatistique_SelectedIndexChanged(this, EventArgs.Empty);//Déclechement automatique pour 
        }

        private void tabStatistique_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_con == null) return;
            switch (tabStatistique.SelectedTab)
            {
                case var tab when tab == tabPage1:
                    loadCaserne();
                    break;
                case var tab when tab == tabPage2:
                    loadInterventionStat();
                    break;
                case var tab when tab == tabPage3:
                    loadHabilitation();
                    break;
                default:
                    MessageBox.Show("Onglet inconnu sélectionné");
                    break;
            }
        }

        private SQLiteDataReader executeDataReaderCommand(string command)
        {
            SQLiteCommand cmd = new SQLiteCommand(command, _con);
            
            return cmd.ExecuteReader(); ;
        }




        /**Statistique Relatif a la caserne choisis*/
        private void loadCaserne()
        {//on load toute les casernes de la bases dans la comboBox
          try{
                cbxCaserne.Items.Clear();
                string command = "Select [id] ,[nom] FROM Caserne;";
                SQLiteDataReader dataRead = executeDataReaderCommand(command);
                while (dataRead.Read())
                {
                    cbxCaserne.Items.Add(new ItemCombo(dataRead.GetInt32(0), dataRead.GetString(1)));
                }
            }
          catch (Exception ex){
                MessageBox.Show(ex.Message);
          }

        }

        private void cbxCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCaserne.SelectedIndex == -1)
            {
                return;
            }
            loadEnginPerHour();
            loadMostUsedEngin();
        }
        private void loadEnginPerHour()
        {
            ItemCombo selected = (ItemCombo)cbxCaserne.SelectedItem;
            flpHistogram.Controls.Clear();
            try
            {
                string command = $@"
                    SELECT E.codeTypeEngin,E.numero,
                    ROUND(SUM((julianday(M.dateHeureRetour) - julianday(M.dateHeureDepart)) * 24), 2) AS cumul_heures                     
                    FROM Engin E
                    JOIN Partiravec P ON E.idCaserne = P.idCaserne 
                    AND E.codeTypeEngin = P.codeTypeEngin 
                    AND E.numero = P.numeroEngin 
                    JOIN Mission M ON P.idMission = M.id
                    WHERE E.idCaserne = @idMission 
                    AND M.dateHeureRetour IS NOT NULL 
                    GROUP BY  E.codeTypeEngin, E.numero 
                    ORDER BY cumul_heures DESC;";

                SQLiteCommand cmd = new SQLiteCommand(command, _con);
                cmd.Parameters.AddWithValue("@idMission", selected.Id);
                SQLiteDataReader dataReader = cmd.ExecuteReader();


                float maxValue = 0;
                Dictionary<string, float> EnginPerHour = new Dictionary<string, float>();
                while (dataReader.Read())
                {
                    string engin = dataReader.GetString(0) + " " + dataReader.GetInt32(1).ToString();
                    float heures = dataReader.GetFloat(2);
                    if (heures > maxValue) maxValue = heures;
                    EnginPerHour.Add(engin, heures);
                }
                foreach (KeyValuePair<string, float> eph in EnginPerHour)
                {
                    flpHistogram.Controls.Add(new histogram(eph.Key, eph.Value, maxValue,"heure Cumulé : "));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadMostUsedEngin()
        {
            pnlCamembert.Controls.Clear();
            flpLegende.Controls.Clear();
            ItemCombo selected = (ItemCombo)cbxCaserne.SelectedItem;
            string command = $@"SELECT E.codeTypeEngin,count(*)
                                FROM Engin E
                                JOIN PartirAvec P on P.codeTypeEngin = E.codeTypeEngin AND E.numero = P.numeroEngin AND P.idCaserne = E.idCaserne
                                WHERE P.idCaserne = {selected.Id}
                                GROUP BY E.codeTypeEngin 
                                ORDER BY COUNT() DESC;";

            SQLiteDataReader data = executeDataReaderCommand(command);
            Dictionary<string, int> values = new Dictionary<string, int>();
            for(int i = 0; i < 4 && data.Read(); i++)//on ne garde que les 4 plus utilisé 
            {
                values.Add(data.GetString(0),data.GetInt32(1));
                legende l =  new legende($"{data.GetString(0)} : {data.GetInt32(1)}", colors[i]);
                flpLegende.Controls.Add(l);
            }
            Array.Copy(colors, selectedColor, values.Count);
            PartionedCircle camenbert = new PartionedCircle(values,colors);
            camenbert.Dock = DockStyle.Fill;
            pnlCamembert.Controls.Add(camenbert);

        }
        //Statistique relatif au intervention
        
        private void loadInterventionStat()
        {
            flpSinistreStat.Controls.Clear();
            string command = $@"SELECT ns.libelle,Count(*) from NatureSinistre ns
                             JOIN Mission M ON M.idNatureSinistre = ns.id
                              GROUP BY ns.id;";
            SQLiteDataReader data = executeDataReaderCommand(command);


            float maxValue = 0;
            Dictionary<string, float> EnginPerHour = new Dictionary<string, float>();
            while (data.Read())
            {
                string sinistre = data.GetString(0);
                float nbIntervention = data.GetFloat(1);
                if (nbIntervention > maxValue) maxValue = nbIntervention;
                EnginPerHour.Add(sinistre, nbIntervention);
            }
            foreach (KeyValuePair<string, float> eph in EnginPerHour)
            {
                flpSinistreStat.Controls.Add(new histogram(eph.Key, eph.Value, maxValue,"Nombre de Siniste : "));

            }


        }

        private void loadHabilitation()
        {
            loadMostUsedHabilitation();
        }

        private void loadMostUsedHabilitation()
        {
            pnlGrapheHabit.Controls.Clear();
            flpLegendHabi.Controls.Clear();
            string command = $@"SELECT h.libelle ,Count(m.idMission)
                                FROM Habilitation h
                                JOIN Mobiliser m ON h.id = m.idHabilitation
                                GROUP BY h.libelle
                                ORDER by COUNT(m.idMission) DESC ";

            Dictionary<string, int> values = new Dictionary<string, int>();
            SQLiteDataReader data = executeDataReaderCommand(command);
            int i = 0;
            while(data.Read())
            {
                if (i > colors.Length-1) i = 0;
                values.Add(data.GetString(0), data.GetInt32(1));
                legende l = new legende($"{data.GetString(0)} : {data.GetInt32(1)}", colors[i]);
                flpLegendHabi.Controls.Add(l);
                i++;
            }
            Color[] selectedColor = new Color[values.Count];
            if (values.Count > colors.Length)
            {
                selectedColor = colors;
            }
            else
            {
                Array.Copy(colors, selectedColor, values.Count);
            }
            PartionedCircle camenbert = new PartionedCircle(values, colors);
            camenbert.Dock = DockStyle.Fill;
            pnlGrapheHabit.Controls.Add(camenbert);

        }
    }


    public class ItemCombo
    {
        public ItemCombo(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }

        public int Id { get; set; }
        public string Nom { get; set; }

        public override string ToString()
        {
            return Nom;
        }
    }



}
