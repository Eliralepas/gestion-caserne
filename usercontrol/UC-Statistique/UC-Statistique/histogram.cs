using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_Statistique
{
    public partial class histogram : UserControl
    {
        string _nom;
        float _hour;
        public histogram()
        {
            InitializeComponent();
        }
        public histogram(string nom,float hour,float max) :this()
        {
            _nom = nom;
            _hour = hour;
            lblVehicule.Text = nom;
            lblVehicule.Top = this.Height - 20;
            lblVehicule.Left = this.Width / 2 - lblVehicule.Width / 2+10;
            this.rectValue.Height =(int)((this.Height-10-lblVehicule.Height)*(hour/max)+10);
            this.rectValue.Width = this.Width - 30;
            this.rectValue.Left = this.Width / 2 - rectValue.Width / 2;
            this.rectValue.Top = this.Height - lblVehicule.Height - rectValue.Height;

        }



    }
}
