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
            this.ckbEnCours = new System.Windows.Forms.CheckBox();
            this.panelMissions = new System.Windows.Forms.Panel();
            this.lblBarre = new System.Windows.Forms.Label();
            this.btnTerminerMission = new System.Windows.Forms.Button();
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
            this.lblTableauDeBord.Location = new System.Drawing.Point(343, 20);
            this.lblTableauDeBord.Name = "lblTableauDeBord";
            this.lblTableauDeBord.Size = new System.Drawing.Size(277, 40);
            this.lblTableauDeBord.TabIndex = 0;
            this.lblTableauDeBord.Text = "Tableau de bord";
            this.lblTableauDeBord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ckbEnCours
            // 
            this.ckbEnCours.AutoSize = true;
            this.ckbEnCours.BackColor = System.Drawing.SystemColors.Control;
            this.ckbEnCours.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEnCours.ForeColor = System.Drawing.Color.DarkRed;
            this.ckbEnCours.Location = new System.Drawing.Point(32, 29);
            this.ckbEnCours.Name = "ckbEnCours";
            this.ckbEnCours.Size = new System.Drawing.Size(134, 31);
            this.ckbEnCours.TabIndex = 1;
            this.ckbEnCours.Text = "En cours";
            this.ckbEnCours.UseVisualStyleBackColor = false;
            this.ckbEnCours.CheckedChanged += new System.EventHandler(this.ckbEnCours_CheckedChanged);
            // 
            // panelMissions
            // 
            this.panelMissions.AutoScroll = true;
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
            // btnTerminerMission
            // 
            this.btnTerminerMission.AutoSize = true;
            this.btnTerminerMission.Location = new System.Drawing.Point(763, 23);
            this.btnTerminerMission.Name = "btnTerminerMission";
            this.btnTerminerMission.Size = new System.Drawing.Size(202, 37);
            this.btnTerminerMission.TabIndex = 6;
            this.btnTerminerMission.Text = "Terminer mission";
            this.btnTerminerMission.UseVisualStyleBackColor = true;
            this.btnTerminerMission.Click += new System.EventHandler(this.btnTerminerMission_Click);
            // 
            // TableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTerminerMission);
            this.Controls.Add(this.lblBarre);
            this.Controls.Add(this.panelMissions);
            this.Controls.Add(this.ckbEnCours);
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
        private System.Windows.Forms.CheckBox ckbEnCours;
        private System.Windows.Forms.Panel panelMissions;
        private System.Windows.Forms.Label lblBarre;
        private System.Windows.Forms.Button btnTerminerMission;
    }
}
