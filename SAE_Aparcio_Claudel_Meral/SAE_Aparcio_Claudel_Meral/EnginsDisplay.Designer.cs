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
            this.components = new System.ComponentModel.Container();
            this.lblEnginTitle = new System.Windows.Forms.Label();
            this.lblCodeEngin = new System.Windows.Forms.Label();
            this.lblTitleDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitlePanne = new System.Windows.Forms.Label();
            this.lblTitleMission = new System.Windows.Forms.Label();
            this.pctEnginImage = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chkEnPanne = new UC_ScalableCheckBox.ScalableCheckBox();
            this.chkEnMission = new UC_ScalableCheckBox.ScalableCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctEnginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnginTitle
            // 
            this.lblEnginTitle.AutoSize = true;
            this.lblEnginTitle.Font = new System.Drawing.Font("Arial", 16F);
            this.lblEnginTitle.Location = new System.Drawing.Point(22, 29);
            this.lblEnginTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnginTitle.Name = "lblEnginTitle";
            this.lblEnginTitle.Size = new System.Drawing.Size(148, 32);
            this.lblEnginTitle.TabIndex = 1;
            this.lblEnginTitle.Text = "Identifiant :";
            // 
            // lblCodeEngin
            // 
            this.lblCodeEngin.AutoSize = true;
            this.lblCodeEngin.Font = new System.Drawing.Font("Arial", 16F);
            this.lblCodeEngin.Location = new System.Drawing.Point(273, 29);
            this.lblCodeEngin.Name = "lblCodeEngin";
            this.lblCodeEngin.Size = new System.Drawing.Size(42, 32);
            this.lblCodeEngin.TabIndex = 2;
            this.lblCodeEngin.Text = "ID";
            // 
            // lblTitleDate
            // 
            this.lblTitleDate.AutoSize = true;
            this.lblTitleDate.Font = new System.Drawing.Font("Arial", 16F);
            this.lblTitleDate.Location = new System.Drawing.Point(22, 68);
            this.lblTitleDate.Name = "lblTitleDate";
            this.lblTitleDate.Size = new System.Drawing.Size(245, 32);
            this.lblTitleDate.TabIndex = 3;
            this.lblTitleDate.Text = "Date d\'acquisition :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 16F);
            this.lblDate.Location = new System.Drawing.Point(273, 68);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 32);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblTitlePanne
            // 
            this.lblTitlePanne.AutoSize = true;
            this.lblTitlePanne.Font = new System.Drawing.Font("Arial", 16F);
            this.lblTitlePanne.Location = new System.Drawing.Point(91, 237);
            this.lblTitlePanne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitlePanne.Name = "lblTitlePanne";
            this.lblTitlePanne.Size = new System.Drawing.Size(146, 32);
            this.lblTitlePanne.TabIndex = 5;
            this.lblTitlePanne.Text = "En panne :";
            // 
            // lblTitleMission
            // 
            this.lblTitleMission.AutoSize = true;
            this.lblTitleMission.Font = new System.Drawing.Font("Arial", 16F);
            this.lblTitleMission.Location = new System.Drawing.Point(74, 139);
            this.lblTitleMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleMission.Name = "lblTitleMission";
            this.lblTitleMission.Size = new System.Drawing.Size(163, 32);
            this.lblTitleMission.TabIndex = 6;
            this.lblTitleMission.Text = "En mission :";
            // 
            // pctEnginImage
            // 
            this.pctEnginImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctEnginImage.ErrorImage = global::SAE_Aparcio_Claudel_Meral.Properties.Resources.Default;
            this.pctEnginImage.Image = global::SAE_Aparcio_Claudel_Meral.Properties.Resources.Default;
            this.pctEnginImage.Location = new System.Drawing.Point(471, 32);
            this.pctEnginImage.Name = "pctEnginImage";
            this.pctEnginImage.Size = new System.Drawing.Size(297, 251);
            this.pctEnginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEnginImage.TabIndex = 9;
            this.pctEnginImage.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chkEnPanne
            // 
            this.chkEnPanne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chkEnPanne.BackColor = System.Drawing.Color.White;
            this.chkEnPanne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chkEnPanne.Checked = false;
            this.chkEnPanne.Location = new System.Drawing.Point(237, 228);
            this.chkEnPanne.Margin = new System.Windows.Forms.Padding(0);
            this.chkEnPanne.Name = "chkEnPanne";
            this.chkEnPanne.ReadOnly = true;
            this.chkEnPanne.Size = new System.Drawing.Size(50, 50);
            this.chkEnPanne.TabIndex = 13;
            // 
            // chkEnMission
            // 
            this.chkEnMission.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chkEnMission.BackColor = System.Drawing.Color.White;
            this.chkEnMission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chkEnMission.Checked = false;
            this.chkEnMission.Location = new System.Drawing.Point(237, 130);
            this.chkEnMission.Margin = new System.Windows.Forms.Padding(0);
            this.chkEnMission.Name = "chkEnMission";
            this.chkEnMission.ReadOnly = true;
            this.chkEnMission.Size = new System.Drawing.Size(50, 50);
            this.chkEnMission.TabIndex = 12;
            // 
            // EnginsDisplay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.chkEnPanne);
            this.Controls.Add(this.chkEnMission);
            this.Controls.Add(this.pctEnginImage);
            this.Controls.Add(this.lblTitleMission);
            this.Controls.Add(this.lblTitlePanne);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitleDate);
            this.Controls.Add(this.lblCodeEngin);
            this.Controls.Add(this.lblEnginTitle);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EnginsDisplay";
            this.Size = new System.Drawing.Size(787, 315);
            this.Load += new System.EventHandler(this.EnginsDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctEnginImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
