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
            this.flpMostUsedEngin = new System.Windows.Forms.FlowLayoutPanel();
            this.flpHistogram = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleMostUsedEngin = new System.Windows.Forms.Label();
            this.lblTitleEnginPerHour = new System.Windows.Forms.Label();
            this.cbxCaserne = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flpSinistreStat = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleIntervention = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbxHabilitation = new System.Windows.Forms.ComboBox();
            this.flpHabilitation = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHabilitation = new System.Windows.Forms.Panel();
            this.flpLegendHabi = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGrapheHabit = new System.Windows.Forms.Panel();
            this.lblTitleHabilitation = new System.Windows.Forms.Label();
            this.tabStatistique.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpEngins.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlHabilitation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStatistique
            // 
            this.tabStatistique.Controls.Add(this.tabPage1);
            this.tabStatistique.Controls.Add(this.tabPage2);
            this.tabStatistique.Controls.Add(this.tabPage3);
            this.tabStatistique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabStatistique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStatistique.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStatistique.Location = new System.Drawing.Point(0, 0);
            this.tabStatistique.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabStatistique.Name = "tabStatistique";
            this.tabStatistique.SelectedIndex = 0;
            this.tabStatistique.Size = new System.Drawing.Size(992, 647);
            this.tabStatistique.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabStatistique.TabIndex = 0;
            this.tabStatistique.SelectedIndexChanged += new System.EventHandler(this.tabStatistique_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpEngins);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(984, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Engins";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpEngins
            // 
            this.grpEngins.BackColor = System.Drawing.Color.White;
            this.grpEngins.Controls.Add(this.flpMostUsedEngin);
            this.grpEngins.Controls.Add(this.flpHistogram);
            this.grpEngins.Controls.Add(this.lblTitleMostUsedEngin);
            this.grpEngins.Controls.Add(this.lblTitleEnginPerHour);
            this.grpEngins.Controls.Add(this.cbxCaserne);
            this.grpEngins.Controls.Add(this.lblCaserne);
            this.grpEngins.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpEngins.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEngins.ForeColor = System.Drawing.Color.Black;
            this.grpEngins.Location = new System.Drawing.Point(3, 4);
            this.grpEngins.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEngins.Name = "grpEngins";
            this.grpEngins.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEngins.Size = new System.Drawing.Size(978, 602);
            this.grpEngins.TabIndex = 0;
            this.grpEngins.TabStop = false;
            this.grpEngins.Text = "Statistiques relatives aux engins";
            // 
            // flpMostUsedEngin
            // 
            this.flpMostUsedEngin.AutoScroll = true;
            this.flpMostUsedEngin.BackColor = System.Drawing.Color.DarkRed;
            this.flpMostUsedEngin.Location = new System.Drawing.Point(24, 362);
            this.flpMostUsedEngin.Name = "flpMostUsedEngin";
            this.flpMostUsedEngin.Size = new System.Drawing.Size(940, 236);
            this.flpMostUsedEngin.TabIndex = 0;
            this.flpMostUsedEngin.WrapContents = false;
            // 
            // flpHistogram
            // 
            this.flpHistogram.AutoScroll = true;
            this.flpHistogram.AutoScrollMargin = new System.Drawing.Size(100, 0);
            this.flpHistogram.BackColor = System.Drawing.Color.DarkRed;
            this.flpHistogram.Location = new System.Drawing.Point(21, 105);
            this.flpHistogram.Margin = new System.Windows.Forms.Padding(2);
            this.flpHistogram.Name = "flpHistogram";
            this.flpHistogram.Size = new System.Drawing.Size(943, 230);
            this.flpHistogram.TabIndex = 4;
            this.flpHistogram.WrapContents = false;
            // 
            // lblTitleMostUsedEngin
            // 
            this.lblTitleMostUsedEngin.AutoSize = true;
            this.lblTitleMostUsedEngin.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTitleMostUsedEngin.Location = new System.Drawing.Point(338, 337);
            this.lblTitleMostUsedEngin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleMostUsedEngin.Name = "lblTitleMostUsedEngin";
            this.lblTitleMostUsedEngin.Size = new System.Drawing.Size(330, 23);
            this.lblTitleMostUsedEngin.TabIndex = 3;
            this.lblTitleMostUsedEngin.Text = "Engins les plus utilisés de la caserne";
            // 
            // lblTitleEnginPerHour
            // 
            this.lblTitleEnginPerHour.AutoSize = true;
            this.lblTitleEnginPerHour.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTitleEnginPerHour.Location = new System.Drawing.Point(385, 79);
            this.lblTitleEnginPerHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleEnginPerHour.Name = "lblTitleEnginPerHour";
            this.lblTitleEnginPerHour.Size = new System.Drawing.Size(219, 23);
            this.lblTitleEnginPerHour.TabIndex = 2;
            this.lblTitleEnginPerHour.Text = "Total d\'heures par engin";
            // 
            // cbxCaserne
            // 
            this.cbxCaserne.Font = new System.Drawing.Font("Arial", 12F);
            this.cbxCaserne.FormattingEnabled = true;
            this.cbxCaserne.Location = new System.Drawing.Point(426, 38);
            this.cbxCaserne.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCaserne.Name = "cbxCaserne";
            this.cbxCaserne.Size = new System.Drawing.Size(199, 31);
            this.cbxCaserne.TabIndex = 1;
            this.cbxCaserne.SelectionChangeCommitted += new System.EventHandler(this.cbxCaserne_SelectedIndexChanged);
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(319, 41);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(107, 24);
            this.lblCaserne.TabIndex = 0;
            this.lblCaserne.Text = "Caserne : ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.flpSinistreStat);
            this.tabPage2.Controls.Add(this.lblTitleIntervention);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(984, 610);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Intervention";
            // 
            // flpSinistreStat
            // 
            this.flpSinistreStat.AutoScroll = true;
            this.flpSinistreStat.BackColor = System.Drawing.Color.DarkRed;
            this.flpSinistreStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpSinistreStat.Location = new System.Drawing.Point(3, 102);
            this.flpSinistreStat.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.flpSinistreStat.Name = "flpSinistreStat";
            this.flpSinistreStat.Size = new System.Drawing.Size(978, 504);
            this.flpSinistreStat.TabIndex = 1;
            // 
            // lblTitleIntervention
            // 
            this.lblTitleIntervention.AutoSize = true;
            this.lblTitleIntervention.ForeColor = System.Drawing.Color.Black;
            this.lblTitleIntervention.Location = new System.Drawing.Point(269, 16);
            this.lblTitleIntervention.Name = "lblTitleIntervention";
            this.lblTitleIntervention.Size = new System.Drawing.Size(427, 24);
            this.lblTitleIntervention.TabIndex = 0;
            this.lblTitleIntervention.Text = "Nombre d’interventions par type de sinistre ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.cbxHabilitation);
            this.tabPage3.Controls.Add(this.flpHabilitation);
            this.tabPage3.Controls.Add(this.pnlHabilitation);
            this.tabPage3.Controls.Add(this.lblTitleHabilitation);
            this.tabPage3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(984, 610);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Habilitation";
            // 
            // cbxHabilitation
            // 
            this.cbxHabilitation.Font = new System.Drawing.Font("Arial", 12F);
            this.cbxHabilitation.FormattingEnabled = true;
            this.cbxHabilitation.Location = new System.Drawing.Point(448, 64);
            this.cbxHabilitation.Name = "cbxHabilitation";
            this.cbxHabilitation.Size = new System.Drawing.Size(530, 31);
            this.cbxHabilitation.TabIndex = 0;
            this.cbxHabilitation.SelectionChangeCommitted += new System.EventHandler(this.cbxHabilitation_SelectedIndexChanged);
            // 
            // flpHabilitation
            // 
            this.flpHabilitation.AutoScroll = true;
            this.flpHabilitation.BackColor = System.Drawing.Color.LightGray;
            this.flpHabilitation.Font = new System.Drawing.Font("Arial", 12F);
            this.flpHabilitation.ForeColor = System.Drawing.Color.Black;
            this.flpHabilitation.Location = new System.Drawing.Point(448, 100);
            this.flpHabilitation.Name = "flpHabilitation";
            this.flpHabilitation.Size = new System.Drawing.Size(530, 454);
            this.flpHabilitation.TabIndex = 2;
            // 
            // pnlHabilitation
            // 
            this.pnlHabilitation.Controls.Add(this.flpLegendHabi);
            this.pnlHabilitation.Controls.Add(this.pnlGrapheHabit);
            this.pnlHabilitation.Location = new System.Drawing.Point(15, 64);
            this.pnlHabilitation.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHabilitation.Name = "pnlHabilitation";
            this.pnlHabilitation.Size = new System.Drawing.Size(427, 490);
            this.pnlHabilitation.TabIndex = 7;
            // 
            // flpLegendHabi
            // 
            this.flpLegendHabi.AutoScroll = true;
            this.flpLegendHabi.BackColor = System.Drawing.Color.DarkRed;
            this.flpLegendHabi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpLegendHabi.Location = new System.Drawing.Point(0, 379);
            this.flpLegendHabi.Name = "flpLegendHabi";
            this.flpLegendHabi.Size = new System.Drawing.Size(427, 111);
            this.flpLegendHabi.TabIndex = 1;
            this.flpLegendHabi.WrapContents = false;
            // 
            // pnlGrapheHabit
            // 
            this.pnlGrapheHabit.BackColor = System.Drawing.Color.DarkRed;
            this.pnlGrapheHabit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGrapheHabit.Location = new System.Drawing.Point(0, 0);
            this.pnlGrapheHabit.Name = "pnlGrapheHabit";
            this.pnlGrapheHabit.Size = new System.Drawing.Size(427, 367);
            this.pnlGrapheHabit.TabIndex = 0;
            // 
            // lblTitleHabilitation
            // 
            this.lblTitleHabilitation.AutoSize = true;
            this.lblTitleHabilitation.Location = new System.Drawing.Point(325, 18);
            this.lblTitleHabilitation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleHabilitation.Name = "lblTitleHabilitation";
            this.lblTitleHabilitation.Size = new System.Drawing.Size(301, 24);
            this.lblTitleHabilitation.TabIndex = 6;
            this.lblTitleHabilitation.Text = "Habilitations les plus solicitées";
            // 
            // UCStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.tabStatistique);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCStatistique";
            this.Size = new System.Drawing.Size(992, 647);
            this.tabStatistique.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpEngins.ResumeLayout(false);
            this.grpEngins.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnlHabilitation.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblTitleMostUsedEngin;
        private System.Windows.Forms.Label lblTitleEnginPerHour;
        private System.Windows.Forms.Label lblTitleIntervention;
        private System.Windows.Forms.FlowLayoutPanel flpSinistreStat;
        private System.Windows.Forms.Panel pnlHabilitation;
        private System.Windows.Forms.FlowLayoutPanel flpLegendHabi;
        private System.Windows.Forms.Panel pnlGrapheHabit;
        private System.Windows.Forms.Label lblTitleHabilitation;
        private System.Windows.Forms.FlowLayoutPanel flpHabilitation;
        private System.Windows.Forms.ComboBox cbxHabilitation;
        private System.Windows.Forms.FlowLayoutPanel flpMostUsedEngin;
    }
}
