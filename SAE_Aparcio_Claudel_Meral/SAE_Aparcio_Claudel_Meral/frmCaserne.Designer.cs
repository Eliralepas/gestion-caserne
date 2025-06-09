namespace SAE_Aparcio_Claudel_Meral
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
            panelVolet = new Panel();
            panelNavigation = new Panel();
            btnQuitter = new Button();
            btnStatistiques = new NavigationBarUserControl.UCButton();
            btnTableauDeBord = new NavigationBarUserControl.UCButton();
            btnGestionPersonnel = new NavigationBarUserControl.UCButton();
            btnAjoutMission = new NavigationBarUserControl.UCButton();
            btnGestionEngins = new NavigationBarUserControl.UCButton();
            picBoxCaserne = new PictureBox();
            panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxCaserne).BeginInit();
            SuspendLayout();
            // 
            // panelVolet
            // 
            panelVolet.AutoScroll = true;
            panelVolet.Location = new Point(302, 12);
            panelVolet.Name = "panelVolet";
            panelVolet.Size = new Size(1047, 647);
            panelVolet.TabIndex = 2;
            // 
            // panelNavigation
            // 
            panelNavigation.BackColor = Color.DarkRed;
            panelNavigation.Controls.Add(btnQuitter);
            panelNavigation.Controls.Add(btnStatistiques);
            panelNavigation.Controls.Add(btnTableauDeBord);
            panelNavigation.Controls.Add(btnGestionPersonnel);
            panelNavigation.Controls.Add(btnAjoutMission);
            panelNavigation.Controls.Add(btnGestionEngins);
            panelNavigation.Location = new Point(13, 13);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(283, 628);
            panelNavigation.TabIndex = 3;
            // 
            // btnQuitter
            // 
            btnQuitter.AutoSize = true;
            btnQuitter.Font = new Font("Arial", 18.2F, FontStyle.Bold);
            btnQuitter.ForeColor = Color.DarkRed;
            btnQuitter.Location = new Point(77, 561);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(124, 46);
            btnQuitter.TabIndex = 5;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // btnStatistiques
            // 
            btnStatistiques.Buttonimage = Properties.Resources.stat;
            btnStatistiques.buttonText = "Statistiques";
            btnStatistiques.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStatistiques.Location = new Point(14, 387);
            btnStatistiques.Margin = new Padding(4, 5, 4, 5);
            btnStatistiques.Name = "btnStatistiques";
            btnStatistiques.Size = new Size(225, 77);
            btnStatistiques.TabIndex = 3;
            // 
            // btnTableauDeBord
            // 
            btnTableauDeBord.Buttonimage = Properties.Resources.tableau_de_bord1;
            btnTableauDeBord.buttonText = "Tableau de bord";
            btnTableauDeBord.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTableauDeBord.Location = new Point(10, 26);
            btnTableauDeBord.Margin = new Padding(4, 5, 4, 5);
            btnTableauDeBord.Name = "btnTableauDeBord";
            btnTableauDeBord.Size = new Size(229, 83);
            btnTableauDeBord.TabIndex = 0;
            // 
            // btnGestionPersonnel
            // 
            btnGestionPersonnel.Buttonimage = Properties.Resources.perso;
            btnGestionPersonnel.buttonText = "Gestion du personnel";
            btnGestionPersonnel.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGestionPersonnel.Location = new Point(14, 294);
            btnGestionPersonnel.Margin = new Padding(4, 5, 4, 5);
            btnGestionPersonnel.Name = "btnGestionPersonnel";
            btnGestionPersonnel.Size = new Size(225, 83);
            btnGestionPersonnel.TabIndex = 2;
            // 
            // btnAjoutMission
            // 
            btnAjoutMission.Buttonimage = Properties.Resources.alarme;
            btnAjoutMission.buttonText = "Nouvelle mission";
            btnAjoutMission.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjoutMission.Location = new Point(10, 119);
            btnAjoutMission.Margin = new Padding(4, 5, 4, 5);
            btnAjoutMission.Name = "btnAjoutMission";
            btnAjoutMission.Size = new Size(229, 79);
            btnAjoutMission.TabIndex = 4;
            // 
            // btnGestionEngins
            // 
            btnGestionEngins.Buttonimage = Properties.Resources.pompiers;
            btnGestionEngins.buttonText = "Gestion des engins";
            btnGestionEngins.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGestionEngins.Location = new Point(10, 208);
            btnGestionEngins.Margin = new Padding(4, 5, 4, 5);
            btnGestionEngins.Name = "btnGestionEngins";
            btnGestionEngins.Size = new Size(229, 76);
            btnGestionEngins.TabIndex = 1;
            // 
            // picBoxCaserne
            // 
            picBoxCaserne.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picBoxCaserne.BackgroundImageLayout = ImageLayout.Center;
            picBoxCaserne.Image = Properties.Resources.back;
            picBoxCaserne.Location = new Point(-3, -1);
            picBoxCaserne.Name = "picBoxCaserne";
            picBoxCaserne.Size = new Size(1352, 660);
            picBoxCaserne.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxCaserne.TabIndex = 0;
            picBoxCaserne.TabStop = false;
            // 
            // frmCaserne
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1371, 671);
            Controls.Add(panelNavigation);
            Controls.Add(panelVolet);
            Controls.Add(picBoxCaserne);
            Font = new Font("Arial", 14F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "frmCaserne";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quoi ?!  Les soldats du feur";
            Load += frmCaserne_Load;
            panelNavigation.ResumeLayout(false);
            panelNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxCaserne).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCaserne;
        private NavigationBarUserControl.UCButton btnAjoutMission;
        private NavigationBarUserControl.UCButton btnStatistiques;
        private NavigationBarUserControl.UCButton btnGestionPersonnel;
        private NavigationBarUserControl.UCButton btnGestionEngins;
        private NavigationBarUserControl.UCButton btnTableauDeBord;
        private System.Windows.Forms.Panel panelVolet;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnQuitter;
    }
}

