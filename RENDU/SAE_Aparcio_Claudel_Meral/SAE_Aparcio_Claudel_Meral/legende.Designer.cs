namespace UC_Statistique
{
    partial class legende
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
            this.rctColor = new Polygon.Rectangle();
            this.lblLegende = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rctColor
            // 
            this.rctColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rctColor.Location = new System.Drawing.Point(0, 0);
            this.rctColor.m_BackGroundColor = System.Drawing.Color.Black;
            this.rctColor.m_EdgeColor = System.Drawing.Color.Black;
            this.rctColor.m_EdgeSize = 2;
            this.rctColor.m_FontColor = System.Drawing.Color.White;
            this.rctColor.m_NBSommet = 4;
            this.rctColor.m_Size = new System.Drawing.Size(69, 57);
            this.rctColor.m_Text = null;
            this.rctColor.m_TextFont = null;
            this.rctColor.Name = "rctColor";
            this.rctColor.Size = new System.Drawing.Size(69, 57);
            this.rctColor.TabIndex = 0;
            // 
            // lblLegende
            // 
            this.lblLegende.AutoSize = true;
            this.lblLegende.Location = new System.Drawing.Point(75, 23);
            this.lblLegende.Name = "lblLegende";
            this.lblLegende.Size = new System.Drawing.Size(44, 16);
            this.lblLegende.TabIndex = 1;
            this.lblLegende.Text = "label1";
            // 
            // legende
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLegende);
            this.Controls.Add(this.rctColor);
            this.Name = "legende";
            this.Size = new System.Drawing.Size(156, 60);
            this.Load += new System.EventHandler(this.legende_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Polygon.Rectangle rctColor;
        private System.Windows.Forms.Label lblLegende;
    }
}
