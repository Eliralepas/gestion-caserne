namespace UC_Statistique
{
    partial class UCStatistique
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
            this.tabStatistique = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpEngins = new System.Windows.Forms.GroupBox();
            this.pnlMostUsedEngin = new System.Windows.Forms.Panel();
            this.flpHistogram = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCaserne = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlCamembert = new System.Windows.Forms.Panel();
            this.flpLegende = new System.Windows.Forms.FlowLayoutPanel();
            this.tabStatistique.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpEngins.SuspendLayout();
            this.pnlMostUsedEngin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStatistique
            // 
            this.tabStatistique.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabStatistique.Controls.Add(this.tabPage1);
            this.tabStatistique.Controls.Add(this.tabPage2);
            this.tabStatistique.Controls.Add(this.tabPage3);
            this.tabStatistique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabStatistique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStatistique.Location = new System.Drawing.Point(0, 0);
            this.tabStatistique.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabStatistique.Name = "tabStatistique";
            this.tabStatistique.SelectedIndex = 0;
            this.tabStatistique.Size = new System.Drawing.Size(889, 592);
            this.tabStatistique.TabIndex = 0;
            this.tabStatistique.SelectedIndexChanged += new System.EventHandler(this.tabStatistique_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpEngins);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(881, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Engins";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpEngins
            // 
            this.grpEngins.Controls.Add(this.pnlMostUsedEngin);
            this.grpEngins.Controls.Add(this.flpHistogram);
            this.grpEngins.Controls.Add(this.label2);
            this.grpEngins.Controls.Add(this.label1);
            this.grpEngins.Controls.Add(this.cbxCaserne);
            this.grpEngins.Controls.Add(this.lblCaserne);
            this.grpEngins.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpEngins.Location = new System.Drawing.Point(3, 4);
            this.grpEngins.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEngins.Name = "grpEngins";
            this.grpEngins.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEngins.Size = new System.Drawing.Size(854, 546);
            this.grpEngins.TabIndex = 0;
            this.grpEngins.TabStop = false;
            this.grpEngins.Text = "Statistique reltives au Engins";
            // 
            // pnlMostUsedEngin
            // 
            this.pnlMostUsedEngin.Controls.Add(this.flpLegende);
            this.pnlMostUsedEngin.Controls.Add(this.pnlCamembert);
            this.pnlMostUsedEngin.Location = new System.Drawing.Point(24, 120);
            this.pnlMostUsedEngin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMostUsedEngin.Name = "pnlMostUsedEngin";
            this.pnlMostUsedEngin.Size = new System.Drawing.Size(384, 370);
            this.pnlMostUsedEngin.TabIndex = 5;
            // 
            // flpHistogram
            // 
            this.flpHistogram.AutoScroll = true;
            this.flpHistogram.Location = new System.Drawing.Point(470, 130);
            this.flpHistogram.Margin = new System.Windows.Forms.Padding(2);
            this.flpHistogram.Name = "flpHistogram";
            this.flpHistogram.Size = new System.Drawing.Size(357, 360);
            this.flpHistogram.TabIndex = 4;
            this.flpHistogram.WrapContents = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // cbxCaserne
            // 
            this.cbxCaserne.FormattingEnabled = true;
            this.cbxCaserne.Location = new System.Drawing.Point(209, 23);
            this.cbxCaserne.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCaserne.Name = "cbxCaserne";
            this.cbxCaserne.Size = new System.Drawing.Size(199, 30);
            this.cbxCaserne.TabIndex = 1;
            this.cbxCaserne.SelectedIndexChanged += new System.EventHandler(this.cbxCaserne_SelectedIndexChanged);
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(145, 25);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(77, 22);
            this.lblCaserne.TabIndex = 0;
            this.lblCaserne.Text = "Caserne : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(881, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Intervention";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(881, 554);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Habilitation";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlCamembert
            // 
            this.pnlCamembert.Location = new System.Drawing.Point(17, 16);
            this.pnlCamembert.Name = "pnlCamembert";
            this.pnlCamembert.Size = new System.Drawing.Size(351, 277);
            this.pnlCamembert.TabIndex = 0;
            // 
            // flpLegende
            // 
            this.flpLegende.Location = new System.Drawing.Point(17, 299);
            this.flpLegende.Name = "flpLegende";
            this.flpLegende.Size = new System.Drawing.Size(351, 61);
            this.flpLegende.TabIndex = 1;
            // 
            // UCStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tabStatistique);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCStatistique";
            this.Size = new System.Drawing.Size(889, 592);
            this.tabStatistique.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpEngins.ResumeLayout(false);
            this.grpEngins.PerformLayout();
            this.pnlMostUsedEngin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStatistique;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox grpEngins;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.ComboBox cbxCaserne;
        private System.Windows.Forms.FlowLayoutPanel flpHistogram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMostUsedEngin;
        private System.Windows.Forms.Panel pnlCamembert;
        private System.Windows.Forms.FlowLayoutPanel flpLegende;
    }
}
