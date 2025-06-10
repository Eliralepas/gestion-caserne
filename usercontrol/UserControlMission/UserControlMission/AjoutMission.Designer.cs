namespace UC_AjoutMission
{
    partial class AjoutMission
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMob = new System.Windows.Forms.GroupBox();
            this.pnlEngin = new System.Windows.Forms.Panel();
            this.pnlPompier = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNvMission = new System.Windows.Forms.Button();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpDecision.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.grpMob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(24, 92);
            this.txtMotif.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(464, 114);
            this.txtMotif.TabIndex = 4;
            // 
            // lblNumMission
            // 
            this.lblNumMission.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumMission.AutoSize = true;
            this.lblNumMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.lblNumMission.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblNumMission.ForeColor = System.Drawing.Color.White;
            this.lblNumMission.Location = new System.Drawing.Point(20, 30);
            this.lblNumMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumMission.Name = "lblNumMission";
            this.lblNumMission.Size = new System.Drawing.Size(151, 32);
            this.lblNumMission.TabIndex = 1;
            this.lblNumMission.Text = "Mission n°";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(737, 38);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(145, 23);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Déclenchée le :";
            // 
            // grpDecision
            // 
            this.grpDecision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDecision.Controls.Add(this.cboCaserne);
            this.grpDecision.Controls.Add(this.cboNature);
            this.grpDecision.Controls.Add(this.lblCaserne);
            this.grpDecision.Controls.Add(this.lblNatSin);
            this.grpDecision.Font = new System.Drawing.Font("Arial", 14F);
            this.grpDecision.ForeColor = System.Drawing.Color.White;
            this.grpDecision.Location = new System.Drawing.Point(572, 93);
            this.grpDecision.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grpDecision.Name = "grpDecision";
            this.grpDecision.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grpDecision.Size = new System.Drawing.Size(532, 271);
            this.grpDecision.TabIndex = 1;
            this.grpDecision.TabStop = false;
            this.grpDecision.Text = "Décisions du régulateurs";
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(27, 171);
            this.cboCaserne.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(481, 34);
            this.cboCaserne.TabIndex = 18;
            // 
            // cboNature
            // 
            this.cboNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNature.FormattingEnabled = true;
            this.cboNature.Location = new System.Drawing.Point(27, 79);
            this.cboNature.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cboNature.Name = "cboNature";
            this.cboNature.Size = new System.Drawing.Size(481, 34);
            this.cboNature.TabIndex = 17;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCaserne.Location = new System.Drawing.Point(22, 139);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(185, 23);
            this.lblCaserne.TabIndex = 16;
            this.lblCaserne.Text = "Caserne à mobiliser";
            // 
            // lblNatSin
            // 
            this.lblNatSin.AutoSize = true;
            this.lblNatSin.Font = new System.Drawing.Font("Arial", 12F);
            this.lblNatSin.Location = new System.Drawing.Point(22, 47);
            this.lblNatSin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNatSin.Name = "lblNatSin";
            this.lblNatSin.Size = new System.Drawing.Size(163, 23);
            this.lblNatSin.TabIndex = 15;
            this.lblNatSin.Text = "Nature du sinistre";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(24, 401);
            this.txtCP.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(141, 34);
            this.txtCP.TabIndex = 16;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(226, 401);
            this.txtVille.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(262, 34);
            this.txtVille.TabIndex = 15;
            this.txtVille.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVille_KeyPress);
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(24, 316);
            this.txtRue.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(464, 34);
            this.txtRue.TabIndex = 14;
            this.txtRue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVille_KeyPress);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Arial", 12F);
            this.lblVille.Location = new System.Drawing.Point(221, 368);
            this.lblVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(46, 23);
            this.lblVille.TabIndex = 13;
            this.lblVille.Text = "Ville";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCP.Location = new System.Drawing.Point(24, 368);
            this.lblCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(116, 23);
            this.lblCP.TabIndex = 12;
            this.lblCP.Text = "Code postal";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblRue.Location = new System.Drawing.Point(22, 283);
            this.lblRue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(45, 23);
            this.lblRue.TabIndex = 11;
            this.lblRue.Text = "Rue";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnnuler.Font = new System.Drawing.Font("Arial", 14F);
            this.btnAnnuler.Location = new System.Drawing.Point(589, 522);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(238, 44);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Effacer les données";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnValider.Font = new System.Drawing.Font("Arial", 14F);
            this.btnValider.Location = new System.Drawing.Point(865, 522);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(238, 44);
            this.btnValider.TabIndex = 20;
            this.btnValider.Text = "Constituer équipe";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.txtCP);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.txtVille);
            this.grpInfo.Controls.Add(this.txtMotif);
            this.grpInfo.Controls.Add(this.txtRue);
            this.grpInfo.Controls.Add(this.lblVille);
            this.grpInfo.Controls.Add(this.lblCP);
            this.grpInfo.Controls.Add(this.lblRue);
            this.grpInfo.Font = new System.Drawing.Font("Arial", 14F);
            this.grpInfo.ForeColor = System.Drawing.Color.White;
            this.grpInfo.Location = new System.Drawing.Point(26, 93);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpInfo.Size = new System.Drawing.Size(524, 472);
            this.grpInfo.TabIndex = 22;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informations usager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.5F);
            this.label2.Location = new System.Drawing.Point(131, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Adresse du sinistre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(20, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Motif";
            // 
            // grpMob
            // 
            this.grpMob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpMob.Controls.Add(this.pnlEngin);
            this.grpMob.Controls.Add(this.pnlPompier);
            this.grpMob.Controls.Add(this.label3);
            this.grpMob.Controls.Add(this.label4);
            this.grpMob.Font = new System.Drawing.Font("Arial", 14F);
            this.grpMob.ForeColor = System.Drawing.Color.White;
            this.grpMob.Location = new System.Drawing.Point(26, 606);
            this.grpMob.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grpMob.Name = "grpMob";
            this.grpMob.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grpMob.Size = new System.Drawing.Size(1078, 387);
            this.grpMob.TabIndex = 19;
            this.grpMob.TabStop = false;
            this.grpMob.Text = "Mobilisation des engins et pompiers";
            this.grpMob.Visible = false;
            // 
            // pnlEngin
            // 
            this.pnlEngin.AutoScroll = true;
            this.pnlEngin.Location = new System.Drawing.Point(27, 107);
            this.pnlEngin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEngin.Name = "pnlEngin";
            this.pnlEngin.Size = new System.Drawing.Size(497, 261);
            this.pnlEngin.TabIndex = 19;
            // 
            // pnlPompier
            // 
            this.pnlPompier.AutoScroll = true;
            this.pnlPompier.Location = new System.Drawing.Point(561, 107);
            this.pnlPompier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPompier.Name = "pnlPompier";
            this.pnlPompier.Size = new System.Drawing.Size(494, 261);
            this.pnlPompier.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(568, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pompiers mobilisés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(35, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Engins mobilisés";
            // 
            // btnNvMission
            // 
            this.btnNvMission.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNvMission.Font = new System.Drawing.Font("Arial", 14F);
            this.btnNvMission.Location = new System.Drawing.Point(865, 1002);
            this.btnNvMission.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnNvMission.Name = "btnNvMission";
            this.btnNvMission.Size = new System.Drawing.Size(238, 44);
            this.btnNvMission.TabIndex = 23;
            this.btnNvMission.Text = "Nouvelle mission";
            this.btnNvMission.UseVisualStyleBackColor = true;
            this.btnNvMission.Visible = false;
            this.btnNvMission.Click += new System.EventHandler(this.btnNvMission_Click);
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // ucMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.btnNvMission);
            this.Controls.Add(this.grpMob);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.grpDecision);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNumMission);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "ucMission";
            this.Size = new System.Drawing.Size(1135, 1083);
            this.grpDecision.ResumeLayout(false);
            this.grpDecision.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpMob.ResumeLayout(false);
            this.grpMob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
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
        private System.Windows.Forms.Panel pnlPompier;
        private System.Windows.Forms.Panel pnlEngin;
        private System.Windows.Forms.Button btnNvMission;
        private System.Windows.Forms.ErrorProvider erp;
    }
}
