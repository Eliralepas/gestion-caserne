namespace UC_Bouton
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
            this.roundeRectangleButton = new Polygon.RoundedRectangle();
            this.imgbutton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // roundeRectangleButton
            // 
            this.roundeRectangleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundeRectangleButton.CornerRadius = 80F;
            this.roundeRectangleButton.Location = new System.Drawing.Point(-146, 0);
            this.roundeRectangleButton.m_BackGroundColor = System.Drawing.Color.Crimson;
            this.roundeRectangleButton.m_EdgeColor = System.Drawing.Color.Black;
            this.roundeRectangleButton.m_EdgeSize = 12;
            this.roundeRectangleButton.m_FontColor = System.Drawing.Color.White;
            this.roundeRectangleButton.m_NBSommet = 60;
            this.roundeRectangleButton.m_Size = new System.Drawing.Size(716, 264);
            this.roundeRectangleButton.m_Text = "";
            this.roundeRectangleButton.m_TextFont = null;
            this.roundeRectangleButton.Name = "roundeRectangleButton";
            this.roundeRectangleButton.Size = new System.Drawing.Size(716, 264);
            this.roundeRectangleButton.TabIndex = 0;
            // 
            // imgbutton
            // 
            this.imgbutton.Location = new System.Drawing.Point(0, 20);
            this.imgbutton.Name = "imgbutton";
            this.imgbutton.Size = new System.Drawing.Size(256, 225);
            this.imgbutton.TabIndex = 1;
            this.imgbutton.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgbutton);
            this.Controls.Add(this.roundeRectangleButton);
            this.Name = "button";
            this.Size = new System.Drawing.Size(571, 263);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgbutton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Polygon.RoundedRectangle roundeRectangleButton;
        private System.Windows.Forms.PictureBox imgbutton;
        private System.Windows.Forms.Label label1;
    }
}
