using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SAE_Aparcio_Claudel_Meral
{
    public partial class frmHabilitation : Form
    {
        public frmHabilitation()
        {
            InitializeComponent();
        }
        SQLiteConnection _con;
        private int _matricule;
        public List<HabilitationItem> SelectedHabilitations { get; private set; } = new List<HabilitationItem>();

        public frmHabilitation(SQLiteConnection con, int matricule)
        {
            InitializeComponent();
            _con = con;
            _matricule = matricule;
        }

        private void frmHabilitation_Load(object sender, EventArgs e)
        {
            try
            {
                string command = "SELECT id, libelle FROM Habilitation";
                SQLiteCommand cmd = new SQLiteCommand(command, _con);
                SQLiteDataReader data = cmd.ExecuteReader();
                var habilitations = new List<HabilitationItem>();

                while(data.Read())
                {
                    int id = data.GetInt16(0);
                    string libelle = data.GetString(1);
                    habilitations.Add(new HabilitationItem(id, libelle));
                }
                data.Close();

                var idsChecked = new HashSet<int>();
                string selectExist = $"SELECT idHabilitation FROM Passer WHERE matriculePompier = {_matricule}";
                SQLiteCommand cmdChecked = new SQLiteCommand(selectExist, _con);
                SQLiteDataReader reader = cmdChecked.ExecuteReader();
                while(reader.Read())
                {
                    idsChecked.Add(reader.GetInt32(0));
                }

                foreach(var item in habilitations)
                {
                    int index = chklist.Items.Add(item);
                    if(idsChecked.Contains(item.Id))
                        chklist.SetItemChecked(index, true);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur de chargement des habilitations : " + ex.Message);
            }
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            SelectedHabilitations.Clear();

            foreach(object item in chklist.CheckedItems)
            {
                if(item is HabilitationItem habilitation)
                {
                    SelectedHabilitations.Add(habilitation);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }




}

public class HabilitationItem
{
    public int Id { get; set; }
    public string Libelle { get; set; }

    public HabilitationItem(int id, string libelle)
    {
        Id = id;
        Libelle = libelle;
    }

    public override string ToString()
    {
        return Libelle;
    }
}

