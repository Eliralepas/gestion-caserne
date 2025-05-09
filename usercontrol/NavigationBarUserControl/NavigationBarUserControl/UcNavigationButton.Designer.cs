namespace NavigationBarUserControl
{
    partial class button
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
            this.roundedRectangle.Location = new System.Drawing.Point(-142, 8);
            this.roundedRectangle.m_BackGroundColor = System.Drawing.Color.Crimson;
            this.roundedRectangle.m_EdgeColor = System.Drawing.Color.Black;
            this.roundedRectangle.m_EdgeSize = 20;
            this.roundedRectangle.m_FontColor = System.Drawing.Color.White;
            this.roundedRectangle.m_NBSommet = 50;
            this.roundedRectangle.m_Size = new System.Drawing.Size(414, 91);
            this.roundedRectangle.m_Text = null;
            this.roundedRectangle.m_TextFont = null;
            this.roundedRectangle.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.roundedRectangle.Name = "roundedRectangle";
            this.roundedRectangle.Size = new System.Drawing.Size(414, 91);
            this.roundedRectangle.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox1.Image = global::NavigationBarUserControl.Properties.Resources.Surpise;
            this.pictureBox1.Location = new System.Drawing.Point(3, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(78, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Display Text Here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roundedRectangle);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "button";
            this.Size = new System.Drawing.Size(302, 124);
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
