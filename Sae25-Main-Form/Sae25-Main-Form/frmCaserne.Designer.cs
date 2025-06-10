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
            this.panelVolet = new System.Windows.Forms.Panel();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnStatistiques = new NavigationBarUserControl.UCButton();
            this.btnTableauDeBord = new NavigationBarUserControl.UCButton();
            this.btnGestionPersonnel = new NavigationBarUserControl.UCButton();
            this.btnAjoutMission = new NavigationBarUserControl.UCButton();
            this.btnGestionEngins = new NavigationBarUserControl.UCButton();
            this.picBoxCaserne = new System.Windows.Forms.PictureBox();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCaserne)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVolet
            // 
            this.panelVolet.AutoScroll = true;
            this.panelVolet.Location = new System.Drawing.Point(367, 39);
            this.panelVolet.Name = "panelVolet";
            this.panelVolet.Size = new System.Drawing.Size(1003, 647);
            this.panelVolet.TabIndex = 2;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.DarkRed;
            this.panelNavigation.Controls.Add(this.btnQuitter);
            this.panelNavigation.Controls.Add(this.btnStatistiques);
            this.panelNavigation.Controls.Add(this.btnTableauDeBord);
            this.panelNavigation.Controls.Add(this.btnGestionPersonnel);
            this.panelNavigation.Controls.Add(this.btnAjoutMission);
            this.panelNavigation.Controls.Add(this.btnGestionEngins);
            this.panelNavigation.Location = new System.Drawing.Point(12, 39);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(336, 646);
            this.panelNavigation.TabIndex = 3;
            // 
            // btnQuitter
            // 
            this.btnQuitter.AutoSize = true;
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 18.2F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.ForeColor = System.Drawing.Color.DarkRed;
            this.btnQuitter.Location = new System.Drawing.Point(94, 579);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(124, 46);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatistiques.Buttonimage = global::Sae25_Main_Form.Properties.Resources.stat;
            this.btnStatistiques.buttonText = "Statistiques";
            this.btnStatistiques.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistiques.IsClicked = false;
            this.btnStatistiques.Location = new System.Drawing.Point(10, 451);
            this.btnStatistiques.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Size = new System.Drawing.Size(275, 77);
            this.btnStatistiques.TabIndex = 3;
            // 
            // btnTableauDeBord
            // 
            this.btnTableauDeBord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTableauDeBord.Buttonimage = global::Sae25_Main_Form.Properties.Resources.tableau_de_bord;
            this.btnTableauDeBord.buttonText = "Tableau de bord";
            this.btnTableauDeBord.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableauDeBord.IsClicked = false;
            this.btnTableauDeBord.Location = new System.Drawing.Point(10, 26);
            this.btnTableauDeBord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTableauDeBord.Name = "btnTableauDeBord";
            this.btnTableauDeBord.Size = new System.Drawing.Size(275, 83);
            this.btnTableauDeBord.TabIndex = 0;
            // 
            // btnGestionPersonnel
            // 
            this.btnGestionPersonnel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGestionPersonnel.Buttonimage = global::Sae25_Main_Form.Properties.Resources.perso;
            this.btnGestionPersonnel.buttonText = "Gestion du personnel";
            this.btnGestionPersonnel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPersonnel.IsClicked = false;
            this.btnGestionPersonnel.Location = new System.Drawing.Point(10, 343);
            this.btnGestionPersonnel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGestionPersonnel.Name = "btnGestionPersonnel";
            this.btnGestionPersonnel.Size = new System.Drawing.Size(275, 83);
            this.btnGestionPersonnel.TabIndex = 2;
            // 
            // btnAjoutMission
            // 
            this.btnAjoutMission.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAjoutMission.Buttonimage = global::Sae25_Main_Form.Properties.Resources.alarme;
            this.btnAjoutMission.buttonText = "Nouvelle mission";
            this.btnAjoutMission.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutMission.IsClicked = false;
            this.btnAjoutMission.Location = new System.Drawing.Point(10, 137);
            this.btnAjoutMission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjoutMission.Name = "btnAjoutMission";
            this.btnAjoutMission.Size = new System.Drawing.Size(275, 79);
            this.btnAjoutMission.TabIndex = 4;
            // 
            // btnGestionEngins
            // 
            this.btnGestionEngins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGestionEngins.Buttonimage = global::Sae25_Main_Form.Properties.Resources.pompiers;
            this.btnGestionEngins.buttonText = "Gestion des engins";
            this.btnGestionEngins.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEngins.IsClicked = false;
            this.btnGestionEngins.Location = new System.Drawing.Point(10, 241);
            this.btnGestionEngins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGestionEngins.Name = "btnGestionEngins";
            this.btnGestionEngins.Size = new System.Drawing.Size(275, 76);
            this.btnGestionEngins.TabIndex = 1;
            // 
            // picBoxCaserne
            // 
            this.picBoxCaserne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxCaserne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxCaserne.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBoxCaserne.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCaserne.Image")));
            this.picBoxCaserne.Location = new System.Drawing.Point(-3, -1);
            this.picBoxCaserne.Name = "picBoxCaserne";
            this.picBoxCaserne.Size = new System.Drawing.Size(1392, 730);
            this.picBoxCaserne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCaserne.TabIndex = 0;
            this.picBoxCaserne.TabStop = false;
            // 
            // frmCaserne
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1382, 723);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelVolet);
            this.Controls.Add(this.picBoxCaserne);
            this.Font = new System.Drawing.Font("Arial", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCaserne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quoi ?!  Les soldats du feur";
            this.Load += new System.EventHandler(this.frmCaserne_Load);
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCaserne)).EndInit();
            this.ResumeLayout(false);

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

