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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedRectangle
            // 
            this.roundedRectangle.AutoSize = true;
            this.roundedRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundedRectangle.CornerRadius = 30F;
            this.roundedRectangle.Location = new System.Drawing.Point(-112, -1);
            this.roundedRectangle.m_BackGroundColor = System.Drawing.Color.Crimson;
            this.roundedRectangle.m_EdgeColor = System.Drawing.Color.Black;
            this.roundedRectangle.m_EdgeSize = 20;
            this.roundedRectangle.m_FontColor = System.Drawing.Color.White;
            this.roundedRectangle.m_NBSommet = 50;
            this.roundedRectangle.m_Size = new System.Drawing.Size(331, 73);
            this.roundedRectangle.m_Text = null;
            this.roundedRectangle.m_TextFont = null;
            this.roundedRectangle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.roundedRectangle.Name = "roundedRectangle";
            this.roundedRectangle.Size = new System.Drawing.Size(331, 73);
            this.roundedRectangle.TabIndex = 0;
            this.roundedRectangle.Click += new System.EventHandler(this.roundedRectangle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox1.Image = global::NavigationBarUserControl.Properties.Resources.Surpise;
            this.pictureBox1.Location = new System.Drawing.Point(2, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(61, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Display Text Here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UCButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roundedRectangle);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCButton";
            this.Size = new System.Drawing.Size(219, 72);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Polygon.RoundedRectangle roundedRectangle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
