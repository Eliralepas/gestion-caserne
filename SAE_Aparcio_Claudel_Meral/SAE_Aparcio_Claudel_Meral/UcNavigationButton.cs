using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationBarUserControl
{
    public partial class UCButton : UserControl
    {
        private bool isExpanded = false;
        private bool isClicked = false;

        public UCButton()
        {
            InitializeComponent();
        }

        public bool IsClicked
        {
            get { return isClicked; }
            set
            {
                isClicked = value;
                if(!isClicked)
                {
                    // Retourner à la taille normale
                    isExpanded = false;
                    ExpandButton(isExpanded);
                }
            }
        }

        private String _strText;
        public String buttonText
        {
            get { return _strText; }
            set
            {
                _strText = value;
                label1.Text = value;
            }
        }

        public Image Buttonimage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }


        public UCButton(string str, Image img, Control binder)
        {
            InitializeComponent();
            label1.Text = str;
            pictureBox1.Image = img;
            // Lier l'évènement de survol de la souris à tous les contrôles enfants
            foreach(Control control in this.Controls)
            {
                control.MouseEnter += Button_MouseEnter;
                control.MouseLeave += Button_MouseLeave;
            }
        }

        public event EventHandler<ControlClickedEventArgs> ButtonClicked;

        public class ControlClickedEventArgs : EventArgs
        {
            public String ControlToReturn { get; }

            public ControlClickedEventArgs(string Tag)
            {
                ControlToReturn = Tag;
            }
        }

        private void OnAnyClick(object sender, EventArgs e)
        {
            if(!isClicked && ButtonClicked != null && this.Tag != null)
            {
                ButtonClicked(this, new ControlClickedEventArgs(this.Tag.ToString())); // Passer le Tag du bouton cliqué
                isClicked = true;           // Marquer le bouton comme cliqué
                Cursor = Cursors.Default;   // Réinitialiser le curseur
            }
        }

        public String getBindedControl()
        {
            return this.Tag.ToString();
        }

        private void ExpandButton(bool expand)
        {
            int increment = 40; // Valeur d'incrémentation pour l'expansion
            if(!expand)
            {
                increment = -increment;
            }
            // Agrandir le bouton
            this.Width += increment;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if(!isExpanded)
            {
                // Changer le curseur pour indiquer que c'est cliquable
                Cursor = Cursors.Hand;
                // Agrandir le bouton
                isExpanded = true;
                ExpandButton(isExpanded);
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if(isExpanded && !isClicked)
            {
                // Changer le curseur pour indiquer que ce n'est plus cliquable
                Cursor = Cursors.Default;
                // Retourner à la taille normale
                isExpanded = false;
                ExpandButton(isExpanded);
            }
        }
    }
}
