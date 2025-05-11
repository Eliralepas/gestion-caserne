using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_Statistique
{
    public partial class histogram : UserControl
    {
        private string _nom;
        private float _hour;
        private float _max;
        private int _baseHeight;
        private int _basetop;

        public histogram()
        {
            InitializeComponent();
        }

        public histogram(string nom, float hour, float max) : this()
        {
            _nom = nom;
            _hour = hour;
            _max = max;
        }

        private void histogram_Load(object sender, EventArgs e)
        {
            if (this.Height <= 0 || _max <= 0) return;

            lblVehicule.Text = _nom;
            lblVehicule.Top = this.Height - 20;
            lblVehicule.Left = this.Width / 2 - lblVehicule.Width / 2 + 10;

            int availableHeight = this.Height -50- lblVehicule.Height;
            rectValue.Height = (int)(availableHeight * (_hour / _max))>10? (int)(availableHeight * (_hour / _max)): (50-(int)_hour*2);

            _baseHeight = rectValue.Height;
            rectValue.Width = this.Width - 30;
            rectValue.Left = this.Width / 2 - rectValue.Width / 2;
            rectValue.Top = this.Height - lblVehicule.Height - rectValue.Height - 20;
            _basetop = rectValue.Top;


            ToolTip valueToolTip = new ToolTip();
            valueToolTip.AutoPopDelay = 0;
            valueToolTip.IsBalloon = true;
            valueToolTip.SetToolTip(rectValue, "heure Cumulé " + _hour.ToString());

        }

        private void histogram_MouseEnter(object sender, EventArgs e)
        {
            rectValue.Height = (int)(_baseHeight * 1.2);
            rectValue.Top = _basetop - (rectValue.Height - _baseHeight);
        }

        private void histogram_MouseLeave(object sender, EventArgs e)
        {
            rectValue.Height = _baseHeight;
            rectValue.Top = _basetop;
        }

    }
}