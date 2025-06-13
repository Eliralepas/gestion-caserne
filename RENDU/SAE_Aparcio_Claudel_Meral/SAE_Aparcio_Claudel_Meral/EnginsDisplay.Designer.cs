namespace UC_GestionEngins
{
    partial class EnginsDisplay
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
            components = new System.ComponentModel.Container();
            lblEnginTitle = new Label();
            lblCodeEngin = new Label();
            lblTitleDate = new Label();
            lblDate = new Label();
            lblTitlePanne = new Label();
            lblTitleMission = new Label();
            pctEnginImage = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            chkEnPanne = new UC_ScalableCheckBox.ScalableCheckBox();
            chkEnMission = new UC_ScalableCheckBox.ScalableCheckBox();
            lblcodeType = new Label();
            ((System.ComponentModel.ISupportInitialize)pctEnginImage).BeginInit();
            SuspendLayout();
            // 
            // lblEnginTitle
            // 
            lblEnginTitle.AutoSize = true;
            lblEnginTitle.Font = new Font("Arial", 16F);
            lblEnginTitle.Location = new Point(22, 29);
            lblEnginTitle.Margin = new Padding(4, 0, 4, 0);
            lblEnginTitle.Name = "lblEnginTitle";
            lblEnginTitle.Size = new Size(117, 25);
            lblEnginTitle.TabIndex = 1;
            lblEnginTitle.Text = "Identifiant :";
            // 
            // lblCodeEngin
            // 
            lblCodeEngin.AutoSize = true;
            lblCodeEngin.Font = new Font("Arial", 16F);
            lblCodeEngin.Location = new Point(273, 29);
            lblCodeEngin.Name = "lblCodeEngin";
            lblCodeEngin.Size = new Size(34, 25);
            lblCodeEngin.TabIndex = 2;
            lblCodeEngin.Text = "ID";
            // 
            // lblTitleDate
            // 
            lblTitleDate.AutoSize = true;
            lblTitleDate.Font = new Font("Arial", 16F);
            lblTitleDate.Location = new Point(22, 68);
            lblTitleDate.Name = "lblTitleDate";
            lblTitleDate.Size = new Size(194, 25);
            lblTitleDate.TabIndex = 3;
            lblTitleDate.Text = "Date d'acquisition :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Arial", 16F);
            lblDate.Location = new Point(273, 68);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(58, 25);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date";
            // 
            // lblTitlePanne
            // 
            lblTitlePanne.AutoSize = true;
            lblTitlePanne.Font = new Font("Arial", 16F);
            lblTitlePanne.Location = new Point(91, 237);
            lblTitlePanne.Margin = new Padding(4, 0, 4, 0);
            lblTitlePanne.Name = "lblTitlePanne";
            lblTitlePanne.Size = new Size(114, 25);
            lblTitlePanne.TabIndex = 5;
            lblTitlePanne.Text = "En panne :";
            // 
            // lblTitleMission
            // 
            lblTitleMission.AutoSize = true;
            lblTitleMission.Font = new Font("Arial", 16F);
            lblTitleMission.Location = new Point(74, 139);
            lblTitleMission.Margin = new Padding(4, 0, 4, 0);
            lblTitleMission.Name = "lblTitleMission";
            lblTitleMission.Size = new Size(130, 25);
            lblTitleMission.TabIndex = 6;
            lblTitleMission.Text = "En mission :";
            // 
            // pctEnginImage
            // 
            pctEnginImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pctEnginImage.ErrorImage = SAE_Aparcio_Claudel_Meral.Properties.Resources.Default;
            pctEnginImage.Image = SAE_Aparcio_Claudel_Meral.Properties.Resources.Default;
            pctEnginImage.Location = new Point(471, 32);
            pctEnginImage.Name = "pctEnginImage";
            pctEnginImage.Size = new Size(297, 251);
            pctEnginImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pctEnginImage.TabIndex = 9;
            pctEnginImage.TabStop = false;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // chkEnPanne
            // 
            chkEnPanne.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            chkEnPanne.BackColor = Color.White;
            chkEnPanne.BorderStyle = BorderStyle.FixedSingle;
            chkEnPanne.Checked = false;
            chkEnPanne.Location = new Point(237, 228);
            chkEnPanne.Margin = new Padding(0);
            chkEnPanne.Name = "chkEnPanne";
            chkEnPanne.ReadOnly = true;
            chkEnPanne.Size = new Size(50, 50);
            chkEnPanne.TabIndex = 13;
            // 
            // chkEnMission
            // 
            chkEnMission.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            chkEnMission.BackColor = Color.White;
            chkEnMission.BorderStyle = BorderStyle.FixedSingle;
            chkEnMission.Checked = false;
            chkEnMission.Location = new Point(237, 130);
            chkEnMission.Margin = new Padding(0);
            chkEnMission.Name = "chkEnMission";
            chkEnMission.ReadOnly = true;
            chkEnMission.Size = new Size(50, 50);
            chkEnMission.TabIndex = 12;
            // 
            // lblcodeType
            // 
            lblcodeType.AutoSize = true;
            lblcodeType.Font = new Font("Arial", 16F);
            lblcodeType.Location = new Point(313, 29);
            lblcodeType.Name = "lblcodeType";
            lblcodeType.Size = new Size(83, 25);
            lblcodeType.TabIndex = 14;
            lblcodeType.Text = "Display";
            // 
            // EnginsDisplay
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(192, 0, 0);
            Controls.Add(lblcodeType);
            Controls.Add(chkEnPanne);
            Controls.Add(chkEnMission);
            Controls.Add(pctEnginImage);
            Controls.Add(lblTitleMission);
            Controls.Add(lblTitlePanne);
            Controls.Add(lblDate);
            Controls.Add(lblTitleDate);
            Controls.Add(lblCodeEngin);
            Controls.Add(lblEnginTitle);
            Font = new Font("Arial", 12F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EnginsDisplay";
            Size = new Size(787, 315);
            Load += EnginsDisplay_Load;
            ((System.ComponentModel.ISupportInitialize)pctEnginImage).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnginTitle;
        private System.Windows.Forms.Label lblCodeEngin;
        private System.Windows.Forms.Label lblTitleDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitlePanne;
        private System.Windows.Forms.Label lblTitleMission;
        private System.Windows.Forms.PictureBox pctEnginImage;
        private System.Windows.Forms.Timer timer;
        private UC_ScalableCheckBox.ScalableCheckBox chkEnMission;
        private UC_ScalableCheckBox.ScalableCheckBox chkEnPanne;
        private Label lblcodeType;
    }
}
