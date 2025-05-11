using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlMission
{
    public partial class UC_MobilisationEnginPompier : UserControl
    {
        public UC_MobilisationEnginPompier()
        {
            InitializeComponent();
        }

        private void UC_MobilisationEnginPompier_Load(object sender, EventArgs e)
        {

        }

        private void remplissage(DataSet monDs, int idSinistre, int idCaserne)
        {
            DataRow[] tab = monDs.Tables["Necessiter"].Select("idNatureSinistre = "+idSinistre);

            //créer une table pour stockage des typeengin
            DataTable dtEngins = new DataTable();
            dtEngins.Columns.Add("Type d'engin");
            dtEngins.Columns.Add("nombre", typeof(int));

            string typeEngin;
            int nombre;
            foreach (DataRow ligne in tab)
            {
                typeEngin = ligne["codeTypeEngin"].ToString();
                nombre = Convert.ToInt32(ligne["nombre"]);
                // Ajouter dans la table
                dtEngins.Rows.Add(typeEngin, nombre);
            }

            /*
             * mtn engin de la caserne selectionnée
             * Si l’un des engins requis n’est pas disponible dans la caserne choisie initialement,
             * on attribuera la mission à l’une des trois autres casernes.
            */

            DataTable dt = new DataTable();
            dt.Columns.Add("Type d'engin");
            dt.Columns.Add("Numéro", typeof(int));
            DataRow[] row;
            int num;

            foreach (DataRow lg1 in dtEngins.Rows) {
                string tpengin = lg1["Type d'engin"].ToString();

                DataRow[] lignes = monDs.Tables["Engin"].Select( "codeTypeEngin = '" + tpengin + "' AND idCaserne = " + idCaserne);
                foreach (DataRow lg2 in lignes)
                {
                    int numero = Convert.ToInt32(lg2["numero"]);
                    dt.Rows.Add(tpengin, numero);
                }
            }

            dtgEngin.DataSource = dt;

        }
    }
}
