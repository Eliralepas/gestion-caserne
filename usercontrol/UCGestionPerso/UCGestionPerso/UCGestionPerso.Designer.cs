namespace UCGestionPerso
{
    partial class UCGestionPerso
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
            this.flpCaserne = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPompier = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpCaserne
            // 
            this.flpCaserne.AutoScroll = true;
            this.flpCaserne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpCaserne.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCaserne.Location = new System.Drawing.Point(5, 5);
            this.flpCaserne.Margin = new System.Windows.Forms.Padding(5);
            this.flpCaserne.Name = "flpCaserne";
            this.flpCaserne.Size = new System.Drawing.Size(211, 541);
            this.flpCaserne.TabIndex = 0;
            this.flpCaserne.WrapContents = false;
            // 
            // flpPompier
            // 
            this.flpPompier.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flpPompier.Location = new System.Drawing.Point(226, 5);
            this.flpPompier.Margin = new System.Windows.Forms.Padding(5);
            this.flpPompier.Name = "flpPompier";
            this.flpPompier.Size = new System.Drawing.Size(239, 620);
            this.flpPompier.TabIndex = 1;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Red;
            this.pnlInfo.Location = new System.Drawing.Point(475, 5);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(5);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(510, 620);
            this.pnlInfo.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(3, 554);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(215, 71);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Nouveau Pompier";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // UCGestionPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.flpPompier);
            this.Controls.Add(this.flpCaserne);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCGestionPerso";
            this.Size = new System.Drawing.Size(990, 630);
            this.Load += new System.EventHandler(this.UCGestionPerso_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCaserne;
        private System.Windows.Forms.FlowLayoutPanel flpPompier;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnCreate;
    }
}
