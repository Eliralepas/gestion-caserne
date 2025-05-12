namespace UserControlMission
{
    partial class UC_MobilisationEnginPompier
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
            this.dtgMob = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMob)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMob
            // 
            this.dtgMob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMob.Location = new System.Drawing.Point(3, 3);
            this.dtgMob.Name = "dtgMob";
            this.dtgMob.RowHeadersWidth = 62;
            this.dtgMob.RowTemplate.Height = 28;
            this.dtgMob.Size = new System.Drawing.Size(415, 183);
            this.dtgMob.TabIndex = 3;
            // 
            // UC_MobilisationEnginPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.dtgMob);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_MobilisationEnginPompier";
            this.Size = new System.Drawing.Size(422, 190);
            this.Load += new System.EventHandler(this.UC_MobilisationEnginPompier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMob;
    }
}
