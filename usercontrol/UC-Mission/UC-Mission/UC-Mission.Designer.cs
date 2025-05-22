namespace UC_Mission
{
    partial class Mission
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
            this.lblMissionId = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblNatureMission = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.panelMission = new System.Windows.Forms.Panel();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.btnCreerPdf = new System.Windows.Forms.Button();
            this.btnTerminerMission = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.txtMotifMission = new System.Windows.Forms.RichTextBox();
            this.panelMission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMissionId
            // 
            this.lblMissionId.AutoSize = true;
            this.lblMissionId.Location = new System.Drawing.Point(143, 9);
            this.lblMissionId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMissionId.Name = "lblMissionId";
            this.lblMissionId.Size = new System.Drawing.Size(119, 23);
            this.lblMissionId.TabIndex = 1;
            this.lblMissionId.Text = "ID mission : ";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(143, 73);
            this.lblDateDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(119, 23);
            this.lblDateDebut.TabIndex = 2;
            this.lblDateDebut.Text = "Début le    : ";
            // 
            // lblNatureMission
            // 
            this.lblNatureMission.AutoSize = true;
            this.lblNatureMission.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNatureMission.Location = new System.Drawing.Point(428, 9);
            this.lblNatureMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNatureMission.Name = "lblNatureMission";
            this.lblNatureMission.Size = new System.Drawing.Size(209, 24);
            this.lblNatureMission.TabIndex = 4;
            this.lblNatureMission.Text = "Nature de la mission ";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(143, 41);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(120, 23);
            this.lblCaserne.TabIndex = 3;
            this.lblCaserne.Text = "Caserne    : ";
            // 
            // panelMission
            // 
            this.panelMission.BackColor = System.Drawing.Color.White;
            this.panelMission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMission.Controls.Add(this.txtMotifMission);
            this.panelMission.Controls.Add(this.lblDateFin);
            this.panelMission.Controls.Add(this.picBox);
            this.panelMission.Controls.Add(this.lblMissionId);
            this.panelMission.Controls.Add(this.lblNatureMission);
            this.panelMission.Controls.Add(this.lblCaserne);
            this.panelMission.Controls.Add(this.lblDateDebut);
            this.panelMission.Location = new System.Drawing.Point(0, 0);
            this.panelMission.Name = "panelMission";
            this.panelMission.Size = new System.Drawing.Size(815, 150);
            this.panelMission.TabIndex = 6;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(144, 105);
            this.lblDateFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(123, 23);
            this.lblDateFin.TabIndex = 6;
            this.lblDateFin.Text = "Fin le        :  ";
            // 
            // btnCreerPdf
            // 
            this.btnCreerPdf.BackgroundImage = global::UC_Mission.Properties.Resources.imagePDF;
            this.btnCreerPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreerPdf.Location = new System.Drawing.Point(825, 74);
            this.btnCreerPdf.Name = "btnCreerPdf";
            this.btnCreerPdf.Size = new System.Drawing.Size(65, 65);
            this.btnCreerPdf.TabIndex = 8;
            this.btnCreerPdf.UseVisualStyleBackColor = true;
            this.btnCreerPdf.Click += new System.EventHandler(this.btnCreerPdf_Click);
            // 
            // btnTerminerMission
            // 
            this.btnTerminerMission.BackgroundImage = global::UC_Mission.Properties.Resources.imageValider;
            this.btnTerminerMission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTerminerMission.Location = new System.Drawing.Point(825, 6);
            this.btnTerminerMission.Name = "btnTerminerMission";
            this.btnTerminerMission.Size = new System.Drawing.Size(65, 65);
            this.btnTerminerMission.TabIndex = 7;
            this.btnTerminerMission.UseVisualStyleBackColor = true;
            this.btnTerminerMission.Click += new System.EventHandler(this.btnTerminerMission_Click);
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Image = global::UC_Mission.Properties.Resources.imageSirene;
            this.picBox.Location = new System.Drawing.Point(20, 25);
            this.picBox.Margin = new System.Windows.Forms.Padding(2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(100, 100);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // txtMotifMission
            // 
            this.txtMotifMission.BackColor = System.Drawing.Color.White;
            this.txtMotifMission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMotifMission.ForeColor = System.Drawing.Color.DarkRed;
            this.txtMotifMission.Location = new System.Drawing.Point(432, 51);
            this.txtMotifMission.Name = "txtMotifMission";
            this.txtMotifMission.ReadOnly = true;
            this.txtMotifMission.ShortcutsEnabled = false;
            this.txtMotifMission.Size = new System.Drawing.Size(329, 87);
            this.txtMotifMission.TabIndex = 8;
            this.txtMotifMission.Text = "--> Motif de la mission";
            // 
            // Mission
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnCreerPdf);
            this.Controls.Add(this.btnTerminerMission);
            this.Controls.Add(this.panelMission);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Mission";
            this.Size = new System.Drawing.Size(900, 150);
            this.panelMission.ResumeLayout(false);
            this.panelMission.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblMissionId;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblNatureMission;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Panel panelMission;
        private System.Windows.Forms.Button btnTerminerMission;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Button btnCreerPdf;
        private System.Windows.Forms.RichTextBox txtMotifMission;
    }
}
