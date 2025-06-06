namespace UCGestionPerso
{
    partial class UCRichButton
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
            if(disposing && (components != null))
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 127);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RichButton_MouseClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.UCRichButton_MouseEnter);
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.Location = new System.Drawing.Point(153, 52);
            this.lblInfo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(184, 25);
            this.lblInfo1.TabIndex = 1;
            this.lblInfo1.Text = "Information num 1";
            this.lblInfo1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RichButton_MouseClick);
            this.lblInfo1.MouseEnter += new System.EventHandler(this.UCRichButton_MouseEnter);
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.Location = new System.Drawing.Point(153, 81);
            this.lblInfo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(167, 25);
            this.lblInfo2.TabIndex = 2;
            this.lblInfo2.Text = "Information num 2";
            this.lblInfo2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RichButton_MouseClick);
            this.lblInfo2.MouseEnter += new System.EventHandler(this.UCRichButton_MouseEnter);
            // 
            // UCRichButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCRichButton";
            this.Size = new System.Drawing.Size(361, 150);
            this.Load += new System.EventHandler(this.UCRichButton_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RichButton_MouseClick);
            this.MouseEnter += new System.EventHandler(this.UCRichButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCRichButton_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
    }
}
