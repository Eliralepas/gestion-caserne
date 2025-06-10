namespace UC_AjoutMissions
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
            lblCode = new Label();
            lblId = new Label();
            ptbMobiliser = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbMobiliser).BeginInit();
            SuspendLayout();
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(16, 21);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(45, 16);
            lblCode.TabIndex = 0;
            lblCode.Text = "label1";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(16, 68);
            lblId.Name = "lblId";
            lblId.Size = new Size(45, 16);
            lblId.TabIndex = 1;
            lblId.Text = "label2";
            // 
            // ptbMobiliser
            // 
            ptbMobiliser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ptbMobiliser.Location = new Point(249, 12);
            ptbMobiliser.Name = "ptbMobiliser";
            ptbMobiliser.Size = new Size(114, 91);
            ptbMobiliser.TabIndex = 2;
            ptbMobiliser.TabStop = false;
            // 
            // UC_MobilisationEnginPompier
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            Controls.Add(ptbMobiliser);
            Controls.Add(lblId);
            Controls.Add(lblCode);
            Font = new Font("Arial", 10F);
            Margin = new Padding(4);
            Name = "UC_MobilisationEnginPompier";
            Size = new Size(379, 118);
            ((System.ComponentModel.ISupportInitialize)ptbMobiliser).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.PictureBox ptbMobiliser;
    }
}
