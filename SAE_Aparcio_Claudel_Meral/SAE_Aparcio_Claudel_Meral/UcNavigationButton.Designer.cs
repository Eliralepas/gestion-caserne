namespace NavigationBarUserControl
{
    partial class UCButton
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            roundedRectangle = new Polygon.RoundedRectangle();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelImage = new Panel();
            panelBouton = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelImage.SuspendLayout();
            panelBouton.SuspendLayout();
            SuspendLayout();
            // 
            // roundedRectangle
            // 
            roundedRectangle.BackColor = Color.FromArgb(0, 255, 255, 255);
            roundedRectangle.CornerRadius = 30F;
            roundedRectangle.Dock = DockStyle.Fill;
            roundedRectangle.Location = new Point(0, 0);
            roundedRectangle.m_BackGroundColor = Color.Crimson;
            roundedRectangle.m_EdgeColor = Color.Black;
            roundedRectangle.m_EdgeSize = 20;
            roundedRectangle.m_FontColor = Color.White;
            roundedRectangle.m_NBSommet = 50;
            roundedRectangle.m_Size = new Size(440, 115);
            roundedRectangle.m_Text = null;
            roundedRectangle.m_TextFont = null;
            roundedRectangle.Margin = new Padding(2);
            roundedRectangle.Name = "roundedRectangle";
            roundedRectangle.Size = new Size(440, 115);
            roundedRectangle.TabIndex = 1;
            roundedRectangle.Click += OnAnyClick;
            roundedRectangle.MouseEnter += Button_MouseEnter;
            roundedRectangle.MouseLeave += Button_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Crimson;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = SAE_Aparcio_Claudel_Meral.Properties.Resources.Surpise;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += OnAnyClick;
            pictureBox1.MouseEnter += Button_MouseEnter;
            pictureBox1.MouseLeave += Button_MouseLeave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Crimson;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(122, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(290, 80);
            label1.TabIndex = 3;
            label1.Text = "Display Text Here";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += OnAnyClick;
            label1.MouseEnter += Button_MouseEnter;
            label1.MouseLeave += Button_MouseLeave;
            // 
            // panelImage
            // 
            panelImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelImage.Controls.Add(pictureBox1);
            panelImage.Location = new Point(38, 19);
            panelImage.Margin = new Padding(2);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(80, 80);
            panelImage.TabIndex = 2;
            // 
            // panelBouton
            // 
            panelBouton.Controls.Add(label1);
            panelBouton.Controls.Add(panelImage);
            panelBouton.Controls.Add(roundedRectangle);
            panelBouton.Dock = DockStyle.Fill;
            panelBouton.Location = new Point(0, 0);
            panelBouton.Name = "panelBouton";
            panelBouton.Size = new Size(440, 115);
            panelBouton.TabIndex = 0;
            // 
            // UCButton
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(panelBouton);
            Font = new Font("Arial", 12F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UCButton";
            Size = new Size(440, 115);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelImage.ResumeLayout(false);
            panelBouton.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Polygon.RoundedRectangle roundedRectangle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panelBouton;
    }
}
