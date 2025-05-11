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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.ucMobil = new UserControlMission.UC_MobilisationEnginPompier();
            this.groupBox1.SuspendLayout();
            this.grpDecision.SuspendLayout();
            this.grpAdr.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotif);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(22, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Size = new System.Drawing.Size(424, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motif";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(22, 45);
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
            this.grpDecision.Location = new System.Drawing.Point(16, 405);
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
            this.lblCaserne.Location = new System.Drawing.Point(482, 39);
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
            // grpAdr
            // 
            this.grpAdr.Controls.Add(this.txtCP);
            this.grpAdr.Controls.Add(this.txtVille);
            this.grpAdr.Controls.Add(this.txtRue);
            this.grpAdr.Controls.Add(this.lblVille);
            this.grpAdr.Controls.Add(this.lblCP);
            this.grpAdr.Controls.Add(this.lblRue);
            this.grpAdr.Font = new System.Drawing.Font("Arial", 11F);
            this.grpAdr.ForeColor = System.Drawing.Color.White;
            this.grpAdr.Location = new System.Drawing.Point(465, 37);
            this.grpAdr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpAdr.Name = "grpAdr";
            this.grpAdr.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpAdr.Size = new System.Drawing.Size(454, 230);
            this.grpAdr.TabIndex = 3;
            this.grpAdr.TabStop = false;
            this.grpAdr.Text = "Adresse sinistre";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(21, 142);
            this.txtCP.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(116, 33);
            this.txtCP.TabIndex = 16;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(205, 142);
            this.txtVille.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(215, 33);
            this.txtVille.TabIndex = 15;
            this.txtVille.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVille_KeyPress);
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(21, 72);
            this.txtRue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(399, 33);
            this.txtRue.TabIndex = 14;
            this.txtRue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVille_KeyPress);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Arial", 10F);
            this.lblVille.Location = new System.Drawing.Point(201, 115);
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
            this.lblCP.Location = new System.Drawing.Point(17, 115);
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
            this.lblRue.Location = new System.Drawing.Point(17, 45);
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
            this.btnAnnuler.Location = new System.Drawing.Point(615, 543);
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
            this.btnValider.Location = new System.Drawing.Point(805, 543);
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
            this.grpInfo.Controls.Add(this.groupBox1);
            this.grpInfo.Controls.Add(this.grpAdr);
            this.grpInfo.Font = new System.Drawing.Font("Arial", 12F);
            this.grpInfo.ForeColor = System.Drawing.Color.White;
            this.grpInfo.Location = new System.Drawing.Point(16, 78);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpInfo.Size = new System.Drawing.Size(956, 295);
            this.grpInfo.TabIndex = 22;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informations usager";
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.Location = new System.Drawing.Point(805, 959);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(149, 36);
            this.btnFermer.TabIndex = 21;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // ucMobil
            // 
            this.ucMobil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucMobil.BackColor = System.Drawing.Color.DarkRed;
            this.ucMobil.Font = new System.Drawing.Font("Arial", 10F);
            this.ucMobil.Location = new System.Drawing.Point(16, 598);
            this.ucMobil.Margin = new System.Windows.Forms.Padding(4);
            this.ucMobil.Name = "ucMobil";
            this.ucMobil.Size = new System.Drawing.Size(956, 300);
            this.ucMobil.TabIndex = 23;
            this.ucMobil.Visible = false;
            // 
            // ucMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.ucMobil);
            this.Controls.Add(this.btnFermer);
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
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Button btnFermer;
        private UC_MobilisationEnginPompier ucMobil;
    }
}
