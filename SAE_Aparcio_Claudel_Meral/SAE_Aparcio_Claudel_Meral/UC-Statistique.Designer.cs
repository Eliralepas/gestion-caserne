namespace UC_Statistique
{
    partial class Statistique
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
            tabStatistique = new TabControl();
            tabPage1 = new TabPage();
            grpEngins = new GroupBox();
            flpMostUsedEngin = new FlowLayoutPanel();
            flpHistogram = new FlowLayoutPanel();
            lblTitleMostUsedEngin = new Label();
            lblTitleEnginPerHour = new Label();
            cbxCaserne = new ComboBox();
            lblCaserne = new Label();
            tabPage2 = new TabPage();
            flpSinistreStat = new FlowLayoutPanel();
            lblTitleIntervention = new Label();
            tabPage3 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            cbxHabilitation = new ComboBox();
            flpHabilitation = new FlowLayoutPanel();
            pnlHabilitation = new Panel();
            flpLegendHabi = new FlowLayoutPanel();
            pnlGrapheHabit = new Panel();
            lblTitleHabilitation = new Label();
            tabStatistique.SuspendLayout();
            tabPage1.SuspendLayout();
            grpEngins.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            pnlHabilitation.SuspendLayout();
            SuspendLayout();
            // 
            // tabStatistique
            // 
            tabStatistique.Controls.Add(tabPage1);
            tabStatistique.Controls.Add(tabPage2);
            tabStatistique.Controls.Add(tabPage3);
            tabStatistique.Cursor = Cursors.Hand;
            tabStatistique.Dock = DockStyle.Fill;
            tabStatistique.Font = new Font("Arial", 12F);
            tabStatistique.Location = new Point(0, 0);
            tabStatistique.Margin = new Padding(3, 4, 3, 4);
            tabStatistique.Name = "tabStatistique";
            tabStatistique.SelectedIndex = 0;
            tabStatistique.Size = new Size(995, 647);
            tabStatistique.SizeMode = TabSizeMode.Fixed;
            tabStatistique.TabIndex = 0;
            tabStatistique.SelectedIndexChanged += tabStatistique_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(grpEngins);
            tabPage1.Font = new Font("Arial", 12F, FontStyle.Bold);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(987, 616);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Engins";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpEngins
            // 
            grpEngins.BackColor = Color.White;
            grpEngins.Controls.Add(flpMostUsedEngin);
            grpEngins.Controls.Add(flpHistogram);
            grpEngins.Controls.Add(lblTitleMostUsedEngin);
            grpEngins.Controls.Add(lblTitleEnginPerHour);
            grpEngins.Controls.Add(cbxCaserne);
            grpEngins.Controls.Add(lblCaserne);
            grpEngins.Dock = DockStyle.Left;
            grpEngins.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpEngins.ForeColor = Color.Black;
            grpEngins.Location = new Point(3, 4);
            grpEngins.Margin = new Padding(3, 4, 3, 4);
            grpEngins.Name = "grpEngins";
            grpEngins.Padding = new Padding(3, 4, 3, 4);
            grpEngins.Size = new Size(982, 608);
            grpEngins.TabIndex = 0;
            grpEngins.TabStop = false;
            grpEngins.Text = "Statistiques relatives aux engins";
            // 
            // flpMostUsedEngin
            // 
            flpMostUsedEngin.AutoScroll = true;
            flpMostUsedEngin.BackColor = Color.FromArgb(192, 0, 0);
            flpMostUsedEngin.Location = new Point(24, 362);
            flpMostUsedEngin.Name = "flpMostUsedEngin";
            flpMostUsedEngin.Size = new Size(944, 236);
            flpMostUsedEngin.TabIndex = 0;
            flpMostUsedEngin.WrapContents = false;
            // 
            // flpHistogram
            // 
            flpHistogram.AutoScroll = true;
            flpHistogram.AutoScrollMargin = new Size(100, 0);
            flpHistogram.BackColor = Color.FromArgb(192, 0, 0);
            flpHistogram.Location = new Point(21, 114);
            flpHistogram.Margin = new Padding(2);
            flpHistogram.Name = "flpHistogram";
            flpHistogram.Size = new Size(947, 221);
            flpHistogram.TabIndex = 4;
            flpHistogram.WrapContents = false;
            // 
            // lblTitleMostUsedEngin
            // 
            lblTitleMostUsedEngin.AutoSize = true;
            lblTitleMostUsedEngin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleMostUsedEngin.Location = new Point(366, 340);
            lblTitleMostUsedEngin.Margin = new Padding(2, 0, 2, 0);
            lblTitleMostUsedEngin.Name = "lblTitleMostUsedEngin";
            lblTitleMostUsedEngin.Size = new Size(289, 19);
            lblTitleMostUsedEngin.TabIndex = 3;
            lblTitleMostUsedEngin.Text = "Engins les plus utilisés de la caserne";
            // 
            // lblTitleEnginPerHour
            // 
            lblTitleEnginPerHour.AutoSize = true;
            lblTitleEnginPerHour.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleEnginPerHour.Location = new Point(402, 93);
            lblTitleEnginPerHour.Margin = new Padding(2, 0, 2, 0);
            lblTitleEnginPerHour.Name = "lblTitleEnginPerHour";
            lblTitleEnginPerHour.Size = new Size(193, 19);
            lblTitleEnginPerHour.TabIndex = 2;
            lblTitleEnginPerHour.Text = "Total d'heures par engin";
            // 
            // cbxCaserne
            // 
            cbxCaserne.Font = new Font("Arial", 12F);
            cbxCaserne.FormattingEnabled = true;
            cbxCaserne.Location = new Point(428, 51);
            cbxCaserne.Margin = new Padding(2);
            cbxCaserne.Name = "cbxCaserne";
            cbxCaserne.Size = new Size(199, 26);
            cbxCaserne.TabIndex = 1;
            cbxCaserne.SelectionChangeCommitted += cbxCaserne_SelectedIndexChanged;
            // 
            // lblCaserne
            // 
            lblCaserne.AutoSize = true;
            lblCaserne.Font = new Font("Arial", 12F);
            lblCaserne.Location = new Point(343, 54);
            lblCaserne.Name = "lblCaserne";
            lblCaserne.Size = new Size(80, 18);
            lblCaserne.TabIndex = 0;
            lblCaserne.Text = "Caserne : ";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(flpSinistreStat);
            tabPage2.Controls.Add(lblTitleIntervention);
            tabPage2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage2.ForeColor = Color.Black;
            tabPage2.Location = new Point(4, 27);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(987, 616);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Intervention";
            // 
            // flpSinistreStat
            // 
            flpSinistreStat.AutoScroll = true;
            flpSinistreStat.BackColor = Color.FromArgb(192, 0, 0);
            flpSinistreStat.Location = new Point(8, 108);
            flpSinistreStat.Margin = new Padding(5, 3, 3, 3);
            flpSinistreStat.Name = "flpSinistreStat";
            flpSinistreStat.Size = new Size(973, 504);
            flpSinistreStat.TabIndex = 1;
            // 
            // lblTitleIntervention
            // 
            lblTitleIntervention.AutoSize = true;
            lblTitleIntervention.ForeColor = Color.Black;
            lblTitleIntervention.Location = new Point(343, 36);
            lblTitleIntervention.Name = "lblTitleIntervention";
            lblTitleIntervention.Size = new Size(341, 19);
            lblTitleIntervention.TabIndex = 0;
            lblTitleIntervention.Text = "Nombre d’interventions par type de sinistre ";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(cbxHabilitation);
            tabPage3.Controls.Add(flpHabilitation);
            tabPage3.Controls.Add(pnlHabilitation);
            tabPage3.Controls.Add(lblTitleHabilitation);
            tabPage3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage3.ForeColor = Color.Black;
            tabPage3.Location = new Point(4, 27);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(987, 616);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Habilitation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(634, 88);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 19);
            label2.TabIndex = 9;
            label2.Text = "Pompier par Habilitations";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 88);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 19);
            label1.TabIndex = 8;
            label1.Text = "Classement Habilitations ";
            // 
            // cbxHabilitation
            // 
            cbxHabilitation.Font = new Font("Arial", 12F);
            cbxHabilitation.FormattingEnabled = true;
            cbxHabilitation.Location = new Point(487, 110);
            cbxHabilitation.Name = "cbxHabilitation";
            cbxHabilitation.Size = new Size(494, 26);
            cbxHabilitation.TabIndex = 0;
            cbxHabilitation.SelectionChangeCommitted += cbxHabilitation_SelectedIndexChanged;
            // 
            // flpHabilitation
            // 
            flpHabilitation.AutoScroll = true;
            flpHabilitation.BackColor = Color.LightGray;
            flpHabilitation.Font = new Font("Arial", 12F);
            flpHabilitation.ForeColor = Color.Black;
            flpHabilitation.Location = new Point(487, 146);
            flpHabilitation.Name = "flpHabilitation";
            flpHabilitation.Size = new Size(494, 454);
            flpHabilitation.TabIndex = 2;
            // 
            // pnlHabilitation
            // 
            pnlHabilitation.Controls.Add(flpLegendHabi);
            pnlHabilitation.Controls.Add(pnlGrapheHabit);
            pnlHabilitation.Location = new Point(5, 110);
            pnlHabilitation.Margin = new Padding(2);
            pnlHabilitation.Name = "pnlHabilitation";
            pnlHabilitation.Size = new Size(427, 490);
            pnlHabilitation.TabIndex = 7;
            // 
            // flpLegendHabi
            // 
            flpLegendHabi.AutoScroll = true;
            flpLegendHabi.BackColor = Color.FromArgb(192, 0, 0);
            flpLegendHabi.Dock = DockStyle.Bottom;
            flpLegendHabi.Location = new Point(0, 396);
            flpLegendHabi.Name = "flpLegendHabi";
            flpLegendHabi.Size = new Size(427, 94);
            flpLegendHabi.TabIndex = 1;
            flpLegendHabi.WrapContents = false;
            // 
            // pnlGrapheHabit
            // 
            pnlGrapheHabit.BackColor = Color.FromArgb(192, 0, 0);
            pnlGrapheHabit.Dock = DockStyle.Top;
            pnlGrapheHabit.Location = new Point(0, 0);
            pnlGrapheHabit.Name = "pnlGrapheHabit";
            pnlGrapheHabit.Size = new Size(427, 390);
            pnlGrapheHabit.TabIndex = 0;
            // 
            // lblTitleHabilitation
            // 
            lblTitleHabilitation.AutoSize = true;
            lblTitleHabilitation.Location = new Point(386, 29);
            lblTitleHabilitation.Margin = new Padding(2, 0, 2, 0);
            lblTitleHabilitation.Name = "lblTitleHabilitation";
            lblTitleHabilitation.Size = new Size(243, 19);
            lblTitleHabilitation.TabIndex = 6;
            lblTitleHabilitation.Text = "Habilitations les plus solicitées";
            // 
            // Statistique
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            Controls.Add(tabStatistique);
            Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Statistique";
            Size = new Size(995, 647);
            tabStatistique.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            grpEngins.ResumeLayout(false);
            grpEngins.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            pnlHabilitation.ResumeLayout(false);
            ResumeLayout(false);
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
        private Label label2;
        private Label label1;
    }
}
