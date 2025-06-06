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
            //remplir les combo box
        }

        public frmCreationPompier()
        {
            InitializeComponent();
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            string texteActuel = tb.Text;
            int pos = tb.SelectionStart;

            e.Handled = true;

            if (e.KeyChar == (char) Keys.Back)
            {
                e.Handled = false;
            }

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            if (e.KeyChar == ' ' || e.KeyChar == '-')
            {
                // Pas en premier caractère
                if (pos == 0)
                {
                    e.Handled = true;
                }

                // Pas deux espaces/tirets consécutifs
                if ((pos > 0 && (texteActuel[pos - 1] == ' ' || texteActuel[pos - 1] == '-')))
                {
                    e.Handled = true;
                }
            } 
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //creer pompier 
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //Annuler
            this.Close();
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            e.Handled = true;

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            if (tb.Text.Length >= 10)
            {
                e.Handled = true;
            }

            if (e.KeyChar != '0' && tb.SelectionStart == 0)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '0' && tb.SelectionStart == 1)
            {
                e.Handled = true;
            }
        }
    }
}
