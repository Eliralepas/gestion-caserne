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
            this.lblCode = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.ptbMobiliser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMobiliser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(16, 21);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(62, 23);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "label1";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(16, 85);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(62, 23);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "label2";
            // 
            // ptbMobiliser
            // 
            this.ptbMobiliser.Location = new System.Drawing.Point(280, 21);
            this.ptbMobiliser.Name = "ptbMobiliser";
            this.ptbMobiliser.Size = new System.Drawing.Size(115, 98);
            this.ptbMobiliser.TabIndex = 2;
            this.ptbMobiliser.TabStop = false;
            // 
            // UC_MobilisationEnginPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.ptbMobiliser);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCode);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_MobilisationEnginPompier";
            this.Size = new System.Drawing.Size(420, 139);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMobiliser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.PictureBox ptbMobiliser;
    }
}
