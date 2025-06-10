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

namespace UC_AjoutMissions
{
    public partial class UC_MobilisationEnginPompier : UserControl
    {
        public UC_MobilisationEnginPompier(string premierChamp, string deuxiemeChamp)
        {
            InitializeComponent();
            lblCode.Text = premierChamp;
            lblId.Text = deuxiemeChamp;
            
        }

    }
}
