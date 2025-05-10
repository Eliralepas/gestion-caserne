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

        private Dictionary<string, float> _data;
        public histogram()
        {
            InitializeComponent();
        }
        public histogram(Dictionary<string,float> data) :this()
        {
            _data = data;
            loadHistogram();
            this.BackColor = Color.Black;
            flpHeurPEngin.BackColor = Color.Blue;
        }

        private void loadHistogram()
        {
            if (_data == null || _data.Count == 0) return;
            int i = 1;
            foreach (KeyValuePair<string, float> bar in _data)
            {
                string labeltext = bar.Key.ToString();
                Label lbl = new Label();
                lbl.Text = labeltext;
                lbl.Top = flpHeurPEngin.Height - 20;
                lbl.Left = i * 30 + lbl.Width;
                lbl.BackColor = Color.Red;
                flpHeurPEngin.Controls.Add(lbl);
                i++;
            }

        }


    }
}
