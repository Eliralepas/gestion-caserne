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

namespace UC_Statistique
{
 

    public partial class UCStatistique: UserControl
    {
        private SQLiteConnection _con;//connection utilisé pour récupere les statistiques

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
            switch (tabStatistique.SelectedTab)
            {
                case var tab when tab == tabPage1:
                    MessageBox.Show("Tab 1 sélectionné");
                    loadCaserne();
                    break;
                case var tab when tab == tabPage2:
                    MessageBox.Show("Tab 2 sélectionné");
                    break;
                case var tab when tab == tabPage3:
                    MessageBox.Show("Tab 3 sélectionné");
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





        private void loadCaserne()
        {
          try{
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
            ItemCombo selected = (ItemCombo)cbxCaserne.SelectedItem;
            MessageBox.Show(selected.Nom,selected.Id.ToString());
            flpHistogram.Controls.Clear();
            try { 
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
                    ORDER BY cumul_heures DESC;" ;

                SQLiteCommand cmd = new SQLiteCommand(command,_con);
                cmd.Parameters.AddWithValue("@idMission",selected.Id);
                SQLiteDataReader dataReader =  cmd.ExecuteReader();


                float maxValue = 0;
                Dictionary<string, float> EnginPerHour = new Dictionary<string, float>();
                while (dataReader.Read())
                {
                    string engin = dataReader.GetString(0) + " " + dataReader.GetInt32(1).ToString();
                    float heures = dataReader.GetFloat(2);
                    if (heures > maxValue) maxValue = heures;
                    EnginPerHour.Add(engin, heures);
                }
                foreach(KeyValuePair<string,float> eph in EnginPerHour)
                {
                    flpHistogram.Controls.Add(new histogram(eph.Key,eph.Value,maxValue));

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
