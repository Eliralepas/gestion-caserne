using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_PanneEngins
{
    public partial class PanneEngins : UserControl
    {
        public PanneEngins(DataRow dr)
        {
            InitializeComponent();
            lblType.Text = dr["codeTypeEngin"].ToString();
            lblNumero.Text = dr["numeroEngin"].ToString();
        }

        public Boolean EnPanne{
            get{ return ckbEnPanne.Checked; }
        }

        public String Type
        {
            get { return lblType.Text; }
        }

        public int Numero
        {
            get { return int.Parse(lblNumero.Text); }
        }
    }
}
