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
            this.flpHeurPEngin = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpHeurPEngin
            // 
            this.flpHeurPEngin.AutoScroll = true;
            this.flpHeurPEngin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHeurPEngin.Location = new System.Drawing.Point(0, 0);
            this.flpHeurPEngin.Name = "flpHeurPEngin";
            this.flpHeurPEngin.Size = new System.Drawing.Size(489, 397);
            this.flpHeurPEngin.TabIndex = 0;
            this.flpHeurPEngin.WrapContents = false;
            // 
            // histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpHeurPEngin);
            this.Name = "histogram";
            this.Size = new System.Drawing.Size(489, 397);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpHeurPEngin;
    }
}
