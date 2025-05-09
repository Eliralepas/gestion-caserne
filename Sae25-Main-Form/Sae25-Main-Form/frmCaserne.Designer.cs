namespace Sae25_Main_Form
{
    partial class frmCaserne
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaserne));
            this.picBoxCaserne = new System.Windows.Forms.PictureBox();
            this.grpNavigation = new System.Windows.Forms.GroupBox();
            this.grpVolet = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCaserne)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxCaserne
            // 
            this.picBoxCaserne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxCaserne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxCaserne.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCaserne.Image")));
            this.picBoxCaserne.Location = new System.Drawing.Point(0, 0);
            this.picBoxCaserne.Name = "picBoxCaserne";
            this.picBoxCaserne.Size = new System.Drawing.Size(1185, 700);
            this.picBoxCaserne.TabIndex = 0;
            this.picBoxCaserne.TabStop = false;
            // 
            // grpNavigation
            // 
            this.grpNavigation.BackColor = System.Drawing.Color.DarkRed;
            this.grpNavigation.Location = new System.Drawing.Point(12, 12);
            this.grpNavigation.Name = "grpNavigation";
            this.grpNavigation.Size = new System.Drawing.Size(296, 629);
            this.grpNavigation.TabIndex = 1;
            this.grpNavigation.TabStop = false;
            // 
            // grpVolet
            // 
            this.grpVolet.Location = new System.Drawing.Point(324, 12);
            this.grpVolet.Name = "grpVolet";
            this.grpVolet.Size = new System.Drawing.Size(846, 629);
            this.grpVolet.TabIndex = 2;
            this.grpVolet.TabStop = false;
            // 
            // frmCaserne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.grpVolet);
            this.Controls.Add(this.grpNavigation);
            this.Controls.Add(this.picBoxCaserne);
            this.Font = new System.Drawing.Font("Arial", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCaserne";
            this.Text = "Pinpon 🚒";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCaserne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCaserne;
        private System.Windows.Forms.GroupBox grpNavigation;
        private System.Windows.Forms.GroupBox grpVolet;
    }
}

