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

        public frmCreationPompier()
        {
            InitializeComponent();
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //creer pompier 
            DialogResult = DialogResult.OK;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
