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

namespace UCGestionPerso
{
    public delegate void validateLogin(Dictionary<String, String> KeyLogin);
    public partial class UCGestionPerso: UserControl
    {
        SQLiteConnection _con;
        UCLogin login;
        public UCGestionPerso()
        {
            InitializeComponent();
        }

        public validateLogin validateLoginDel;

        public UCGestionPerso(SQLiteConnection con)
        {
            _con = con;
            login = new UCLogin();
            
        }
        


    }
}
