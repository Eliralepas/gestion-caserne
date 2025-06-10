using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace UC_GestionPerso
{
    public partial class UCLogin : UserControl
    {

        SQLiteConnection m_con;

        public UCLogin()
        {
            InitializeComponent();
        }
        bool _connected;
        public bool Connected { get { return _connected; }  set { _connected = value; } }

        public UCLogin(SQLiteConnection con)
        {
            InitializeComponent();
            m_con = con;
            if(m_con.State == ConnectionState.Closed)
            {
                m_con.Open();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!txtPwd.UseSystemPasswordChar)
            {
                txtPwd.UseSystemPasswordChar = true;
            }
            else
            {
                txtPwd.UseSystemPasswordChar = false;
            }
        }



        private void validate()
        {
            string login = txtUser.Text;
            string mdp = txtPwd.Text;

            string command = $@"Select mdp FROM Admin WHERE login = {login}; ";
            SQLiteCommand cmd = new SQLiteCommand(command,m_con);
            SQLiteDataReader data =  cmd.ExecuteReader();
            while(data.Read())
            {
                
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                validate();
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            validate();
        }
    }
}
