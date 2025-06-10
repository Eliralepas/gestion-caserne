namespace UC_AjoutMissions
{
    partial class AjoutMissions
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
            txtMotif = new TextBox();
            lblNumMission = new Label();
            lblDate = new Label();
            grpDecision = new GroupBox();
            cboCaserne = new ComboBox();
            cboNature = new ComboBox();
            lblCaserne = new Label();
            lblNatSin = new Label();
            txtCP = new TextBox();
            txtVille = new TextBox();
            txtRue = new TextBox();
            lblVille = new Label();
            lblCP = new Label();
            lblRue = new Label();
            btnAnnuler = new Button();
            btnValider = new Button();
            grpInfo = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            grpMob = new GroupBox();
            pnlEngin = new Panel();
            pnlPompier = new Panel();
            label3 = new Label();
            label4 = new Label();
            btnNvMission = new Button();
            erp = new ErrorProvider(components);
            grpDecision.SuspendLayout();
            grpInfo.SuspendLayout();
            grpMob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erp).BeginInit();
            SuspendLayout();
            // 
            // txtMotif
            // 
            txtMotif.Location = new Point(20, 66);
            txtMotif.Margin = new Padding(2, 4, 2, 4);
            txtMotif.Multiline = true;
            txtMotif.Name = "txtMotif";
            txtMotif.Size = new Size(327, 182);
            txtMotif.TabIndex = 0;
            // 
            // lblNumMission
            // 
            lblNumMission.AutoSize = true;
            lblNumMission.BackColor = Color.FromArgb(100, 20, 0);
            lblNumMission.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblNumMission.ForeColor = Color.White;
            lblNumMission.Location = new Point(13, 10);
            lblNumMission.Margin = new Padding(2, 0, 2, 0);
            lblNumMission.Name = "lblNumMission";
            lblNumMission.Size = new Size(117, 26);
            lblNumMission.TabIndex = 1;
            lblNumMission.Text = "Mission n°";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(460, 6);
            lblDate.Margin = new Padding(2, 0, 2, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(125, 23);
            lblDate.TabIndex = 2;
            lblDate.Text = "Déclenchée le :";
            // 
            // grpDecision
            // 
            grpDecision.Controls.Add(cboCaserne);
            grpDecision.Controls.Add(cboNature);
            grpDecision.Controls.Add(lblCaserne);
            grpDecision.Controls.Add(lblNatSin);
            grpDecision.Font = new Font("Arial", 14F);
            grpDecision.ForeColor = Color.White;
            grpDecision.Location = new Point(621, 49);
            grpDecision.Margin = new Padding(2, 4, 2, 4);
            grpDecision.Name = "grpDecision";
            grpDecision.Padding = new Padding(2, 4, 2, 4);
            grpDecision.Size = new Size(288, 185);
            grpDecision.TabIndex = 1;
            grpDecision.TabStop = false;
            grpDecision.Text = "Décisions du régulateurs";
            // 
            // cboCaserne
            // 
            cboCaserne.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCaserne.FormattingEnabled = true;
            cboCaserne.Location = new Point(15, 141);
            cboCaserne.Margin = new Padding(2, 3, 2, 3);
            cboCaserne.Name = "cboCaserne";
            cboCaserne.Size = new Size(256, 30);
            cboCaserne.TabIndex = 5;
            // 
            // cboNature
            // 
            cboNature.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNature.FormattingEnabled = true;
            cboNature.Location = new Point(15, 66);
            cboNature.Margin = new Padding(2, 3, 2, 3);
            cboNature.Name = "cboNature";
            cboNature.Size = new Size(258, 30);
            cboNature.TabIndex = 4;
            // 
            // lblCaserne
            // 
            lblCaserne.AutoSize = true;
            lblCaserne.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblCaserne.Location = new Point(68, 115);
            lblCaserne.Margin = new Padding(2, 0, 2, 0);
            lblCaserne.Name = "lblCaserne";
            lblCaserne.Size = new Size(160, 23);
            lblCaserne.TabIndex = 16;
            lblCaserne.Text = "Caserne à mobiliser";
            // 
            // lblNatSin
            // 
            lblNatSin.AutoSize = true;
            lblNatSin.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNatSin.Location = new Point(68, 39);
            lblNatSin.Margin = new Padding(2, 0, 2, 0);
            lblNatSin.Name = "lblNatSin";
            lblNatSin.Size = new Size(144, 23);
            lblNatSin.TabIndex = 15;
            lblNatSin.Text = "Nature du sinistre";
            // 
            // txtCP
            // 
            txtCP.Location = new Point(370, 219);
            txtCP.Margin = new Padding(2, 4, 2, 4);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(116, 29);
            txtCP.TabIndex = 3;
            txtCP.KeyPress += txtCP_KeyPress;
            // 
            // txtVille
            // 
            txtVille.Location = new Point(370, 95);
            txtVille.Margin = new Padding(2, 4, 2, 4);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(203, 29);
            txtVille.TabIndex = 1;
            txtVille.KeyPress += txtVille_KeyPress;
            // 
            // txtRue
            // 
            txtRue.Location = new Point(370, 156);
            txtRue.Margin = new Padding(2, 4, 2, 4);
            txtRue.Name = "txtRue";
            txtRue.Size = new Size(203, 29);
            txtRue.TabIndex = 2;
            txtRue.KeyPress += txtVille_KeyPress;
            // 
            // lblVille
            // 
            lblVille.AutoSize = true;
            lblVille.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblVille.Location = new Point(370, 68);
            lblVille.Margin = new Padding(2, 0, 2, 0);
            lblVille.Name = "lblVille";
            lblVille.Size = new Size(41, 23);
            lblVille.TabIndex = 13;
            lblVille.Text = "Ville";
            // 
            // lblCP
            // 
            lblCP.AutoSize = true;
            lblCP.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblCP.Location = new Point(370, 192);
            lblCP.Margin = new Padding(2, 0, 2, 0);
            lblCP.Name = "lblCP";
            lblCP.Size = new Size(101, 23);
            lblCP.TabIndex = 12;
            lblCP.Text = "Code postal";
            // 
            // lblRue
            // 
            lblRue.AutoSize = true;
            lblRue.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblRue.Location = new Point(370, 129);
            lblRue.Margin = new Padding(2, 0, 2, 0);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(40, 23);
            lblRue.TabIndex = 11;
            lblRue.Text = "Rue";
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(658, 241);
            btnAnnuler.Margin = new Padding(2, 3, 2, 3);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(195, 36);
            btnAnnuler.TabIndex = 7;
            btnAnnuler.Text = "Effacer les données";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(658, 283);
            btnValider.Margin = new Padding(2, 3, 2, 3);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(195, 36);
            btnValider.TabIndex = 6;
            btnValider.Text = "Constituer équipe";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(label2);
            grpInfo.Controls.Add(txtCP);
            grpInfo.Controls.Add(label1);
            grpInfo.Controls.Add(txtVille);
            grpInfo.Controls.Add(txtMotif);
            grpInfo.Controls.Add(txtRue);
            grpInfo.Controls.Add(lblVille);
            grpInfo.Controls.Add(lblCP);
            grpInfo.Controls.Add(lblRue);
            grpInfo.Font = new Font("Arial", 14F);
            grpInfo.ForeColor = Color.White;
            grpInfo.Location = new Point(12, 49);
            grpInfo.Margin = new Padding(2, 3, 2, 3);
            grpInfo.Name = "grpInfo";
            grpInfo.Padding = new Padding(2, 3, 2, 3);
            grpInfo.Size = new Size(586, 270);
            grpInfo.TabIndex = 22;
            grpInfo.TabStop = false;
            grpInfo.Text = "Informations usager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label2.Location = new Point(395, 39);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 23);
            label2.TabIndex = 18;
            label2.Text = "Adresse du sinistre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label1.Location = new Point(18, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 23);
            label1.TabIndex = 17;
            label1.Text = "Motif";
            // 
            // grpMob
            // 
            grpMob.Controls.Add(pnlEngin);
            grpMob.Controls.Add(pnlPompier);
            grpMob.Controls.Add(label3);
            grpMob.Controls.Add(label4);
            grpMob.Font = new Font("Arial", 14F);
            grpMob.ForeColor = Color.White;
            grpMob.Location = new Point(12, 326);
            grpMob.Margin = new Padding(2, 4, 2, 4);
            grpMob.Name = "grpMob";
            grpMob.Padding = new Padding(2, 4, 2, 4);
            grpMob.Size = new Size(882, 240);
            grpMob.TabIndex = 19;
            grpMob.TabStop = false;
            grpMob.Text = "Mobilisation des engins et pompiers";
            grpMob.Visible = false;
            // 
            // pnlEngin
            // 
            pnlEngin.AutoScroll = true;
            pnlEngin.Location = new Point(22, 49);
            pnlEngin.Name = "pnlEngin";
            pnlEngin.Size = new Size(407, 180);
            pnlEngin.TabIndex = 19;
            // 
            // pnlPompier
            // 
            pnlPompier.AutoScroll = true;
            pnlPompier.Location = new Point(459, 49);
            pnlPompier.Name = "pnlPompier";
            pnlPompier.Size = new Size(404, 180);
            pnlPompier.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label3.Location = new Point(465, 23);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 23);
            label3.TabIndex = 16;
            label3.Text = "Pompiers mobilisés";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label4.Location = new Point(22, 23);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 23);
            label4.TabIndex = 15;
            label4.Text = "Engins mobilisés";
            // 
            // btnNvMission
            // 
            btnNvMission.Location = new Point(680, 573);
            btnNvMission.Margin = new Padding(2, 3, 2, 3);
            btnNvMission.Name = "btnNvMission";
            btnNvMission.Size = new Size(195, 36);
            btnNvMission.TabIndex = 8;
            btnNvMission.Text = "Nouvelle mission";
            btnNvMission.UseVisualStyleBackColor = true;
            btnNvMission.Visible = false;
            btnNvMission.Click += btnNvMission_Click;
            // 
            // erp
            // 
            erp.ContainerControl = this;
            // 
            // AjoutMissions
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 0, 0);
            Controls.Add(btnNvMission);
            Controls.Add(grpMob);
            Controls.Add(grpInfo);
            Controls.Add(btnValider);
            Controls.Add(btnAnnuler);
            Controls.Add(grpDecision);
            Controls.Add(lblDate);
            Controls.Add(lblNumMission);
            Font = new Font("Arial", 10F);
            Margin = new Padding(2, 4, 2, 4);
            Name = "AjoutMissions";
            Size = new Size(922, 644);
            grpDecision.ResumeLayout(false);
            grpDecision.PerformLayout();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            grpMob.ResumeLayout(false);
            grpMob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erp).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
