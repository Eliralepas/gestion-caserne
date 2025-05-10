namespace UC_Statistique
{
    partial class histogram
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
            this.lblVehicule = new System.Windows.Forms.Label();
            this.rectValue = new Polygon.Rectangle();
            this.SuspendLayout();
            // 
            // lblVehicule
            // 
            this.lblVehicule.AutoSize = true;
            this.lblVehicule.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicule.Location = new System.Drawing.Point(12, 175);
            this.lblVehicule.Name = "lblVehicule";
            this.lblVehicule.Size = new System.Drawing.Size(55, 23);
            this.lblVehicule.TabIndex = 1;
            this.lblVehicule.Text = "aaaaa";
            // 
            // rectValue
            // 
            this.rectValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rectValue.Location = new System.Drawing.Point(2, 2);
            this.rectValue.m_BackGroundColor = System.Drawing.Color.Black;
            this.rectValue.m_EdgeColor = System.Drawing.Color.Black;
            this.rectValue.m_EdgeSize = 2;
            this.rectValue.m_FontColor = System.Drawing.Color.White;
            this.rectValue.m_NBSommet = 4;
            this.rectValue.m_Size = new System.Drawing.Size(65, 171);
            this.rectValue.m_Text = null;
            this.rectValue.m_TextFont = null;
            this.rectValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rectValue.Name = "rectValue";
            this.rectValue.Size = new System.Drawing.Size(65, 171);
            this.rectValue.TabIndex = 2;
            // 
            // histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rectValue);
            this.Controls.Add(this.lblVehicule);
            this.Name = "histogram";
            this.Size = new System.Drawing.Size(82, 208);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehicule;
        private Polygon.Rectangle rectValue;
    }
}
