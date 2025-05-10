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
            this.cbxCaserne = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabStatistique.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpEngins.SuspendLayout();
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
            this.tabStatistique.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabStatistique.Name = "tabStatistique";
            this.tabStatistique.SelectedIndex = 0;
            this.tabStatistique.Size = new System.Drawing.Size(1200, 796);
            this.tabStatistique.TabIndex = 0;
            this.tabStatistique.SelectedIndexChanged += new System.EventHandler(this.tabStatistique_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpEngins);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1192, 757);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Engins";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpEngins
            // 
            this.grpEngins.Controls.Add(this.cbxCaserne);
            this.grpEngins.Controls.Add(this.lblCaserne);
            this.grpEngins.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpEngins.Location = new System.Drawing.Point(4, 5);
            this.grpEngins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEngins.Name = "grpEngins";
            this.grpEngins.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEngins.Size = new System.Drawing.Size(1174, 747);
            this.grpEngins.TabIndex = 0;
            this.grpEngins.TabStop = false;
            this.grpEngins.Text = "Statistique reltives au Engins";
            // 
            // cbxCaserne
            // 
            this.cbxCaserne.FormattingEnabled = true;
            this.cbxCaserne.Location = new System.Drawing.Point(288, 30);
            this.cbxCaserne.Name = "cbxCaserne";
            this.cbxCaserne.Size = new System.Drawing.Size(272, 31);
            this.cbxCaserne.TabIndex = 1;
            this.cbxCaserne.SelectedIndexChanged += new System.EventHandler(this.cbxCaserne_SelectedIndexChanged);
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(199, 33);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(82, 23);
            this.lblCaserne.TabIndex = 0;
            this.lblCaserne.Text = "Caserne : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1192, 757);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Intervention";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(1192, 757);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Habilitation";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // UCStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tabStatistique);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCStatistique";
            this.Size = new System.Drawing.Size(1200, 796);
            this.tabStatistique.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpEngins.ResumeLayout(false);
            this.grpEngins.PerformLayout();
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
    }
}
