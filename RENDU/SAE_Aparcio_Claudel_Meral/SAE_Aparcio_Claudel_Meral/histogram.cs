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
            if (this.Height <= 0 || _max <= 0) return;

            lblVehicule.Text = _nom;
            lblVehicule.Top = this.Height - 30;
            
            

            lblValue.Text = "Nombre : "+_hour.ToString();
            lblValue.Top =+ 20;
           


            this.Width = lblVehicule.Width< lblValue.Width ? lblValue.Width+20:lblVehicule.Width+20;

            lblVehicule.Left = this.Width / 2 - lblVehicule.Width / 2 + 10;
            lblValue.Left = this.Width / 2 - lblValue.Width / 2;

            int availableHeight = this.Height -50- lblVehicule.Height-lblValue.Height;
            rectValue.Height = (int)(availableHeight * (_hour / _max))>0? (int)(availableHeight * (_hour / _max)):0;

            _baseHeight = rectValue.Height;
            rectValue.Width = this.Width - 30<60? this.Width - 30:60;
            rectValue.Left = this.Width / 2 - rectValue.Width / 2;
            rectValue.Top = this.Height - lblVehicule.Height - rectValue.Height - 20;
            _basetop = rectValue.Top;
        }
    }
}