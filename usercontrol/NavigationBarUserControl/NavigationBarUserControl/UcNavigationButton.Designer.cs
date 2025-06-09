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
            if (disposing && (components != null))
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
            this.roundedRectangle = new Polygon.RoundedRectangle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.Panel();
            this.panelBouton = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelImage.SuspendLayout();
            this.panelBouton.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedRectangle
            // 
            this.roundedRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundedRectangle.CornerRadius = 30F;
            this.roundedRectangle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedRectangle.Location = new System.Drawing.Point(0, 0);
            this.roundedRectangle.m_BackGroundColor = System.Drawing.Color.Crimson;
            this.roundedRectangle.m_EdgeColor = System.Drawing.Color.Black;
            this.roundedRectangle.m_EdgeSize = 20;
            this.roundedRectangle.m_FontColor = System.Drawing.Color.White;
            this.roundedRectangle.m_NBSommet = 50;
            this.roundedRectangle.m_Size = new System.Drawing.Size(440, 115);
            this.roundedRectangle.m_Text = null;
            this.roundedRectangle.m_TextFont = null;
            this.roundedRectangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundedRectangle.Name = "roundedRectangle";
            this.roundedRectangle.Size = new System.Drawing.Size(440, 115);
            this.roundedRectangle.TabIndex = 1;
            this.roundedRectangle.Click += new System.EventHandler(this.OnAnyClick);
            this.roundedRectangle.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.roundedRectangle.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::NavigationBarUserControl.Properties.Resources.Surpise;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.OnAnyClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(122, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 80);
            this.label1.TabIndex = 3;
            this.label1.Text = "Display Text Here";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.OnAnyClick);
            this.label1.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // panelImage
            // 
            this.panelImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelImage.Controls.Add(this.pictureBox1);
            this.panelImage.Location = new System.Drawing.Point(38, 19);
            this.panelImage.Margin = new System.Windows.Forms.Padding(2);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(80, 80);
            this.panelImage.TabIndex = 2;
            // 
            // panelBouton
            // 
            this.panelBouton.Controls.Add(this.label1);
            this.panelBouton.Controls.Add(this.panelImage);
            this.panelBouton.Controls.Add(this.roundedRectangle);
            this.panelBouton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBouton.Location = new System.Drawing.Point(0, 0);
            this.panelBouton.Name = "panelBouton";
            this.panelBouton.Size = new System.Drawing.Size(440, 115);
            this.panelBouton.TabIndex = 0;
            // 
            // UCButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panelBouton);
            this.Font = new System.Drawing.Font("Arial", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCButton";
            this.Size = new System.Drawing.Size(440, 115);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelImage.ResumeLayout(false);
            this.panelBouton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Polygon.RoundedRectangle roundedRectangle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panelBouton;
    }
}
