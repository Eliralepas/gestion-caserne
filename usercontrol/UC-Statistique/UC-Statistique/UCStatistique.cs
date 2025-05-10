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
    public partial class UCStatistique: UserControl
    {
        private SQLiteConnection _con;//connection utilisé pour récupere les statistiques

        public UCStatistique()
        {
            InitializeComponent();
            tabStatistique.SelectedTab = tabPage1; // Sélectionne tabPage1
            tabStatistique_SelectedIndexChanged(this, EventArgs.Empty); // Déclenche manuellement pour pouvoir load les données
        }

        public UCStatistique(SQLiteConnection con) : this()
        {
            if (con.State != ConnectionState.Open)
            {
                throw new ArgumentException("Connection dois être ouverte");
            }
            _con = con;
        }

        private void tabStatistique_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabStatistique.SelectedTab)
            {
                case var tab when tab == tabPage1:
                    MessageBox.Show("Tab 1 sélectionné");
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



    }
}
