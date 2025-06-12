namespace UC_GestionEngins
{
    partial class GestionEngins
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
            lblTitleCaserne = new Label();
            cbxChoixCaserne = new ComboBox();
            pnlGestionEngin = new Panel();
            pnlButton = new Panel();
            btnPrevious = new Button();
            btnFirst = new Button();
            btnLast = new Button();
            btnNext = new Button();
            pnlDisplayEngin = new Panel();
            pnlCaserneChoice = new Panel();
            pnlGestionEngin.SuspendLayout();
            pnlButton.SuspendLayout();
            pnlCaserneChoice.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleCaserne
            // 
            lblTitleCaserne.AutoSize = true;
            lblTitleCaserne.Font = new Font("Arial", 13.8F);
            lblTitleCaserne.Location = new Point(55, 29);
            lblTitleCaserne.Margin = new Padding(2, 0, 2, 0);
            lblTitleCaserne.Name = "lblTitleCaserne";
            lblTitleCaserne.Size = new Size(193, 22);
            lblTitleCaserne.TabIndex = 0;
            lblTitleCaserne.Text = "Choix de la carserne :";
            // 
            // cbxChoixCaserne
            // 
            cbxChoixCaserne.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxChoixCaserne.FormattingEnabled = true;
            cbxChoixCaserne.Location = new Point(393, 28);
            cbxChoixCaserne.Margin = new Padding(2, 2, 2, 2);
            cbxChoixCaserne.Name = "cbxChoixCaserne";
            cbxChoixCaserne.Size = new Size(199, 23);
            cbxChoixCaserne.TabIndex = 1;
            cbxChoixCaserne.SelectionChangeCommitted += cbxChoixCaserne_SelectionChangeCommitted;
            // 
            // pnlGestionEngin
            // 
            pnlGestionEngin.BackColor = Color.Red;
            pnlGestionEngin.Controls.Add(pnlButton);
            pnlGestionEngin.Controls.Add(pnlDisplayEngin);
            pnlGestionEngin.Controls.Add(pnlCaserneChoice);
            pnlGestionEngin.Dock = DockStyle.Fill;
            pnlGestionEngin.Location = new Point(0, 0);
            pnlGestionEngin.Margin = new Padding(2, 2, 2, 2);
            pnlGestionEngin.Name = "pnlGestionEngin";
            pnlGestionEngin.Size = new Size(1003, 647);
            pnlGestionEngin.TabIndex = 2;
            // 
            // pnlButton
            // 
            pnlButton.BackColor = Color.Silver;
            pnlButton.Controls.Add(btnPrevious);
            pnlButton.Controls.Add(btnFirst);
            pnlButton.Controls.Add(btnLast);
            pnlButton.Controls.Add(btnNext);
            pnlButton.Dock = DockStyle.Bottom;
            pnlButton.Location = new Point(0, 514);
            pnlButton.Margin = new Padding(3, 4, 3, 4);
            pnlButton.Name = "pnlButton";
            pnlButton.Size = new Size(1003, 133);
            pnlButton.TabIndex = 4;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.Font = new Font("MS PGothic", 48F, FontStyle.Bold);
            btnPrevious.Location = new Point(137, 15);
            btnPrevious.Margin = new Padding(3, 4, 3, 4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(106, 98);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFirst.Cursor = Cursors.Hand;
            btnFirst.Font = new Font("MS PGothic", 36F, FontStyle.Bold);
            btnFirst.Location = new Point(14, 15);
            btnFirst.Margin = new Padding(3, 4, 3, 4);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(106, 98);
            btnFirst.TabIndex = 2;
            btnFirst.Text = "<<";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnLast
            // 
            btnLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLast.Cursor = Cursors.Hand;
            btnLast.Font = new Font("MS PGothic", 36F, FontStyle.Bold);
            btnLast.Location = new Point(885, 15);
            btnLast.Margin = new Padding(3, 4, 3, 4);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(106, 98);
            btnLast.TabIndex = 1;
            btnLast.Text = ">>";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Cursor = Cursors.Hand;
            btnNext.Font = new Font("MS PGothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(771, 15);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(106, 98);
            btnNext.TabIndex = 0;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // pnlDisplayEngin
            // 
            pnlDisplayEngin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDisplayEngin.BackColor = SystemColors.Desktop;
            pnlDisplayEngin.Location = new Point(0, 97);
            pnlDisplayEngin.Margin = new Padding(3, 4, 3, 4);
            pnlDisplayEngin.Name = "pnlDisplayEngin";
            pnlDisplayEngin.Size = new Size(1003, 410);
            pnlDisplayEngin.TabIndex = 3;
            // 
            // pnlCaserneChoice
            // 
            pnlCaserneChoice.BackColor = Color.Snow;
            pnlCaserneChoice.Controls.Add(cbxChoixCaserne);
            pnlCaserneChoice.Controls.Add(lblTitleCaserne);
            pnlCaserneChoice.Dock = DockStyle.Top;
            pnlCaserneChoice.Location = new Point(0, 0);
            pnlCaserneChoice.Margin = new Padding(3, 4, 3, 4);
            pnlCaserneChoice.Name = "pnlCaserneChoice";
            pnlCaserneChoice.Size = new Size(1003, 90);
            pnlCaserneChoice.TabIndex = 2;
            // 
            // GestionEngins
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Transparent;
            Controls.Add(pnlGestionEngin);
            Margin = new Padding(2, 2, 2, 2);
            Name = "GestionEngins";
            Size = new Size(1003, 647);
            Load += UCGestionEngin_Load;
            pnlGestionEngin.ResumeLayout(false);
            pnlButton.ResumeLayout(false);
            pnlCaserneChoice.ResumeLayout(false);
            pnlCaserneChoice.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleCaserne;
        private System.Windows.Forms.ComboBox cbxChoixCaserne;
        private System.Windows.Forms.Panel pnlGestionEngin;
        private System.Windows.Forms.Panel pnlCaserneChoice;
        private System.Windows.Forms.Panel pnlDisplayEngin;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
    }
}
