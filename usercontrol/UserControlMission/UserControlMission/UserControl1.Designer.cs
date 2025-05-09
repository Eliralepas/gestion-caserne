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
            this.lblNumMission = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.grpAdr = new System.Windows.Forms.GroupBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblNatSin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpAdr.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotif);
            this.groupBox1.Location = new System.Drawing.Point(16, 144);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(483, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motif";
            // 
            // lblNumMission
            // 
            this.lblNumMission.AutoSize = true;
            this.lblNumMission.Location = new System.Drawing.Point(471, 11);
            this.lblNumMission.Name = "lblNumMission";
            this.lblNumMission.Size = new System.Drawing.Size(100, 23);
            this.lblNumMission.TabIndex = 1;
            this.lblNumMission.Text = "Mission n°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(942, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.cbo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblNatSin);
            this.groupBox2.Location = new System.Drawing.Point(16, 404);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1045, 116);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(22, 45);
            this.txtMotif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(431, 158);
            this.txtMotif.TabIndex = 4;
            // 
            // grpAdr
            // 
            this.grpAdr.Controls.Add(this.txtCP);
            this.grpAdr.Controls.Add(this.txtVille);
            this.grpAdr.Controls.Add(this.txtRue);
            this.grpAdr.Controls.Add(this.lblVille);
            this.grpAdr.Controls.Add(this.lblCP);
            this.grpAdr.Controls.Add(this.lblRue);
            this.grpAdr.Location = new System.Drawing.Point(529, 144);
            this.grpAdr.Name = "grpAdr";
            this.grpAdr.Size = new System.Drawing.Size(532, 230);
            this.grpAdr.TabIndex = 3;
            this.grpAdr.TabStop = false;
            this.grpAdr.Text = "Adresse sinistre";
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(94, 61);
            this.txtRue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(422, 30);
            this.txtRue.TabIndex = 14;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(26, 105);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(46, 23);
            this.lblVille.TabIndex = 13;
            this.lblVille.Text = "Ville";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(26, 147);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(116, 23);
            this.lblCP.TabIndex = 12;
            this.lblCP.Text = "Code postal";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(26, 64);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(45, 23);
            this.lblRue.TabIndex = 11;
            this.lblRue.Text = "Rue";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(423, 117);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(194, 23);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Informations usagers";
            // 
            // lblNatSin
            // 
            this.lblNatSin.AutoSize = true;
            this.lblNatSin.Location = new System.Drawing.Point(7, 58);
            this.lblNatSin.Name = "lblNatSin";
            this.lblNatSin.Size = new System.Drawing.Size(163, 23);
            this.lblNatSin.TabIndex = 15;
            this.lblNatSin.Text = "Nature du sinistre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(539, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "label8";
            // 
            // cbo
            // 
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(103, 55);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(380, 31);
            this.cbo.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(607, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(423, 31);
            this.comboBox2.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(900, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(94, 102);
            this.txtVille.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(216, 30);
            this.txtVille.TabIndex = 15;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(148, 144);
            this.txtCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(116, 30);
            this.txtCP.TabIndex = 16;
            // 
            // ucMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpAdr);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumMission);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucMission";
            this.Size = new System.Drawing.Size(1085, 608);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpAdr.ResumeLayout(false);
            this.grpAdr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumMission;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNatSin;
        private System.Windows.Forms.GroupBox grpAdr;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtVille;
    }
}
