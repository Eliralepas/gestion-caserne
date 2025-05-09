namespace UserControlMission
{
    partial class ucMission
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblNumMission = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpDecision = new System.Windows.Forms.GroupBox();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.cboNature = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblNatSin = new System.Windows.Forms.Label();
            this.grpAdr = new System.Windows.Forms.GroupBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.grpDecision.SuspendLayout();
            this.grpAdr.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotif);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(22, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(462, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motif";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(22, 45);
            this.txtMotif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(415, 158);
            this.txtMotif.TabIndex = 4;
            // 
            // lblNumMission
            // 
            this.lblNumMission.AutoSize = true;
            this.lblNumMission.BackColor = System.Drawing.Color.DarkRed;
            this.lblNumMission.ForeColor = System.Drawing.Color.White;
            this.lblNumMission.Location = new System.Drawing.Point(471, 11);
            this.lblNumMission.Name = "lblNumMission";
            this.lblNumMission.Size = new System.Drawing.Size(100, 23);
            this.lblNumMission.TabIndex = 1;
            this.lblNumMission.Text = "Mission n°";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(799, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(134, 23);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Déclenché le :";
            // 
            // grpDecision
            // 
            this.grpDecision.Controls.Add(this.cboCaserne);
            this.grpDecision.Controls.Add(this.cboNature);
            this.grpDecision.Controls.Add(this.lblCaserne);
            this.grpDecision.Controls.Add(this.lblNatSin);
            this.grpDecision.ForeColor = System.Drawing.Color.White;
            this.grpDecision.Location = new System.Drawing.Point(16, 404);
            this.grpDecision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDecision.Name = "grpDecision";
            this.grpDecision.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDecision.Size = new System.Drawing.Size(1045, 132);
            this.grpDecision.TabIndex = 1;
            this.grpDecision.TabStop = false;
            this.grpDecision.Text = "Décisions du régulateurs";
            // 
            // cboCaserne
            // 
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(543, 81);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(423, 31);
            this.cboCaserne.TabIndex = 18;
            // 
            // cboNature
            // 
            this.cboNature.FormattingEnabled = true;
            this.cboNature.Location = new System.Drawing.Point(22, 81);
            this.cboNature.Name = "cboNature";
            this.cboNature.Size = new System.Drawing.Size(345, 31);
            this.cboNature.TabIndex = 17;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(539, 55);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(185, 23);
            this.lblCaserne.TabIndex = 16;
            this.lblCaserne.Text = "Caserne à mobiliser";
            // 
            // lblNatSin
            // 
            this.lblNatSin.AutoSize = true;
            this.lblNatSin.Location = new System.Drawing.Point(18, 55);
            this.lblNatSin.Name = "lblNatSin";
            this.lblNatSin.Size = new System.Drawing.Size(163, 23);
            this.lblNatSin.TabIndex = 15;
            this.lblNatSin.Text = "Nature du sinistre";
            // 
            // grpAdr
            // 
            this.grpAdr.Controls.Add(this.txtCP);
            this.grpAdr.Controls.Add(this.txtVille);
            this.grpAdr.Controls.Add(this.txtRue);
            this.grpAdr.Controls.Add(this.lblVille);
            this.grpAdr.Controls.Add(this.lblCP);
            this.grpAdr.Controls.Add(this.lblRue);
            this.grpAdr.ForeColor = System.Drawing.Color.White;
            this.grpAdr.Location = new System.Drawing.Point(507, 37);
            this.grpAdr.Name = "grpAdr";
            this.grpAdr.Size = new System.Drawing.Size(520, 230);
            this.grpAdr.TabIndex = 3;
            this.grpAdr.TabStop = false;
            this.grpAdr.Text = "Adresse sinistre";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(139, 148);
            this.txtCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(116, 30);
            this.txtCP.TabIndex = 16;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(85, 106);
            this.txtVille.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(216, 30);
            this.txtVille.TabIndex = 15;
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(85, 65);
            this.txtRue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(422, 30);
            this.txtRue.TabIndex = 14;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(17, 109);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(46, 23);
            this.lblVille.TabIndex = 13;
            this.lblVille.Text = "Ville";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(17, 151);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(116, 23);
            this.lblCP.TabIndex = 12;
            this.lblCP.Text = "Code postal";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(17, 68);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(45, 23);
            this.lblRue.TabIndex = 11;
            this.lblRue.Text = "Rue";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(702, 558);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(161, 37);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(900, 558);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(161, 37);
            this.btnValider.TabIndex = 20;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(900, 891);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(161, 37);
            this.btnFermer.TabIndex = 21;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.groupBox1);
            this.grpInfo.Controls.Add(this.grpAdr);
            this.grpInfo.ForeColor = System.Drawing.Color.White;
            this.grpInfo.Location = new System.Drawing.Point(16, 77);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(1045, 297);
            this.grpInfo.TabIndex = 22;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informations usager";
            // 
            // ucMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.grpDecision);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNumMission);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucMission";
            this.Size = new System.Drawing.Size(1085, 953);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDecision.ResumeLayout(false);
            this.grpDecision.PerformLayout();
            this.grpAdr.ResumeLayout(false);
            this.grpAdr.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumMission;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpDecision;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.ComboBox cboNature;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblNatSin;
        private System.Windows.Forms.GroupBox grpAdr;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.GroupBox grpInfo;
    }
}
