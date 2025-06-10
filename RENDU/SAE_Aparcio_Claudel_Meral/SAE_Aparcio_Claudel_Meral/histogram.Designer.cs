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
            lblVehicule = new Label();
            rectValue = new Polygon.Rectangle();
            lblValue = new Label();
            SuspendLayout();
            // 
            // lblVehicule
            // 
            lblVehicule.AutoSize = true;
            lblVehicule.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVehicule.Location = new Point(14, 138);
            lblVehicule.Margin = new Padding(4, 0, 4, 0);
            lblVehicule.Name = "lblVehicule";
            lblVehicule.Size = new Size(55, 23);
            lblVehicule.TabIndex = 1;
            lblVehicule.Text = "aaaaa";
            // 
            // rectValue
            // 
            rectValue.BackColor = Color.FromArgb(0, 255, 255, 255);
            rectValue.Location = new Point(3, 22);
            rectValue.m_BackGroundColor = Color.Gold;
            rectValue.m_EdgeColor = Color.PaleGoldenrod;
            rectValue.m_EdgeSize = 2;
            rectValue.m_FontColor = Color.White;
            rectValue.m_NBSommet = 4;
            rectValue.m_Size = new Size(71, 113);
            rectValue.m_Text = null;
            rectValue.m_TextFont = null;
            rectValue.Margin = new Padding(3, 2, 3, 2);
            rectValue.Name = "rectValue";
            rectValue.Size = new Size(71, 113);
            rectValue.TabIndex = 2;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.BackColor = SystemColors.Control;
            lblValue.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValue.ForeColor = Color.Black;
            lblValue.Location = new Point(15, 0);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(44, 20);
            lblValue.TabIndex = 3;
            lblValue.Text = "10000";
            // 
            // histogram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            Controls.Add(lblValue);
            Controls.Add(rectValue);
            Controls.Add(lblVehicule);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "histogram";
            Size = new Size(95, 167);
            Load += histogram_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblVehicule;
        private Polygon.Rectangle rectValue;
        private System.Windows.Forms.Label lblValue;
    }
}
