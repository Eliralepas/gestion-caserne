namespace UCGestionEngins
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
            this.chkMission = new System.Windows.Forms.CheckBox();
            this.chkEnPanne = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctEnginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnginTitle
            // 
            this.lblEnginTitle.AutoSize = true;
            this.lblEnginTitle.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnginTitle.Location = new System.Drawing.Point(22, 29);
            this.lblEnginTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnginTitle.Name = "lblEnginTitle";
            this.lblEnginTitle.Size = new System.Drawing.Size(214, 35);
            this.lblEnginTitle.TabIndex = 1;
            this.lblEnginTitle.Text = "Identifiant Engin : ";
            // 
            // lblCodeEngin
            // 
            this.lblCodeEngin.AutoSize = true;
            this.lblCodeEngin.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeEngin.Location = new System.Drawing.Point(204, 29);
            this.lblCodeEngin.Name = "lblCodeEngin";
            this.lblCodeEngin.Size = new System.Drawing.Size(211, 35);
            this.lblCodeEngin.TabIndex = 2;
            this.lblCodeEngin.Text = "Display Text Here";
            // 
            // lblTitleDate
            // 
            this.lblTitleDate.AutoSize = true;
            this.lblTitleDate.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDate.Location = new System.Drawing.Point(22, 68);
            this.lblTitleDate.Name = "lblTitleDate";
            this.lblTitleDate.Size = new System.Drawing.Size(224, 35);
            this.lblTitleDate.TabIndex = 3;
            this.lblTitleDate.Text = "Date d\'acquisition :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(204, 68);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(211, 35);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Display Text Here";
            // 
            // lblTitlePanne
            // 
            this.lblTitlePanne.AutoSize = true;
            this.lblTitlePanne.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePanne.Location = new System.Drawing.Point(91, 236);
            this.lblTitlePanne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitlePanne.Name = "lblTitlePanne";
            this.lblTitlePanne.Size = new System.Drawing.Size(136, 35);
            this.lblTitlePanne.TabIndex = 5;
            this.lblTitlePanne.Text = "En panne :";
            // 
            // lblTitleMission
            // 
            this.lblTitleMission.AutoSize = true;
            this.lblTitleMission.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMission.Location = new System.Drawing.Point(85, 140);
            this.lblTitleMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleMission.Name = "lblTitleMission";
            this.lblTitleMission.Size = new System.Drawing.Size(148, 35);
            this.lblTitleMission.TabIndex = 6;
            this.lblTitleMission.Text = "En mission :";
            // 
            // pctEnginImage
            // 
            this.pctEnginImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctEnginImage.ErrorImage = global::UCGestionEngins.Properties.Resources.Default;
            this.pctEnginImage.Image = global::UCGestionEngins.Properties.Resources.Default;
            this.pctEnginImage.Location = new System.Drawing.Point(471, 32);
            this.pctEnginImage.Name = "pctEnginImage";
            this.pctEnginImage.Size = new System.Drawing.Size(297, 251);
            this.pctEnginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEnginImage.TabIndex = 9;
            this.pctEnginImage.TabStop = false;
            // 
            // chkMission
            // 
            this.chkMission.AutoSize = true;
            this.chkMission.Location = new System.Drawing.Point(240, 152);
            this.chkMission.Name = "chkMission";
            this.chkMission.Size = new System.Drawing.Size(18, 17);
            this.chkMission.TabIndex = 10;
            this.chkMission.UseVisualStyleBackColor = true;
            // 
            // chkEnPanne
            // 
            this.chkEnPanne.AutoSize = true;
            this.chkEnPanne.Location = new System.Drawing.Point(240, 248);
            this.chkEnPanne.Name = "chkEnPanne";
            this.chkEnPanne.Size = new System.Drawing.Size(18, 17);
            this.chkEnPanne.TabIndex = 11;
            this.chkEnPanne.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // EnginsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.chkEnPanne);
            this.Controls.Add(this.chkMission);
            this.Controls.Add(this.pctEnginImage);
            this.Controls.Add(this.lblTitleMission);
            this.Controls.Add(this.lblTitlePanne);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitleDate);
            this.Controls.Add(this.lblCodeEngin);
            this.Controls.Add(this.lblEnginTitle);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.CheckBox chkMission;
        private System.Windows.Forms.CheckBox chkEnPanne;
        private System.Windows.Forms.Timer timer;
    }
}
