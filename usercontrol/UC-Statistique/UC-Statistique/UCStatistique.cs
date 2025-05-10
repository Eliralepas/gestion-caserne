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

namespace UC_Statistique
{
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



        private void loadCaserne()
        {
          try{
                string command = "Select [id] ,[nom] FROM Caserne;";
                SQLiteCommand cmd = new SQLiteCommand(command,_con);
                SQLiteDataReader dataRead =  cmd.ExecuteReader();
                while (dataRead.Read())
                {
                    cbxCaserne.Items.Add(new ItemCombo(dataRead.GetInt32(0), dataRead.GetString(1)));
                }
            }
          catch (Exception ex){
                MessageBox.Show(ex.Message);
          }

        } 

    }
}
