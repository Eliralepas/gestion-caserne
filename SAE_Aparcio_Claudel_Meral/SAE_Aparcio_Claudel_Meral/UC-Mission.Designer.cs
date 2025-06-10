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
            lblMissionId = new Label();
            lblDateDebut = new Label();
            lblNatureMission = new Label();
            lblCaserne = new Label();
            panelMission = new Panel();
            txtMotifMission = new RichTextBox();
            lblDateFin = new Label();
            picBox = new PictureBox();
            btnCreerPdf = new Button();
            btnTerminerMission = new Button();
            panelMission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // lblMissionId
            // 
            lblMissionId.AutoSize = true;
            lblMissionId.Location = new Point(143, 9);
            lblMissionId.Margin = new Padding(2, 0, 2, 0);
            lblMissionId.Name = "lblMissionId";
            lblMissionId.Size = new Size(119, 23);
            lblMissionId.TabIndex = 1;
            lblMissionId.Text = "ID mission : ";
            // 
            // lblDateDebut
            // 
            lblDateDebut.AutoSize = true;
            lblDateDebut.Location = new Point(143, 73);
            lblDateDebut.Margin = new Padding(2, 0, 2, 0);
            lblDateDebut.Name = "lblDateDebut";
            lblDateDebut.Size = new Size(119, 23);
            lblDateDebut.TabIndex = 2;
            lblDateDebut.Text = "Début le    : ";
            // 
            // lblNatureMission
            // 
            lblNatureMission.AutoSize = true;
            lblNatureMission.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblNatureMission.Location = new Point(428, 9);
            lblNatureMission.Margin = new Padding(2, 0, 2, 0);
            lblNatureMission.Name = "lblNatureMission";
            lblNatureMission.Size = new Size(209, 24);
            lblNatureMission.TabIndex = 4;
            lblNatureMission.Text = "Nature de la mission ";
            // 
            // lblCaserne
            // 
            lblCaserne.AutoSize = true;
            lblCaserne.Location = new Point(143, 41);
            lblCaserne.Margin = new Padding(2, 0, 2, 0);
            lblCaserne.Name = "lblCaserne";
            lblCaserne.Size = new Size(120, 23);
            lblCaserne.TabIndex = 3;
            lblCaserne.Text = "Caserne    : ";
            // 
            // panelMission
            // 
            panelMission.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMission.BackColor = Color.White;
            panelMission.BorderStyle = BorderStyle.FixedSingle;
            panelMission.Controls.Add(txtMotifMission);
            panelMission.Controls.Add(lblDateFin);
            panelMission.Controls.Add(picBox);
            panelMission.Controls.Add(lblMissionId);
            panelMission.Controls.Add(lblNatureMission);
            panelMission.Controls.Add(lblCaserne);
            panelMission.Controls.Add(lblDateDebut);
            panelMission.Location = new Point(0, 0);
            panelMission.Name = "panelMission";
            panelMission.Size = new Size(815, 150);
            panelMission.TabIndex = 6;
            // 
            // txtMotifMission
            // 
            txtMotifMission.BackColor = Color.White;
            txtMotifMission.BorderStyle = BorderStyle.None;
            txtMotifMission.ForeColor = Color.DarkRed;
            txtMotifMission.Location = new Point(432, 51);
            txtMotifMission.Name = "txtMotifMission";
            txtMotifMission.ReadOnly = true;
            txtMotifMission.ShortcutsEnabled = false;
            txtMotifMission.Size = new Size(329, 87);
            txtMotifMission.TabIndex = 8;
            txtMotifMission.Text = "--> Motif de la mission";
            // 
            // lblDateFin
            // 
            lblDateFin.AutoSize = true;
            lblDateFin.Location = new Point(144, 105);
            lblDateFin.Margin = new Padding(2, 0, 2, 0);
            lblDateFin.Name = "lblDateFin";
            lblDateFin.Size = new Size(117, 23);
            lblDateFin.TabIndex = 6;
            lblDateFin.Text = "Fin le        : ";
            // 
            // picBox
            // 
            picBox.BorderStyle = BorderStyle.FixedSingle;
            picBox.Image = SAE_Aparcio_Claudel_Meral.Properties.Resources.imageSirene;
            picBox.Location = new Point(20, 25);
            picBox.Margin = new Padding(2);
            picBox.Name = "picBox";
            picBox.Size = new Size(100, 100);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.TabIndex = 0;
            picBox.TabStop = false;
            // 
            // btnCreerPdf
            // 
            btnCreerPdf.BackgroundImage = SAE_Aparcio_Claudel_Meral.Properties.Resources.imagePDF;
            btnCreerPdf.BackgroundImageLayout = ImageLayout.Stretch;
            btnCreerPdf.Location = new Point(825, 74);
            btnCreerPdf.Name = "btnCreerPdf";
            btnCreerPdf.Size = new Size(65, 65);
            btnCreerPdf.TabIndex = 8;
            btnCreerPdf.UseVisualStyleBackColor = true;
            btnCreerPdf.Click += btnCreerPdf_Click;
            // 
            // btnTerminerMission
            // 
            btnTerminerMission.BackgroundImage = SAE_Aparcio_Claudel_Meral.Properties.Resources.imageValider;
            btnTerminerMission.BackgroundImageLayout = ImageLayout.Stretch;
            btnTerminerMission.Location = new Point(825, 6);
            btnTerminerMission.Name = "btnTerminerMission";
            btnTerminerMission.Size = new Size(65, 65);
            btnTerminerMission.TabIndex = 7;
            btnTerminerMission.UseVisualStyleBackColor = true;
            btnTerminerMission.Click += btnTerminerMission_Click;
            // 
            // Mission
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(btnCreerPdf);
            Controls.Add(btnTerminerMission);
            Controls.Add(panelMission);
            Font = new Font("Arial", 12F);
            ForeColor = Color.DarkRed;
            Margin = new Padding(5, 6, 5, 6);
            Name = "Mission";
            Size = new Size(893, 153);
            panelMission.ResumeLayout(false);
            panelMission.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);

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
