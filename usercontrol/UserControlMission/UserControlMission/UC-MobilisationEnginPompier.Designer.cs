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
            this.grpMobilisation = new System.Windows.Forms.GroupBox();
            this.dtgPompier = new System.Windows.Forms.DataGridView();
            this.dtgEngin = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEngin = new System.Windows.Forms.Label();
            this.grpMobilisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPompier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEngin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMobilisation
            // 
            this.grpMobilisation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMobilisation.Controls.Add(this.dtgPompier);
            this.grpMobilisation.Controls.Add(this.dtgEngin);
            this.grpMobilisation.Controls.Add(this.label2);
            this.grpMobilisation.Controls.Add(this.lblEngin);
            this.grpMobilisation.Font = new System.Drawing.Font("Arial", 12F);
            this.grpMobilisation.ForeColor = System.Drawing.Color.White;
            this.grpMobilisation.Location = new System.Drawing.Point(0, 0);
            this.grpMobilisation.Margin = new System.Windows.Forms.Padding(4);
            this.grpMobilisation.Name = "grpMobilisation";
            this.grpMobilisation.Padding = new System.Windows.Forms.Padding(4);
            this.grpMobilisation.Size = new System.Drawing.Size(969, 284);
            this.grpMobilisation.TabIndex = 0;
            this.grpMobilisation.TabStop = false;
            this.grpMobilisation.Text = "Mobilisation des engins et pompiers";
            // 
            // dtgPompier
            // 
            this.dtgPompier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPompier.Location = new System.Drawing.Point(507, 86);
            this.dtgPompier.Name = "dtgPompier";
            this.dtgPompier.RowHeadersWidth = 62;
            this.dtgPompier.RowTemplate.Height = 28;
            this.dtgPompier.Size = new System.Drawing.Size(415, 183);
            this.dtgPompier.TabIndex = 3;
            // 
            // dtgEngin
            // 
            this.dtgEngin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEngin.Location = new System.Drawing.Point(28, 86);
            this.dtgEngin.Name = "dtgEngin";
            this.dtgEngin.RowHeadersWidth = 62;
            this.dtgEngin.RowTemplate.Height = 28;
            this.dtgEngin.Size = new System.Drawing.Size(415, 183);
            this.dtgEngin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(503, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pompiers mobilisés";
            // 
            // lblEngin
            // 
            this.lblEngin.AutoSize = true;
            this.lblEngin.Font = new System.Drawing.Font("Arial", 10F);
            this.lblEngin.Location = new System.Drawing.Point(24, 47);
            this.lblEngin.Name = "lblEngin";
            this.lblEngin.Size = new System.Drawing.Size(155, 23);
            this.lblEngin.TabIndex = 0;
            this.lblEngin.Text = "Engins mobilisés";
            // 
            // UC_MobilisationEnginPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.grpMobilisation);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_MobilisationEnginPompier";
            this.Size = new System.Drawing.Size(973, 288);
            this.Load += new System.EventHandler(this.UC_MobilisationEnginPompier_Load);
            this.grpMobilisation.ResumeLayout(false);
            this.grpMobilisation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPompier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEngin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMobilisation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEngin;
        private System.Windows.Forms.DataGridView dtgPompier;
        private System.Windows.Forms.DataGridView dtgEngin;
    }
}
