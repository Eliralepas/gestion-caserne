namespace UCGestionEngins
{
    partial class UCGestionEngin
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
            this.lblTitleCaserne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleCaserne
            // 
            this.lblTitleCaserne.AutoSize = true;
            this.lblTitleCaserne.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCaserne.Location = new System.Drawing.Point(138, 42);
            this.lblTitleCaserne.Name = "lblTitleCaserne";
            this.lblTitleCaserne.Size = new System.Drawing.Size(178, 27);
            this.lblTitleCaserne.TabIndex = 0;
            this.lblTitleCaserne.Text = "Choix de la carserne";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitleCaserne);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1076, 643);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleCaserne;
    }
}
