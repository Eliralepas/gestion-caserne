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
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblNumMission = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpDecision = new System.Windows.Forms.GroupBox();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.cboNature = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblNatSin = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpMob = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uC_MobilisationEnginPompier1 = new UserControlMission.UC_MobilisationEnginPompier();
            this.uC_MobilisationEnginPompier2 = new UserControlMission.UC_MobilisationEnginPompier();
            this.grpDecision.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.grpMob.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(33, 76);
            this.txtMotif.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(363, 159);
            this.txtMotif.TabIndex = 4;
            // 
            // lblNumMission
            // 
            this.lblNumMission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumMission.AutoSize = true;
            this.lblNumMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.lblNumMission.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMission.ForeColor = System.Drawing.Color.White;
            this.lblNumMission.Location = new System.Drawing.Point(33, 26);
            this.lblNumMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumMission.Name = "lblNumMission";
            this.lblNumMission.Size = new System.Drawing.Size(136, 29);
            this.lblNumMission.TabIndex = 1;
            this.lblNumMission.Text = "Mission n°";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9F);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(651, 52);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(134, 21);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Déclenchée le :";
            // 
            // grpDecision
            // 
            this.grpDecision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDecision.Controls.Add(this.cboCaserne);
            this.grpDecision.Controls.Add(this.cboNature);
            this.grpDecision.Controls.Add(this.lblCaserne);
            this.grpDecision.Controls.Add(this.lblNatSin);
            this.grpDecision.Font = new System.Drawing.Font("Arial", 12F);
            this.grpDecision.ForeColor = System.Drawing.Color.White;
            this.grpDecision.Location = new System.Drawing.Point(16, 368);
            this.grpDecision.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpDecision.Name = "grpDecision";
            this.grpDecision.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpDecision.Size = new System.Drawing.Size(956, 131);
            this.grpDecision.TabIndex = 1;
            this.grpDecision.TabStop = false;
            this.grpDecision.Text = "Décisions du régulateurs";
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(486, 65);
            this.cboCaserne.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(394, 35);
            this.cboCaserne.TabIndex = 18;
            // 
            // cboNature
            // 
            this.cboNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNature.FormattingEnabled = true;
            this.cboNature.Location = new System.Drawing.Point(22, 65);
            this.cboNature.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboNature.Name = "cboNature";
            this.cboNature.Size = new System.Drawing.Size(345, 35);
            this.cboNature.TabIndex = 17;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCaserne.Location = new System.Drawing.Point(482, 32);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(185, 23);
            this.lblCaserne.TabIndex = 16;
            this.lblCaserne.Text = "Caserne à mobiliser";
            // 
            // lblNatSin
            // 
            this.lblNatSin.AutoSize = true;
            this.lblNatSin.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNatSin.Location = new System.Drawing.Point(18, 39);
            this.lblNatSin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNatSin.Name = "lblNatSin";
            this.lblNatSin.Size = new System.Drawing.Size(163, 23);
            this.lblNatSin.TabIndex = 15;
            this.lblNatSin.Text = "Nature du sinistre";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(517, 183);
            this.txtCP.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(116, 35);
            this.txtCP.TabIndex = 16;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(701, 183);
            this.txtVille.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(215, 35);
            this.txtVille.TabIndex = 15;
            this.txtVille.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVille_KeyPress);
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(517, 113);
            this.txtRue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(399, 35);
            this.txtRue.TabIndex = 14;
            this.txtRue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVille_KeyPress);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Arial", 10F);
            this.lblVille.Location = new System.Drawing.Point(697, 156);
            this.lblVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(46, 23);
            this.lblVille.TabIndex = 13;
            this.lblVille.Text = "Ville";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCP.Location = new System.Drawing.Point(513, 156);
            this.lblCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(116, 23);
            this.lblCP.TabIndex = 12;
            this.lblCP.Text = "Code postal";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Arial", 10F);
            this.lblRue.Location = new System.Drawing.Point(513, 86);
            this.lblRue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(45, 23);
            this.lblRue.TabIndex = 11;
            this.lblRue.Text = "Rue";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Location = new System.Drawing.Point(615, 506);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(149, 36);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValider.Location = new System.Drawing.Point(805, 506);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(149, 36);
            this.btnValider.TabIndex = 20;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.txtCP);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.txtVille);
            this.grpInfo.Controls.Add(this.txtMotif);
            this.grpInfo.Controls.Add(this.txtRue);
            this.grpInfo.Controls.Add(this.lblVille);
            this.grpInfo.Controls.Add(this.lblCP);
            this.grpInfo.Controls.Add(this.lblRue);
            this.grpInfo.Font = new System.Drawing.Font("Arial", 12F);
            this.grpInfo.ForeColor = System.Drawing.Color.White;
            this.grpInfo.Location = new System.Drawing.Point(16, 78);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpInfo.Size = new System.Drawing.Size(956, 259);
            this.grpInfo.TabIndex = 22;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informations usager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Motif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(513, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Adresse du sinistre";
            // 
            // grpMob
            // 
            this.grpMob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMob.Controls.Add(this.uC_MobilisationEnginPompier2);
            this.grpMob.Controls.Add(this.uC_MobilisationEnginPompier1);
            this.grpMob.Controls.Add(this.label3);
            this.grpMob.Controls.Add(this.label4);
            this.grpMob.Font = new System.Drawing.Font("Arial", 12F);
            this.grpMob.ForeColor = System.Drawing.Color.White;
            this.grpMob.Location = new System.Drawing.Point(16, 564);
            this.grpMob.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpMob.Name = "grpMob";
            this.grpMob.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpMob.Size = new System.Drawing.Size(956, 265);
            this.grpMob.TabIndex = 19;
            this.grpMob.TabStop = false;
            this.grpMob.Text = "Mobilisation des engins et pompiers";
            this.grpMob.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(499, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pompiers mobilisés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(18, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Engins mobilisés";
            // 
            // uC_MobilisationEnginPompier1
            // 
            this.uC_MobilisationEnginPompier1.BackColor = System.Drawing.Color.DarkRed;
            this.uC_MobilisationEnginPompier1.Font = new System.Drawing.Font("Arial", 10F);
            this.uC_MobilisationEnginPompier1.Location = new System.Drawing.Point(22, 66);
            this.uC_MobilisationEnginPompier1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_MobilisationEnginPompier1.Name = "uC_MobilisationEnginPompier1";
            this.uC_MobilisationEnginPompier1.Size = new System.Drawing.Size(425, 187);
            this.uC_MobilisationEnginPompier1.TabIndex = 17;
            // 
            // uC_MobilisationEnginPompier2
            // 
            this.uC_MobilisationEnginPompier2.BackColor = System.Drawing.Color.DarkRed;
            this.uC_MobilisationEnginPompier2.Font = new System.Drawing.Font("Arial", 10F);
            this.uC_MobilisationEnginPompier2.Location = new System.Drawing.Point(503, 66);
            this.uC_MobilisationEnginPompier2.Margin = new System.Windows.Forms.Padding(4);
            this.uC_MobilisationEnginPompier2.Name = "uC_MobilisationEnginPompier2";
            this.uC_MobilisationEnginPompier2.Size = new System.Drawing.Size(425, 187);
            this.uC_MobilisationEnginPompier2.TabIndex = 18;
            // 
            // ucMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.grpMob);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.grpDecision);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNumMission);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "ucMission";
            this.Size = new System.Drawing.Size(986, 1019);
            this.grpDecision.ResumeLayout(false);
            this.grpDecision.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpMob.ResumeLayout(false);
            this.grpMob.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumMission;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpDecision;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.ComboBox cboNature;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblNatSin;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpMob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private UC_MobilisationEnginPompier uC_MobilisationEnginPompier2;
        private UC_MobilisationEnginPompier uC_MobilisationEnginPompier1;
    }
}
