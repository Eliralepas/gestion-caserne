namespace UCGestionEngins
{
    partial class UCGestionEngin
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
            this.lblTitleCaserne = new System.Windows.Forms.Label();
            this.cbxChoixCaserne = new System.Windows.Forms.ComboBox();
            this.pnlGestionEngin = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlDisplayEngin = new System.Windows.Forms.Panel();
            this.pnlCaserneChoice = new System.Windows.Forms.Panel();
            this.pnlGestionEngin.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlCaserneChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleCaserne
            // 
            this.lblTitleCaserne.AutoSize = true;
            this.lblTitleCaserne.Font = new System.Drawing.Font("Arial", 13.8F);
            this.lblTitleCaserne.Location = new System.Drawing.Point(69, 29);
            this.lblTitleCaserne.Name = "lblTitleCaserne";
            this.lblTitleCaserne.Size = new System.Drawing.Size(233, 26);
            this.lblTitleCaserne.TabIndex = 0;
            this.lblTitleCaserne.Text = "Choix de la carserne :";
            // 
            // cbxChoixCaserne
            // 
            this.cbxChoixCaserne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxChoixCaserne.FormattingEnabled = true;
            this.cbxChoixCaserne.Location = new System.Drawing.Point(308, 31);
            this.cbxChoixCaserne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxChoixCaserne.Name = "cbxChoixCaserne";
            this.cbxChoixCaserne.Size = new System.Drawing.Size(248, 24);
            this.cbxChoixCaserne.TabIndex = 1;
            this.cbxChoixCaserne.SelectionChangeCommitted += new System.EventHandler(this.cbxChoixCaserne_SelectionChangeCommitted);
            // 
            // pnlGestionEngin
            // 
            this.pnlGestionEngin.BackColor = System.Drawing.Color.Red;
            this.pnlGestionEngin.Controls.Add(this.pnlButton);
            this.pnlGestionEngin.Controls.Add(this.pnlDisplayEngin);
            this.pnlGestionEngin.Controls.Add(this.pnlCaserneChoice);
            this.pnlGestionEngin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGestionEngin.Location = new System.Drawing.Point(0, 0);
            this.pnlGestionEngin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGestionEngin.Name = "pnlGestionEngin";
            this.pnlGestionEngin.Size = new System.Drawing.Size(735, 626);
            this.pnlGestionEngin.TabIndex = 2;
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Silver;
            this.pnlButton.Controls.Add(this.btnPrevious);
            this.pnlButton.Controls.Add(this.btnFirst);
            this.pnlButton.Controls.Add(this.btnLast);
            this.pnlButton.Controls.Add(this.btnNext);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 493);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(735, 133);
            this.pnlButton.TabIndex = 4;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Font = new System.Drawing.Font("MS PGothic", 48F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.Location = new System.Drawing.Point(171, 15);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(133, 98);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.Font = new System.Drawing.Font("MS PGothic", 36F, System.Drawing.FontStyle.Bold);
            this.btnFirst.Location = new System.Drawing.Point(17, 15);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(133, 98);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.Font = new System.Drawing.Font("MS PGothic", 36F, System.Drawing.FontStyle.Bold);
            this.btnLast.Location = new System.Drawing.Point(587, 15);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(133, 98);
            this.btnLast.TabIndex = 1;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("MS PGothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(445, 15);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 98);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlDisplayEngin
            // 
            this.pnlDisplayEngin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDisplayEngin.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnlDisplayEngin.Location = new System.Drawing.Point(0, 97);
            this.pnlDisplayEngin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDisplayEngin.Name = "pnlDisplayEngin";
            this.pnlDisplayEngin.Size = new System.Drawing.Size(735, 389);
            this.pnlDisplayEngin.TabIndex = 3;
            // 
            // pnlCaserneChoice
            // 
            this.pnlCaserneChoice.BackColor = System.Drawing.Color.Snow;
            this.pnlCaserneChoice.Controls.Add(this.cbxChoixCaserne);
            this.pnlCaserneChoice.Controls.Add(this.lblTitleCaserne);
            this.pnlCaserneChoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCaserneChoice.Location = new System.Drawing.Point(0, 0);
            this.pnlCaserneChoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCaserneChoice.Name = "pnlCaserneChoice";
            this.pnlCaserneChoice.Size = new System.Drawing.Size(735, 90);
            this.pnlCaserneChoice.TabIndex = 2;
            // 
            // UCGestionEngin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlGestionEngin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCGestionEngin";
            this.Size = new System.Drawing.Size(735, 626);
            this.Load += new System.EventHandler(this.UCGestionEngin_Load);
            this.pnlGestionEngin.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.pnlCaserneChoice.ResumeLayout(false);
            this.pnlCaserneChoice.PerformLayout();
            this.ResumeLayout(false);

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
