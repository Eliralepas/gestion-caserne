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
        private bool leave = false;
        public histogram()
        {
            InitializeComponent();
        }

        public histogram(string nom, float hour, float max,string tooltip) : this()
        {
            _nom = nom;
            _hour = hour;
            _max = max;
        }

        private void histogram_Load(object sender, EventArgs e)
        {
            if(this.Height <= 0 || _max <= 0) return;

            lblVehicule.Text = _nom;
            lblVehicule.Top = this.Height - 30;

            lblValue.Text = "Nombre : " + _hour.ToString();
            lblValue.Top = 20;

            this.Width = lblVehicule.Width < lblValue.Width ? lblValue.Width + 20 : lblVehicule.Width + 20;

            lblVehicule.Left = this.Width / 2 - lblVehicule.Width / 2 + 10;
            lblValue.Left = this.Width / 2 - lblValue.Width / 2;

            int availableHeight = this.Height - 50 - lblVehicule.Height - lblValue.Height;
            int calculatedHeight = (int)(availableHeight * (_hour / _max));
            rectValue.Height = _hour == 0 ? 10 : Math.Max(calculatedHeight, 10);

            _baseHeight = rectValue.Height;
            rectValue.Width = this.Width - 30 < 60 ? this.Width - 30 : 60;
            rectValue.Left = this.Width / 2 - rectValue.Width / 2;
            rectValue.Top = this.Height - lblVehicule.Height - rectValue.Height - 20;
            _basetop = rectValue.Top;
        }


        private void histogram_MouseEnter(object sender, EventArgs e)
        {
            if (leave) { return; }
            leave = true;
            rectValue.Height = (int)(_baseHeight * 1.2);
            rectValue.Top = _basetop - (rectValue.Height - _baseHeight);
        }

        private void histogram_MouseLeave(object sender, EventArgs e)
        {
            rectValue.Height = _baseHeight;
            rectValue.Top = _basetop;
        }

        private void histogram_MouseLeave_1(object sender, EventArgs e)
        {
            leave = false;

        }
    }
}