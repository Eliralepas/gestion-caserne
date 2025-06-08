using System;
using System.Windows.Forms;

namespace UC_ScalableCheckBox
{
    public delegate void CheckedChangedEventHandler(object sender, EventArgs e);

    public partial class ScalableCheckBox : UserControl
    {
        private bool isChecked = false;
        public event CheckedChangedEventHandler CheckedChanged;

        public ScalableCheckBox()
        {
            InitializeComponent();
        }

        private void panel_Click(object sender, EventArgs e)
        {
            Checked = !Checked; //Inverser l'état de la case à cocher
            CheckedChanged(sender, e); // Déclencher l'événement CheckedChanged
        }

        public bool Checked
        {
            get { return isChecked; }
            set
            {
                isChecked = value;
                if (isChecked)
                {
                    panel.BackgroundImage = SAE_Aparcio_Claudel_Meral.Properties.Resources.check_mark ;
                }
                else
                {
                    panel.BackgroundImage = null; // Si non coché, supprimer l'image de fond
                }
            }
        }

        public bool ReadOnly
        {
            get { return !panel.Enabled; }
            set { panel.Enabled = !value; } // Si ReadOnly est vrai, désactiver le panel
        }

        private void ScalableCheckBox_Resize(object sender, EventArgs e)
        {
            // Redimensionner le panel pour qu'il prenne toute la taille du contrôle
            panel.Width = this.Width;
            panel.Height = this.Height;
        }
    }
}
