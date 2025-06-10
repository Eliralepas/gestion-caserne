namespace UC_TableauDeBord
{
    partial class TableauDeBord
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
            this.lblTableauDeBord = new System.Windows.Forms.Label();
            this.panelMissions = new System.Windows.Forms.Panel();
            this.lblBarre = new System.Windows.Forms.Label();
            this.lblEnCours = new System.Windows.Forms.Label();
            this.sckbEnCours = new UC_ScalableCheckBox.ScalableCheckBox();
            this.SuspendLayout();
            // 
            // lblTableauDeBord
            // 
            this.lblTableauDeBord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTableauDeBord.AutoSize = true;
            this.lblTableauDeBord.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblTableauDeBord.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTableauDeBord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTableauDeBord.Location = new System.Drawing.Point(383, 20);
            this.lblTableauDeBord.Name = "lblTableauDeBord";
            this.lblTableauDeBord.Size = new System.Drawing.Size(227, 32);
            this.lblTableauDeBord.TabIndex = 0;
            this.lblTableauDeBord.Text = "Tableau de bord";
            this.lblTableauDeBord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMissions
            // 
            this.panelMissions.AutoScroll = true;
            this.panelMissions.BackColor = System.Drawing.Color.DarkRed;
            this.panelMissions.Location = new System.Drawing.Point(19, 95);
            this.panelMissions.Name = "panelMissions";
            this.panelMissions.Size = new System.Drawing.Size(960, 487);
            this.panelMissions.TabIndex = 4;
            // 
            // lblBarre
            // 
            this.lblBarre.BackColor = System.Drawing.Color.DarkRed;
            this.lblBarre.Font = new System.Drawing.Font("Arial", 4F);
            this.lblBarre.Location = new System.Drawing.Point(32, 69);
            this.lblBarre.Name = "lblBarre";
            this.lblBarre.Size = new System.Drawing.Size(933, 10);
            this.lblBarre.TabIndex = 5;
            this.lblBarre.Text = "                                  ";
            // 
            // lblEnCours
            // 
            this.lblEnCours.AutoSize = true;
            this.lblEnCours.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblEnCours.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEnCours.Location = new System.Drawing.Point(87, 20);
            this.lblEnCours.Name = "lblEnCours";
            this.lblEnCours.Size = new System.Drawing.Size(104, 26);
            this.lblEnCours.TabIndex = 7;
            this.lblEnCours.Text = "En cours";
            // 
            // sckbEnCours
            // 
            this.sckbEnCours.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sckbEnCours.BackColor = System.Drawing.Color.Transparent;
            this.sckbEnCours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sckbEnCours.Checked = false;
            this.sckbEnCours.Location = new System.Drawing.Point(34, 10);
            this.sckbEnCours.Margin = new System.Windows.Forms.Padding(0);
            this.sckbEnCours.Name = "sckbEnCours";
            this.sckbEnCours.ReadOnly = false;
            this.sckbEnCours.Size = new System.Drawing.Size(50, 50);
            this.sckbEnCours.TabIndex = 8;
            this.sckbEnCours.CheckedChanged += new UC_ScalableCheckBox.CheckedChangedEventHandler(this.sckbEnCours_CheckedChanged);
            // 
            // TableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.sckbEnCours);
            this.Controls.Add(this.lblEnCours);
            this.Controls.Add(this.lblBarre);
            this.Controls.Add(this.panelMissions);
            this.Controls.Add(this.lblTableauDeBord);
            this.Font = new System.Drawing.Font("Arial", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TableauDeBord";
            this.Size = new System.Drawing.Size(1000, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableauDeBord;
        private System.Windows.Forms.Panel panelMissions;
        private System.Windows.Forms.Label lblBarre;
        private System.Windows.Forms.Label lblEnCours;
        private UC_ScalableCheckBox.ScalableCheckBox sckbEnCours;
    }
}
