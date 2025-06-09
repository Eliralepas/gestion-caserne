using System;
using System.util;
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
                if(isChecked)
                {
                    panel.BackgroundImage = SAE_Aparcio_Claudel_Meral.Properties.Resources.check_mark;
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

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            if(!ReadOnly) // Si le contrôle n'est pas en lecture seule
            {
                // Changer le curseur pour indiquer que c'est cliquable
                panel.Cursor = Cursors.Hand;
                // Mettre le contrôle en surbrillance
                panel.BackColor = System.Drawing.Color.LightBlue;
            }
            else
            {
                panel.Cursor = Cursors.Default; // Si en lecture seule, utiliser le curseur par défaut
            }
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            panel.Cursor = Cursors.Default;                     // Réinitialiser le curseur à la sortie du contrôle
            panel.BackColor = System.Drawing.Color.Transparent; // Réinitialiser la couleur de fond
        }
    }
}
