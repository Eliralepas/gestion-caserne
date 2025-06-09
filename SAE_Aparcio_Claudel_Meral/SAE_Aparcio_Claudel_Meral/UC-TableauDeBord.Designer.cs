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
            lblTableauDeBord = new Label();
            panelMissions = new Panel();
            lblBarre = new Label();
            lblEnCours = new Label();
            sckbEnCours = new UC_ScalableCheckBox.ScalableCheckBox();
            SuspendLayout();
            // 
            // lblTableauDeBord
            // 
            lblTableauDeBord.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTableauDeBord.AutoSize = true;
            lblTableauDeBord.Font = new Font("Arial", 20F, FontStyle.Bold);
            lblTableauDeBord.ForeColor = Color.DarkRed;
            lblTableauDeBord.ImageAlign = ContentAlignment.TopCenter;
            lblTableauDeBord.Location = new Point(580, 28);
            lblTableauDeBord.Name = "lblTableauDeBord";
            lblTableauDeBord.Size = new Size(227, 32);
            lblTableauDeBord.TabIndex = 0;
            lblTableauDeBord.Text = "Tableau de bord";
            lblTableauDeBord.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelMissions
            // 
            panelMissions.AutoScroll = true;
            panelMissions.BackColor = Color.DarkRed;
            panelMissions.Location = new Point(19, 95);
            panelMissions.Name = "panelMissions";
            panelMissions.Size = new Size(1139, 530);
            panelMissions.TabIndex = 4;
            // 
            // lblBarre
            // 
            lblBarre.BackColor = Color.DarkRed;
            lblBarre.Font = new Font("Arial", 4F);
            lblBarre.Location = new Point(19, 69);
            lblBarre.Name = "lblBarre";
            lblBarre.Size = new Size(1139, 23);
            lblBarre.TabIndex = 5;
            lblBarre.Text = "                                  ";
            // 
            // lblEnCours
            // 
            lblEnCours.AutoSize = true;
            lblEnCours.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblEnCours.ForeColor = Color.DarkRed;
            lblEnCours.Location = new Point(87, 20);
            lblEnCours.Name = "lblEnCours";
            lblEnCours.Size = new Size(104, 26);
            lblEnCours.TabIndex = 7;
            lblEnCours.Text = "En cours";
            // 
            // sckbEnCours
            // 
            sckbEnCours.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sckbEnCours.BackColor = Color.Transparent;
            sckbEnCours.BorderStyle = BorderStyle.FixedSingle;
            sckbEnCours.Checked = false;
            sckbEnCours.Location = new Point(34, 10);
            sckbEnCours.Margin = new Padding(0);
            sckbEnCours.Name = "sckbEnCours";
            sckbEnCours.ReadOnly = false;
            sckbEnCours.Size = new Size(50, 50);
            sckbEnCours.TabIndex = 8;
            sckbEnCours.CheckedChanged += sckbEnCours_CheckedChanged;
            // 
            // TableauDeBord
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sckbEnCours);
            Controls.Add(lblEnCours);
            Controls.Add(lblBarre);
            Controls.Add(panelMissions);
            Controls.Add(lblTableauDeBord);
            Font = new Font("Arial", 14F);
            Margin = new Padding(5);
            Name = "TableauDeBord";
            Size = new Size(1177, 628);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTableauDeBord;
        private System.Windows.Forms.Panel panelMissions;
        private System.Windows.Forms.Label lblBarre;
        private System.Windows.Forms.Label lblEnCours;
        private UC_ScalableCheckBox.ScalableCheckBox sckbEnCours;
    }
}
