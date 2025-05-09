namespace UC_Mission
{
    partial class UC_Mission
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblIdMission = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.panelMission = new System.Windows.Forms.Panel();
            this.btnCreerPdf = new System.Windows.Forms.Button();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.btnVoirPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.panelMission.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(20, 25);
            this.picBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(100, 100);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // lblIdMission
            // 
            this.lblIdMission.AutoSize = true;
            this.lblIdMission.Location = new System.Drawing.Point(143, 9);
            this.lblIdMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdMission.Name = "lblIdMission";
            this.lblIdMission.Size = new System.Drawing.Size(119, 23);
            this.lblIdMission.TabIndex = 1;
            this.lblIdMission.Text = "ID mission : ";
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
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNature.Location = new System.Drawing.Point(428, 9);
            this.lblNature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(209, 24);
            this.lblNature.TabIndex = 4;
            this.lblNature.Text = "Nature de la mission ";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(431, 73);
            this.lblMotif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(206, 23);
            this.lblMotif.TabIndex = 5;
            this.lblMotif.Text = "--> Motif de la mission";
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
            this.panelMission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMission.Controls.Add(this.lblDateFin);
            this.panelMission.Controls.Add(this.lblMotif);
            this.panelMission.Controls.Add(this.picBox);
            this.panelMission.Controls.Add(this.lblIdMission);
            this.panelMission.Controls.Add(this.lblNature);
            this.panelMission.Controls.Add(this.lblCaserne);
            this.panelMission.Controls.Add(this.lblDateDebut);
            this.panelMission.Location = new System.Drawing.Point(0, 0);
            this.panelMission.Name = "panelMission";
            this.panelMission.Size = new System.Drawing.Size(815, 150);
            this.panelMission.TabIndex = 6;
            // 
            // btnCreerPdf
            // 
            this.btnCreerPdf.Location = new System.Drawing.Point(825, 6);
            this.btnCreerPdf.Name = "btnCreerPdf";
            this.btnCreerPdf.Size = new System.Drawing.Size(65, 65);
            this.btnCreerPdf.TabIndex = 7;
            this.btnCreerPdf.UseVisualStyleBackColor = true;
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
            // btnVoirPdf
            // 
            this.btnVoirPdf.Location = new System.Drawing.Point(825, 74);
            this.btnVoirPdf.Name = "btnVoirPdf";
            this.btnVoirPdf.Size = new System.Drawing.Size(65, 65);
            this.btnVoirPdf.TabIndex = 8;
            this.btnVoirPdf.UseVisualStyleBackColor = true;
            // 
            // UC_Mission
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnVoirPdf);
            this.Controls.Add(this.btnCreerPdf);
            this.Controls.Add(this.panelMission);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UC_Mission";
            this.Size = new System.Drawing.Size(900, 150);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.panelMission.ResumeLayout(false);
            this.panelMission.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblIdMission;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Panel panelMission;
        private System.Windows.Forms.Button btnCreerPdf;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Button btnVoirPdf;
    }
}
